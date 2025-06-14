namespace lesson
{
    partial class SettingsForm
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
            this.btnSettingsClose = new System.Windows.Forms.Button();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.settingsLabelDomain = new System.Windows.Forms.Label();
            this.settingsBtnConnect = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.settingsTextBoxDomain = new System.Windows.Forms.TextBox();
            this.settingsLabelPassword = new System.Windows.Forms.Label();
            this.settingsLabelLogin = new System.Windows.Forms.Label();
            this.settingsMainLabel = new System.Windows.Forms.Label();
            this.settingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettingsClose
            // 
            this.btnSettingsClose.BackColor = System.Drawing.Color.White;
            this.btnSettingsClose.FlatAppearance.BorderSize = 0;
            this.btnSettingsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettingsClose.Location = new System.Drawing.Point(725, 0);
            this.btnSettingsClose.Name = "btnSettingsClose";
            this.btnSettingsClose.Size = new System.Drawing.Size(30, 30);
            this.btnSettingsClose.TabIndex = 0;
            this.btnSettingsClose.Text = "X";
            this.btnSettingsClose.UseVisualStyleBackColor = false;
            this.btnSettingsClose.Click += new System.EventHandler(this.btnSettingsClose_Click);
            // 
            // settingPanel
            // 
            this.settingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingPanel.Controls.Add(this.settingsLabelDomain);
            this.settingPanel.Controls.Add(this.settingsBtnConnect);
            this.settingPanel.Controls.Add(this.textBox3);
            this.settingPanel.Controls.Add(this.textBox2);
            this.settingPanel.Controls.Add(this.settingsTextBoxDomain);
            this.settingPanel.Controls.Add(this.settingsLabelPassword);
            this.settingPanel.Controls.Add(this.settingsLabelLogin);
            this.settingPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingPanel.Location = new System.Drawing.Point(12, 40);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(731, 287);
            this.settingPanel.TabIndex = 1;
            this.settingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_mouseDown);
            // 
            // settingsLabelDomain
            // 
            this.settingsLabelDomain.AutoSize = true;
            this.settingsLabelDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsLabelDomain.Location = new System.Drawing.Point(44, 25);
            this.settingsLabelDomain.Name = "settingsLabelDomain";
            this.settingsLabelDomain.Size = new System.Drawing.Size(70, 24);
            this.settingsLabelDomain.TabIndex = 7;
            this.settingsLabelDomain.Text = "Домен";
            // 
            // settingsBtnConnect
            // 
            this.settingsBtnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsBtnConnect.Location = new System.Drawing.Point(278, 220);
            this.settingsBtnConnect.Name = "settingsBtnConnect";
            this.settingsBtnConnect.Size = new System.Drawing.Size(183, 37);
            this.settingsBtnConnect.TabIndex = 6;
            this.settingsBtnConnect.Text = "Подключение";
            this.settingsBtnConnect.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(148, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(338, 29);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(148, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 29);
            this.textBox2.TabIndex = 4;
            // 
            // settingsTextBoxDomain
            // 
            this.settingsTextBoxDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsTextBoxDomain.Location = new System.Drawing.Point(148, 25);
            this.settingsTextBoxDomain.Name = "settingsTextBoxDomain";
            this.settingsTextBoxDomain.Size = new System.Drawing.Size(338, 29);
            this.settingsTextBoxDomain.TabIndex = 3;
            // 
            // settingsLabelPassword
            // 
            this.settingsLabelPassword.AutoSize = true;
            this.settingsLabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsLabelPassword.Location = new System.Drawing.Point(44, 143);
            this.settingsLabelPassword.Name = "settingsLabelPassword";
            this.settingsLabelPassword.Size = new System.Drawing.Size(76, 24);
            this.settingsLabelPassword.TabIndex = 2;
            this.settingsLabelPassword.Text = "Пароль";
            // 
            // settingsLabelLogin
            // 
            this.settingsLabelLogin.AutoSize = true;
            this.settingsLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsLabelLogin.Location = new System.Drawing.Point(44, 85);
            this.settingsLabelLogin.Name = "settingsLabelLogin";
            this.settingsLabelLogin.Size = new System.Drawing.Size(64, 24);
            this.settingsLabelLogin.TabIndex = 1;
            this.settingsLabelLogin.Text = "Логин";
            // 
            // settingsMainLabel
            // 
            this.settingsMainLabel.AutoSize = true;
            this.settingsMainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsMainLabel.Location = new System.Drawing.Point(12, 13);
            this.settingsMainLabel.Name = "settingsMainLabel";
            this.settingsMainLabel.Size = new System.Drawing.Size(140, 24);
            this.settingsMainLabel.TabIndex = 2;
            this.settingsMainLabel.Text = "Настройки API";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 339);
            this.Controls.Add(this.settingsMainLabel);
            this.Controls.Add(this.settingPanel);
            this.Controls.Add(this.btnSettingsClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.settingPanel.ResumeLayout(false);
            this.settingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettingsClose;
        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.Label settingsMainLabel;
        private System.Windows.Forms.Button settingsBtnConnect;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox settingsTextBoxDomain;
        private System.Windows.Forms.Label settingsLabelPassword;
        private System.Windows.Forms.Label settingsLabelLogin;
        private System.Windows.Forms.Label settingsLabelDomain;
    }
}