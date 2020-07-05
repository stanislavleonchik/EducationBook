namespace Edbook.WinForms.Forms.Others
{
    partial class Others_UserPasswrods
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
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox_password = new FontAwesome.Sharp.IconPictureBox();
            this.textBox_oldPass = new System.Windows.Forms.TextBox();
            this.iconPictureBox_Persona = new FontAwesome.Sharp.IconPictureBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.checkBoxPasswords = new System.Windows.Forms.CheckBox();
            this.comboBoxOfUsers = new System.Windows.Forms.ComboBox();
            this.panelUnderlinePassword = new System.Windows.Forms.Panel();
            this.panelUnderlineUsername = new System.Windows.Forms.Panel();
            this.buttonRedactPass = new System.Windows.Forms.Button();
            this.iconPictureBox_newPassword = new FontAwesome.Sharp.IconPictureBox();
            this.textBox_newPass = new System.Windows.Forms.TextBox();
            this.panelUnderLineNewPassword = new System.Windows.Forms.Panel();
            this.toolTipOnPass1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOnPass2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Persona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_newPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelName.Location = new System.Drawing.Point(338, 144);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(250, 23);
            this.labelName.TabIndex = 31;
            this.labelName.Text = "EdBook - Смена паролей";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconSize = 160;
            this.iconPictureBox1.Location = new System.Drawing.Point(387, 15);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(160, 160);
            this.iconPictureBox1.TabIndex = 30;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox_password
            // 
            this.iconPictureBox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox_password.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.iconPictureBox_password.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_password.Location = new System.Drawing.Point(317, 215);
            this.iconPictureBox_password.Name = "iconPictureBox_password";
            this.iconPictureBox_password.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox_password.TabIndex = 29;
            this.iconPictureBox_password.TabStop = false;
            // 
            // textBox_oldPass
            // 
            this.textBox_oldPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_oldPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox_oldPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_oldPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_oldPass.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox_oldPass.Location = new System.Drawing.Point(349, 225);
            this.textBox_oldPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_oldPass.Name = "textBox_oldPass";
            this.textBox_oldPass.Size = new System.Drawing.Size(249, 20);
            this.textBox_oldPass.TabIndex = 28;
            this.textBox_oldPass.TextChanged += new System.EventHandler(this.textBox_oldPass_TextChanged);
            // 
            // iconPictureBox_Persona
            // 
            this.iconPictureBox_Persona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox_Persona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox_Persona.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox_Persona.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_Persona.Location = new System.Drawing.Point(317, 176);
            this.iconPictureBox_Persona.Name = "iconPictureBox_Persona";
            this.iconPictureBox_Persona.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox_Persona.TabIndex = 27;
            this.iconPictureBox_Persona.TabStop = false;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.Brown;
            this.labelStatus.Location = new System.Drawing.Point(361, 322);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(198, 19);
            this.labelStatus.TabIndex = 26;
            this.labelStatus.Text = "[!] Пароль указан неверно";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.Visible = false;
            // 
            // checkBoxPasswords
            // 
            this.checkBoxPasswords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxPasswords.AutoSize = true;
            this.checkBoxPasswords.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxPasswords.Location = new System.Drawing.Point(317, 296);
            this.checkBoxPasswords.Name = "checkBoxPasswords";
            this.checkBoxPasswords.Size = new System.Drawing.Size(184, 23);
            this.checkBoxPasswords.TabIndex = 22;
            this.checkBoxPasswords.Text = "Отображение пароля";
            this.checkBoxPasswords.UseVisualStyleBackColor = true;
            this.checkBoxPasswords.CheckedChanged += new System.EventHandler(this.checkBoxPasswords_CheckedChanged);
            // 
            // comboBoxOfUsers
            // 
            this.comboBoxOfUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxOfUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.comboBoxOfUsers.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBoxOfUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOfUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOfUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxOfUsers.FormattingEnabled = true;
            this.comboBoxOfUsers.Location = new System.Drawing.Point(347, 179);
            this.comboBoxOfUsers.Name = "comboBoxOfUsers";
            this.comboBoxOfUsers.Size = new System.Drawing.Size(257, 29);
            this.comboBoxOfUsers.TabIndex = 25;
            this.comboBoxOfUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfUsers_SelectedIndexChanged);
            // 
            // panelUnderlinePassword
            // 
            this.panelUnderlinePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUnderlinePassword.BackColor = System.Drawing.Color.Gainsboro;
            this.panelUnderlinePassword.Location = new System.Drawing.Point(317, 249);
            this.panelUnderlinePassword.Name = "panelUnderlinePassword";
            this.panelUnderlinePassword.Size = new System.Drawing.Size(303, 1);
            this.panelUnderlinePassword.TabIndex = 24;
            // 
            // panelUnderlineUsername
            // 
            this.panelUnderlineUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUnderlineUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.panelUnderlineUsername.Location = new System.Drawing.Point(317, 210);
            this.panelUnderlineUsername.Name = "panelUnderlineUsername";
            this.panelUnderlineUsername.Size = new System.Drawing.Size(303, 1);
            this.panelUnderlineUsername.TabIndex = 23;
            // 
            // buttonRedactPass
            // 
            this.buttonRedactPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRedactPass.BackColor = System.Drawing.Color.White;
            this.buttonRedactPass.FlatAppearance.BorderSize = 0;
            this.buttonRedactPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRedactPass.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRedactPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.buttonRedactPass.Location = new System.Drawing.Point(343, 349);
            this.buttonRedactPass.Name = "buttonRedactPass";
            this.buttonRedactPass.Size = new System.Drawing.Size(235, 60);
            this.buttonRedactPass.TabIndex = 21;
            this.buttonRedactPass.Text = "Сменить пароль";
            this.buttonRedactPass.UseVisualStyleBackColor = false;
            this.buttonRedactPass.Click += new System.EventHandler(this.buttonRedactPass_Click);
            // 
            // iconPictureBox_newPassword
            // 
            this.iconPictureBox_newPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox_newPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox_newPassword.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt;
            this.iconPictureBox_newPassword.IconColor = System.Drawing.Color.White;
            this.iconPictureBox_newPassword.Location = new System.Drawing.Point(317, 255);
            this.iconPictureBox_newPassword.Name = "iconPictureBox_newPassword";
            this.iconPictureBox_newPassword.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox_newPassword.TabIndex = 34;
            this.iconPictureBox_newPassword.TabStop = false;
            // 
            // textBox_newPass
            // 
            this.textBox_newPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_newPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox_newPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_newPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_newPass.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox_newPass.Location = new System.Drawing.Point(349, 265);
            this.textBox_newPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_newPass.Name = "textBox_newPass";
            this.textBox_newPass.Size = new System.Drawing.Size(249, 20);
            this.textBox_newPass.TabIndex = 33;
            this.textBox_newPass.TextChanged += new System.EventHandler(this.textBox_newPass_TextChanged);
            // 
            // panelUnderLineNewPassword
            // 
            this.panelUnderLineNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUnderLineNewPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.panelUnderLineNewPassword.Location = new System.Drawing.Point(317, 289);
            this.panelUnderLineNewPassword.Name = "panelUnderLineNewPassword";
            this.panelUnderLineNewPassword.Size = new System.Drawing.Size(303, 1);
            this.panelUnderLineNewPassword.TabIndex = 32;
            // 
            // Others_UserPasswrods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(936, 448);
            this.Controls.Add(this.iconPictureBox_newPassword);
            this.Controls.Add(this.textBox_newPass);
            this.Controls.Add(this.panelUnderLineNewPassword);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconPictureBox_password);
            this.Controls.Add(this.textBox_oldPass);
            this.Controls.Add(this.iconPictureBox_Persona);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.checkBoxPasswords);
            this.Controls.Add(this.comboBoxOfUsers);
            this.Controls.Add(this.panelUnderlinePassword);
            this.Controls.Add(this.panelUnderlineUsername);
            this.Controls.Add(this.buttonRedactPass);
            this.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Others_UserPasswrods";
            this.Text = "Прочее - Пароли профилей";
            this.Load += new System.EventHandler(this.Others_UserPasswrods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Persona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_newPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_password;
        private System.Windows.Forms.TextBox textBox_oldPass;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_Persona;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckBox checkBoxPasswords;
        private System.Windows.Forms.ComboBox comboBoxOfUsers;
        private System.Windows.Forms.Panel panelUnderlinePassword;
        private System.Windows.Forms.Panel panelUnderlineUsername;
        private System.Windows.Forms.Button buttonRedactPass;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_newPassword;
        private System.Windows.Forms.TextBox textBox_newPass;
        private System.Windows.Forms.Panel panelUnderLineNewPassword;
        private System.Windows.Forms.ToolTip toolTipOnPass1;
        private System.Windows.Forms.ToolTip toolTipOnPass2;
    }
}