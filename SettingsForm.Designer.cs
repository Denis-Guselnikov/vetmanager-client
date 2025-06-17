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
            this.settingPanel = new System.Windows.Forms.Panel();
            this.settingsLabelDomain = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.DomainInput = new System.Windows.Forms.TextBox();
            this.settingsLabelPassword = new System.Windows.Forms.Label();
            this.settingsLabelLogin = new System.Windows.Forms.Label();
            this.settingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingPanel
            // 
            this.settingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingPanel.Controls.Add(this.settingsLabelDomain);
            this.settingPanel.Controls.Add(this.btnConnect);
            this.settingPanel.Controls.Add(this.PasswordInput);
            this.settingPanel.Controls.Add(this.LoginInput);
            this.settingPanel.Controls.Add(this.DomainInput);
            this.settingPanel.Controls.Add(this.settingsLabelPassword);
            this.settingPanel.Controls.Add(this.settingsLabelLogin);
            this.settingPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingPanel.Location = new System.Drawing.Point(12, 12);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(691, 292);
            this.settingPanel.TabIndex = 1;
            // 
            // settingsLabelDomain
            // 
            this.settingsLabelDomain.AutoSize = true;
            this.settingsLabelDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsLabelDomain.Location = new System.Drawing.Point(45, 25);
            this.settingsLabelDomain.Name = "settingsLabelDomain";
            this.settingsLabelDomain.Size = new System.Drawing.Size(70, 24);
            this.settingsLabelDomain.TabIndex = 7;
            this.settingsLabelDomain.Text = "Домен";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.Location = new System.Drawing.Point(279, 223);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(143, 36);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Подключение";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordInput.Location = new System.Drawing.Point(147, 143);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(337, 29);
            this.PasswordInput.TabIndex = 5;
            // 
            // LoginInput
            // 
            this.LoginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginInput.Location = new System.Drawing.Point(147, 85);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(337, 29);
            this.LoginInput.TabIndex = 4;
            // 
            // DomainInput
            // 
            this.DomainInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DomainInput.Location = new System.Drawing.Point(147, 25);
            this.DomainInput.Name = "DomainInput";
            this.DomainInput.Size = new System.Drawing.Size(337, 29);
            this.DomainInput.TabIndex = 3;
            // 
            // settingsLabelPassword
            // 
            this.settingsLabelPassword.AutoSize = true;
            this.settingsLabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsLabelPassword.Location = new System.Drawing.Point(45, 143);
            this.settingsLabelPassword.Name = "settingsLabelPassword";
            this.settingsLabelPassword.Size = new System.Drawing.Size(76, 24);
            this.settingsLabelPassword.TabIndex = 2;
            this.settingsLabelPassword.Text = "Пароль";
            // 
            // settingsLabelLogin
            // 
            this.settingsLabelLogin.AutoSize = true;
            this.settingsLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsLabelLogin.Location = new System.Drawing.Point(45, 85);
            this.settingsLabelLogin.Name = "settingsLabelLogin";
            this.settingsLabelLogin.Size = new System.Drawing.Size(64, 24);
            this.settingsLabelLogin.TabIndex = 1;
            this.settingsLabelLogin.Text = "Логин";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 316);
            this.Controls.Add(this.settingPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Настройки API";
            this.settingPanel.ResumeLayout(false);
            this.settingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox DomainInput;
        private System.Windows.Forms.Label settingsLabelPassword;
        private System.Windows.Forms.Label settingsLabelLogin;
        private System.Windows.Forms.Label settingsLabelDomain;
    }
}