namespace lesson
{
    partial class PetForm
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
            this.PetPanel = new System.Windows.Forms.Panel();
            this.btnAddPetClose = new System.Windows.Forms.Button();
            this.btnAddPetSave = new System.Windows.Forms.Button();
            this.petBirthdayInput = new System.Windows.Forms.DateTimePicker();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.comboBreed = new System.Windows.Forms.ComboBox();
            this.comboPetType = new System.Windows.Forms.ComboBox();
            this.aliasInput = new System.Windows.Forms.TextBox();
            this.labelAddPetDate = new System.Windows.Forms.Label();
            this.labelAddPetSex = new System.Windows.Forms.Label();
            this.labelAddPetBreed = new System.Windows.Forms.Label();
            this.labelAddPetType = new System.Windows.Forms.Label();
            this.labelAddPetAlias = new System.Windows.Forms.Label();
            this.PetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PetPanel
            // 
            this.PetPanel.BackColor = System.Drawing.Color.White;
            this.PetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PetPanel.Controls.Add(this.btnAddPetClose);
            this.PetPanel.Controls.Add(this.btnAddPetSave);
            this.PetPanel.Controls.Add(this.petBirthdayInput);
            this.PetPanel.Controls.Add(this.comboSex);
            this.PetPanel.Controls.Add(this.comboBreed);
            this.PetPanel.Controls.Add(this.comboPetType);
            this.PetPanel.Controls.Add(this.aliasInput);
            this.PetPanel.Controls.Add(this.labelAddPetDate);
            this.PetPanel.Controls.Add(this.labelAddPetSex);
            this.PetPanel.Controls.Add(this.labelAddPetBreed);
            this.PetPanel.Controls.Add(this.labelAddPetType);
            this.PetPanel.Controls.Add(this.labelAddPetAlias);
            this.PetPanel.Location = new System.Drawing.Point(13, 13);
            this.PetPanel.Name = "PetPanel";
            this.PetPanel.Size = new System.Drawing.Size(464, 486);
            this.PetPanel.TabIndex = 0;
            // 
            // btnAddPetClose
            // 
            this.btnAddPetClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPetClose.Location = new System.Drawing.Point(290, 429);
            this.btnAddPetClose.Name = "btnAddPetClose";
            this.btnAddPetClose.Size = new System.Drawing.Size(115, 25);
            this.btnAddPetClose.TabIndex = 11;
            this.btnAddPetClose.Text = "Отмена";
            this.btnAddPetClose.UseVisualStyleBackColor = true;
            this.btnAddPetClose.Click += new System.EventHandler(this.btnAddPetClose_Click);
            // 
            // btnAddPetSave
            // 
            this.btnAddPetSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPetSave.Location = new System.Drawing.Point(66, 429);
            this.btnAddPetSave.Name = "btnAddPetSave";
            this.btnAddPetSave.Size = new System.Drawing.Size(115, 25);
            this.btnAddPetSave.TabIndex = 10;
            this.btnAddPetSave.Text = "Сохранить";
            this.btnAddPetSave.UseVisualStyleBackColor = true;
            this.btnAddPetSave.Click += new System.EventHandler(this.btnAddPetSave_Click);
            // 
            // petBirthdayInput
            // 
            this.petBirthdayInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petBirthdayInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.petBirthdayInput.Location = new System.Drawing.Point(151, 273);
            this.petBirthdayInput.Name = "petBirthdayInput";
            this.petBirthdayInput.Size = new System.Drawing.Size(266, 29);
            this.petBirthdayInput.TabIndex = 9;
            // 
            // comboSex
            // 
            this.comboSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboSex.FormattingEnabled = true;
            this.comboSex.Location = new System.Drawing.Point(151, 209);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(266, 32);
            this.comboSex.TabIndex = 8;
            // 
            // comboBreed
            // 
            this.comboBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBreed.FormattingEnabled = true;
            this.comboBreed.Location = new System.Drawing.Point(151, 147);
            this.comboBreed.Name = "comboBreed";
            this.comboBreed.Size = new System.Drawing.Size(266, 32);
            this.comboBreed.TabIndex = 7;
            // 
            // comboPetType
            // 
            this.comboPetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboPetType.FormattingEnabled = true;
            this.comboPetType.Location = new System.Drawing.Point(151, 85);
            this.comboPetType.Name = "comboPetType";
            this.comboPetType.Size = new System.Drawing.Size(266, 32);
            this.comboPetType.TabIndex = 6;
            this.comboPetType.SelectedIndexChanged += new System.EventHandler(this.comboPetType_SelectedIndexChanged);
            // 
            // aliasInput
            // 
            this.aliasInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aliasInput.Location = new System.Drawing.Point(151, 32);
            this.aliasInput.Name = "aliasInput";
            this.aliasInput.Size = new System.Drawing.Size(266, 29);
            this.aliasInput.TabIndex = 5;
            // 
            // labelAddPetDate
            // 
            this.labelAddPetDate.AutoSize = true;
            this.labelAddPetDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddPetDate.Location = new System.Drawing.Point(22, 278);
            this.labelAddPetDate.Name = "labelAddPetDate";
            this.labelAddPetDate.Size = new System.Drawing.Size(112, 24);
            this.labelAddPetDate.TabIndex = 4;
            this.labelAddPetDate.Text = "Дата рожд:";
            // 
            // labelAddPetSex
            // 
            this.labelAddPetSex.AutoSize = true;
            this.labelAddPetSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddPetSex.Location = new System.Drawing.Point(22, 217);
            this.labelAddPetSex.Name = "labelAddPetSex";
            this.labelAddPetSex.Size = new System.Drawing.Size(49, 24);
            this.labelAddPetSex.TabIndex = 3;
            this.labelAddPetSex.Text = "Пол:";
            // 
            // labelAddPetBreed
            // 
            this.labelAddPetBreed.AutoSize = true;
            this.labelAddPetBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddPetBreed.Location = new System.Drawing.Point(22, 155);
            this.labelAddPetBreed.Name = "labelAddPetBreed";
            this.labelAddPetBreed.Size = new System.Drawing.Size(83, 24);
            this.labelAddPetBreed.TabIndex = 2;
            this.labelAddPetBreed.Text = "Порода:";
            // 
            // labelAddPetType
            // 
            this.labelAddPetType.AutoSize = true;
            this.labelAddPetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddPetType.Location = new System.Drawing.Point(22, 93);
            this.labelAddPetType.Name = "labelAddPetType";
            this.labelAddPetType.Size = new System.Drawing.Size(50, 24);
            this.labelAddPetType.TabIndex = 1;
            this.labelAddPetType.Text = "Вид:";
            // 
            // labelAddPetAlias
            // 
            this.labelAddPetAlias.AutoSize = true;
            this.labelAddPetAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddPetAlias.Location = new System.Drawing.Point(22, 35);
            this.labelAddPetAlias.Name = "labelAddPetAlias";
            this.labelAddPetAlias.Size = new System.Drawing.Size(89, 24);
            this.labelAddPetAlias.TabIndex = 0;
            this.labelAddPetAlias.Text = "Кличка: *";
            // 
            // PetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 516);
            this.Controls.Add(this.PetPanel);
            this.Name = "PetForm";
            this.ShowIcon = false;
            this.Text = "Добавление питомца";
            this.Load += new System.EventHandler(this.PetForm_Load);
            this.PetPanel.ResumeLayout(false);
            this.PetPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PetPanel;
        private System.Windows.Forms.Label labelAddPetDate;
        private System.Windows.Forms.Label labelAddPetSex;
        private System.Windows.Forms.Label labelAddPetBreed;
        private System.Windows.Forms.Label labelAddPetType;
        private System.Windows.Forms.Label labelAddPetAlias;
        private System.Windows.Forms.DateTimePicker petBirthdayInput;
        private System.Windows.Forms.ComboBox comboSex;
        private System.Windows.Forms.ComboBox comboBreed;
        private System.Windows.Forms.ComboBox comboPetType;
        private System.Windows.Forms.TextBox aliasInput;
        private System.Windows.Forms.Button btnAddPetClose;
        private System.Windows.Forms.Button btnAddPetSave;
    }
}