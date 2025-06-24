namespace lesson
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTopLine = new System.Windows.Forms.Panel();
            this.labelClient = new System.Windows.Forms.Label();
            this.comboClients = new System.Windows.Forms.ComboBox();
            this.btnSettingsApi = new System.Windows.Forms.Button();
            this.labelPetsByClient = new System.Windows.Forms.Label();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.btnEditPet = new System.Windows.Forms.Button();
            this.btnDelPet = new System.Windows.Forms.Button();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPetType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBreed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopLine
            // 
            this.panelTopLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopLine.BackColor = System.Drawing.Color.Black;
            this.panelTopLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelTopLine.Location = new System.Drawing.Point(0, 1);
            this.panelTopLine.Name = "panelTopLine";
            this.panelTopLine.Size = new System.Drawing.Size(864, 2);
            this.panelTopLine.TabIndex = 3;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(12, 26);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(93, 24);
            this.labelClient.TabIndex = 4;
            this.labelClient.Text = "Клиенты:";
            // 
            // comboClients
            // 
            this.comboClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboClients.FormattingEnabled = true;
            this.comboClients.Location = new System.Drawing.Point(111, 18);
            this.comboClients.Name = "comboClients";
            this.comboClients.Size = new System.Drawing.Size(331, 32);
            this.comboClients.TabIndex = 5;
            this.comboClients.SelectedIndexChanged += new System.EventHandler(this.comboClients_SelectedIndexChanged);
            this.comboClients.TextChanged += new System.EventHandler(this.ComboClientsTextChanged);
            // 
            // btnSettingsApi
            // 
            this.btnSettingsApi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettingsApi.Location = new System.Drawing.Point(652, 22);
            this.btnSettingsApi.Name = "btnSettingsApi";
            this.btnSettingsApi.Size = new System.Drawing.Size(192, 32);
            this.btnSettingsApi.TabIndex = 6;
            this.btnSettingsApi.Text = "Настройки API";
            this.btnSettingsApi.UseVisualStyleBackColor = true;
            this.btnSettingsApi.Click += new System.EventHandler(this.btnSettingsApi_Click);
            // 
            // labelPetsByClient
            // 
            this.labelPetsByClient.AutoSize = true;
            this.labelPetsByClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPetsByClient.Location = new System.Drawing.Point(16, 149);
            this.labelPetsByClient.Name = "labelPetsByClient";
            this.labelPetsByClient.Size = new System.Drawing.Size(174, 24);
            this.labelPetsByClient.TabIndex = 7;
            this.labelPetsByClient.Text = "Питомцы клиента:";
            // 
            // btnAddPet
            // 
            this.btnAddPet.Enabled = false;
            this.btnAddPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPet.Location = new System.Drawing.Point(303, 148);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(115, 25);
            this.btnAddPet.TabIndex = 8;
            this.btnAddPet.TabStop = false;
            this.btnAddPet.Text = "Добавить";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // btnEditPet
            // 
            this.btnEditPet.Enabled = false;
            this.btnEditPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPet.Location = new System.Drawing.Point(453, 148);
            this.btnEditPet.Name = "btnEditPet";
            this.btnEditPet.Size = new System.Drawing.Size(115, 25);
            this.btnEditPet.TabIndex = 9;
            this.btnEditPet.TabStop = false;
            this.btnEditPet.Text = "Редактировать";
            this.btnEditPet.UseVisualStyleBackColor = true;
            this.btnEditPet.Click += new System.EventHandler(this.btnEditPet_Click);
            // 
            // btnDelPet
            // 
            this.btnDelPet.Enabled = false;
            this.btnDelPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelPet.Location = new System.Drawing.Point(601, 148);
            this.btnDelPet.Name = "btnDelPet";
            this.btnDelPet.Size = new System.Drawing.Size(115, 25);
            this.btnDelPet.TabIndex = 10;
            this.btnDelPet.Text = "Удалить";
            this.btnDelPet.UseVisualStyleBackColor = true;
            this.btnDelPet.Click += new System.EventHandler(this.btnDelPet_Click);
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToResizeRows = false;
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGridView.ColumnHeadersHeight = 40;
            this.mainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colPetType,
            this.colBreed,
            this.colGender,
            this.colBirthdate});
            this.mainDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainDataGridView.Location = new System.Drawing.Point(20, 192);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.mainDataGridView.RowHeadersVisible = false;
            this.mainDataGridView.RowTemplate.Height = 40;
            this.mainDataGridView.RowTemplate.ReadOnly = true;
            this.mainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDataGridView.Size = new System.Drawing.Size(824, 320);
            this.mainDataGridView.TabIndex = 11;
            this.mainDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGridView_CellContentClick);
            // 
            // colId
            // 
            this.colId.FillWeight = 50F;
            this.colId.HeaderText = "#";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.FillWeight = 89.54315F;
            this.colName.HeaderText = "Кличка";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPetType
            // 
            this.colPetType.FillWeight = 89.54315F;
            this.colPetType.HeaderText = "Вид";
            this.colPetType.Name = "colPetType";
            this.colPetType.ReadOnly = true;
            // 
            // colBreed
            // 
            this.colBreed.FillWeight = 89.54315F;
            this.colBreed.HeaderText = "Порода";
            this.colBreed.Name = "colBreed";
            this.colBreed.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.FillWeight = 89.54315F;
            this.colGender.HeaderText = "Пол";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // colBirthdate
            // 
            this.colBirthdate.FillWeight = 89.54315F;
            this.colBirthdate.HeaderText = "Дата рождения";
            this.colBirthdate.Name = "colBirthdate";
            this.colBirthdate.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 534);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.btnDelPet);
            this.Controls.Add(this.btnEditPet);
            this.Controls.Add(this.btnAddPet);
            this.Controls.Add(this.labelPetsByClient);
            this.Controls.Add(this.btnSettingsApi);
            this.Controls.Add(this.comboClients);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.panelTopLine);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTopLine;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox comboClients;
        private System.Windows.Forms.Button btnSettingsApi;
        private System.Windows.Forms.Label labelPetsByClient;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Button btnEditPet;
        private System.Windows.Forms.Button btnDelPet;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPetType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBreed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthdate;
    }
}