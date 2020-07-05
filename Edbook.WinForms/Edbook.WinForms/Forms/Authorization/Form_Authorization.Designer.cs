namespace Edbook.WinForms.Forms.Authorization
{
    partial class Form_Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Authorization));
            this.labelStatus = new System.Windows.Forms.Label();
            this.checkBoxPasswords = new System.Windows.Forms.CheckBox();
            this.comboBoxOfUsers = new System.Windows.Forms.ComboBox();
            this.panelUnderlinePassword = new System.Windows.Forms.Panel();
            this.panelUnderlineUsername = new System.Windows.Forms.Panel();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.iconPictureBox_Persona = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxOfPassword = new System.Windows.Forms.TextBox();
            this.iconPictureBox_password = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Persona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.Brown;
            this.labelStatus.Location = new System.Drawing.Point(77, 294);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(198, 19);
            this.labelStatus.TabIndex = 14;
            this.labelStatus.Text = "[!] Пароль указан неверно";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.Visible = false;
            // 
            // checkBoxPasswords
            // 
            this.checkBoxPasswords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxPasswords.AutoSize = true;
            this.checkBoxPasswords.Location = new System.Drawing.Point(33, 268);
            this.checkBoxPasswords.Name = "checkBoxPasswords";
            this.checkBoxPasswords.Size = new System.Drawing.Size(184, 23);
            this.checkBoxPasswords.TabIndex = 10;
            this.checkBoxPasswords.Text = "Отображение пароля";
            this.checkBoxPasswords.UseVisualStyleBackColor = true;
            this.checkBoxPasswords.CheckedChanged += new System.EventHandler(this.checkBoxPasswords_CheckedChanged);
            // 
            // comboBoxOfUsers
            // 
            this.comboBoxOfUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxOfUsers.BackColor = System.Drawing.Color.White;
            this.comboBoxOfUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxOfUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOfUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOfUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOfUsers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxOfUsers.FormattingEnabled = true;
            this.comboBoxOfUsers.Location = new System.Drawing.Point(63, 186);
            this.comboBoxOfUsers.Name = "comboBoxOfUsers";
            this.comboBoxOfUsers.Size = new System.Drawing.Size(257, 29);
            this.comboBoxOfUsers.TabIndex = 13;
            this.comboBoxOfUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfUsers_SelectedIndexChanged);
            this.comboBoxOfUsers.Click += new System.EventHandler(this.comboBoxOfUsers_Click);
            // 
            // panelUnderlinePassword
            // 
            this.panelUnderlinePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUnderlinePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panelUnderlinePassword.Location = new System.Drawing.Point(33, 260);
            this.panelUnderlinePassword.Name = "panelUnderlinePassword";
            this.panelUnderlinePassword.Size = new System.Drawing.Size(303, 1);
            this.panelUnderlinePassword.TabIndex = 12;
            // 
            // panelUnderlineUsername
            // 
            this.panelUnderlineUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUnderlineUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panelUnderlineUsername.Location = new System.Drawing.Point(33, 217);
            this.panelUnderlineUsername.Name = "panelUnderlineUsername";
            this.panelUnderlineUsername.Size = new System.Drawing.Size(303, 1);
            this.panelUnderlineUsername.TabIndex = 11;
            // 
            // buttonAuth
            // 
            this.buttonAuth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.buttonAuth.FlatAppearance.BorderSize = 0;
            this.buttonAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuth.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuth.ForeColor = System.Drawing.Color.White;
            this.buttonAuth.Location = new System.Drawing.Point(59, 321);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(235, 60);
            this.buttonAuth.TabIndex = 9;
            this.buttonAuth.Text = "Войти";
            this.buttonAuth.UseVisualStyleBackColor = false;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // iconPictureBox_Persona
            // 
            this.iconPictureBox_Persona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox_Persona.BackColor = System.Drawing.Color.White;
            this.iconPictureBox_Persona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox_Persona.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox_Persona.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox_Persona.Location = new System.Drawing.Point(33, 183);
            this.iconPictureBox_Persona.Name = "iconPictureBox_Persona";
            this.iconPictureBox_Persona.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox_Persona.TabIndex = 16;
            this.iconPictureBox_Persona.TabStop = false;
            // 
            // textBoxOfPassword
            // 
            this.textBoxOfPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOfPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOfPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOfPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxOfPassword.Location = new System.Drawing.Point(65, 236);
            this.textBoxOfPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOfPassword.Name = "textBoxOfPassword";
            this.textBoxOfPassword.Size = new System.Drawing.Size(249, 20);
            this.textBoxOfPassword.TabIndex = 17;
            this.textBoxOfPassword.Click += new System.EventHandler(this.textBoxOfPassword_Click);
            this.textBoxOfPassword.TextChanged += new System.EventHandler(this.textBoxOfPassword_TextChanged);
            // 
            // iconPictureBox_password
            // 
            this.iconPictureBox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox_password.BackColor = System.Drawing.Color.White;
            this.iconPictureBox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox_password.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.iconPictureBox_password.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox_password.Location = new System.Drawing.Point(33, 226);
            this.iconPictureBox_password.Name = "iconPictureBox_password";
            this.iconPictureBox_password.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox_password.TabIndex = 18;
            this.iconPictureBox_password.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.IconSize = 160;
            this.iconPictureBox1.Location = new System.Drawing.Point(103, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(160, 160);
            this.iconPictureBox1.TabIndex = 19;
            this.iconPictureBox1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.DimGray;
            this.labelName.Location = new System.Drawing.Point(71, 138);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(223, 23);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "EdBook - Авторизация";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 393);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconPictureBox_password);
            this.Controls.Add(this.textBoxOfPassword);
            this.Controls.Add(this.iconPictureBox_Persona);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.checkBoxPasswords);
            this.Controls.Add(this.comboBoxOfUsers);
            this.Controls.Add(this.panelUnderlinePassword);
            this.Controls.Add(this.panelUnderlineUsername);
            this.Controls.Add(this.buttonAuth);
            this.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(384, 432);
            this.Name = "Form_Authorization";
            this.Text = "EdBook - Авторизация";
            this.Load += new System.EventHandler(this.Form_Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Persona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckBox checkBoxPasswords;
        private System.Windows.Forms.ComboBox comboBoxOfUsers;
        private System.Windows.Forms.Panel panelUnderlinePassword;
        private System.Windows.Forms.Panel panelUnderlineUsername;
        private System.Windows.Forms.Button buttonAuth;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_Persona;
        private System.Windows.Forms.TextBox textBoxOfPassword;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_password;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelName;
    }
}