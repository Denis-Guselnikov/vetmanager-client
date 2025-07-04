﻿using lesson.helpers;
using lesson.response;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson
{
    public partial class MainForm : Form
    {
        private List<Client> clients;
        private AppSettings settings;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            settings = new AppSettings().LoadSettingFromXml();

            if (settings != null)
            {
                await LoadClientsAsync();
            }          
        }

        private async void btnSettingsApi_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();

            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Данные сохранены");

                settings = new AppSettings().LoadSettingFromXml();
                await LoadClientsAsync();               
            }
        }        

        private async Task LoadClientsAsync()
        {
            try
            {
                string url = $"https://{settings.Domain}.vetmanager2.ru/rest/api/client/clientsSearchData";
                var client = CreateClient(settings);

                HttpResponseMessage response = await client.GetAsync(url);
                string result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ошибка получения клиентов!", "Ошибка");
                    return;
                }

                var clientResponse = JsonSerializer.Deserialize<ClientResponseData>(result);
                clients = clientResponse.data.client;

                if (clients != null)
                {
                    comboClients.DataSource = null;
                    comboClients.DataSource = clients;
                    comboClients.DisplayMember = "fio";
                    comboClients.ValueMember = "client_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        private HttpClient CreateClient(AppSettings settings)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-APP-NAME", settings.Service);
            client.DefaultRequestHeaders.Add("X-USER-TOKEN", settings.Token);
            return client;
        }

        private void comboClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainDataGridView.Rows.Clear();

            if (comboClients.SelectedItem is Client selectedClient)
            {
                int clientId = selectedClient.client_id;
                var selected = clients.FirstOrDefault(clients => clients.client_id == clientId);

                if (selected != null && selected.pets != null)
                {
                    foreach (var pet in selected.pets)
                    {
                        mainDataGridView.Rows.Add(
                            pet.pet_id,
                            pet.alias,
                            pet.pet_type_title,
                            pet.breed,
                            pet.sex,
                            pet.birthday
                            );
                    }

                    btnAddPet.Enabled = true;
                }
            }
        }

        private void ComboClientsTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboClients.Text))
            {
                mainDataGridView.Rows.Clear();
                btnAddPet.Enabled = false;
                btnEditPet.Enabled = false;
                btnDelPet.Enabled = false;
            }
        }

        private void mainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditPet.Enabled = true;
            btnDelPet.Enabled = true;
        }

        private async void btnAddPet_Click(object sender, EventArgs e)
        {
            if (comboClients.SelectedItem is Client selectedCilent)
            {
                PetForm petForm = new PetForm(selectedCilent.client_id);
                
                if (petForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadClientsAsync();
                }
            }
        }

        private async void btnEditPet_Click(object sender, EventArgs e)
        {
            if (comboClients.SelectedItem is Client selectedCilent)
            {
                int petId = Convert.ToInt32(mainDataGridView.SelectedRows[0].Cells["colId"].Value);
                var selectedPet = selectedCilent.pets.FirstOrDefault(pet => pet.pet_id == petId);


                PetForm petForm = new PetForm(selectedCilent.client_id, selectedPet);

                if (petForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadClientsAsync();
                }
            }
        }

        private void btnDelPet_Click(object sender, EventArgs e)
        {
            var confirmMessage = MessageBox.Show(
                "Вы уверены, что хотите удалить этого питомца?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo
            );

            if (confirmMessage == DialogResult.Yes)
            {
                int petId = Convert.ToInt32(mainDataGridView.SelectedRows[0].Cells["colId"].Value);
                Delete(petId);
            }            
        }

        private async void Delete(int petId)
        {
            var client = CreateClient(settings);
            string url = $"https://{settings.Domain}.vetmanager2.ru/rest/api/pet/{petId}";

            try
            {
                HttpResponseMessage response = await client.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Питомец успешно удалён.");
                    await LoadClientsAsync();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Ошибка при удалении: {error}", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
    }
}
