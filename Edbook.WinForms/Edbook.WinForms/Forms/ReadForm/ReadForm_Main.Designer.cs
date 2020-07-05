namespace Edbook.WinForms.Forms.ReadForm
{
    partial class ReadForm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadForm_Main));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButton_Left = new FontAwesome.Sharp.IconButton();
            this.iconButton_Right = new FontAwesome.Sharp.IconButton();
            this.label_infoOfThisBookPart = new System.Windows.Forms.Label();
            this.iconPictureBox_Book = new FontAwesome.Sharp.IconPictureBox();
            this.label_nameOfEdbook = new System.Windows.Forms.Label();
            this.panelShadowEffect = new System.Windows.Forms.Panel();
            this.textBox_ThemeContent = new System.Windows.Forms.TextBox();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Book)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.iconButton_Left);
            this.panelTitleBar.Controls.Add(this.iconButton_Right);
            this.panelTitleBar.Controls.Add(this.label_infoOfThisBookPart);
            this.panelTitleBar.Controls.Add(this.iconPictureBox_Book);
            this.panelTitleBar.Controls.Add(this.label_nameOfEdbook);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(624, 70);
            this.panelTitleBar.TabIndex = 2;
            // 
            // iconButton_Left
            // 
            this.iconButton_Left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_Left.FlatAppearance.BorderSize = 0;
            this.iconButton_Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Left.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_Left.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton_Left.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.iconButton_Left.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton_Left.IconSize = 48;
            this.iconButton_Left.Location = new System.Drawing.Point(511, 19);
            this.iconButton_Left.Name = "iconButton_Left";
            this.iconButton_Left.Rotation = 0D;
            this.iconButton_Left.Size = new System.Drawing.Size(48, 40);
            this.iconButton_Left.TabIndex = 4;
            this.iconButton_Left.UseVisualStyleBackColor = true;
            this.iconButton_Left.Click += new System.EventHandler(this.iconButton_Left_Click);
            // 
            // iconButton_Right
            // 
            this.iconButton_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_Right.FlatAppearance.BorderSize = 0;
            this.iconButton_Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Right.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_Right.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton_Right.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.iconButton_Right.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton_Right.IconSize = 48;
            this.iconButton_Right.Location = new System.Drawing.Point(565, 19);
            this.iconButton_Right.Name = "iconButton_Right";
            this.iconButton_Right.Rotation = 0D;
            this.iconButton_Right.Size = new System.Drawing.Size(48, 40);
            this.iconButton_Right.TabIndex = 3;
            this.iconButton_Right.UseVisualStyleBackColor = true;
            this.iconButton_Right.Click += new System.EventHandler(this.iconButton_Right_Click);
            // 
            // label_infoOfThisBookPart
            // 
            this.label_infoOfThisBookPart.AutoSize = true;
            this.label_infoOfThisBookPart.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_infoOfThisBookPart.Location = new System.Drawing.Point(58, 37);
            this.label_infoOfThisBookPart.Name = "label_infoOfThisBookPart";
            this.label_infoOfThisBookPart.Size = new System.Drawing.Size(299, 19);
            this.label_infoOfThisBookPart.TabIndex = 2;
            this.label_infoOfThisBookPart.Text = "(nums) Name_ofChapter - Name_ofTheme";
            // 
            // iconPictureBox_Book
            // 
            this.iconPictureBox_Book.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconPictureBox_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBox_Book.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox_Book.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconPictureBox_Book.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox_Book.IconSize = 40;
            this.iconPictureBox_Book.Location = new System.Drawing.Point(12, 19);
            this.iconPictureBox_Book.Name = "iconPictureBox_Book";
            this.iconPictureBox_Book.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox_Book.TabIndex = 1;
            this.iconPictureBox_Book.TabStop = false;
            // 
            // label_nameOfEdbook
            // 
            this.label_nameOfEdbook.AutoSize = true;
            this.label_nameOfEdbook.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_nameOfEdbook.Location = new System.Drawing.Point(58, 16);
            this.label_nameOfEdbook.Name = "label_nameOfEdbook";
            this.label_nameOfEdbook.Size = new System.Drawing.Size(124, 19);
            this.label_nameOfEdbook.TabIndex = 0;
            this.label_nameOfEdbook.Text = "Name_ofEdbook";
            // 
            // panelShadowEffect
            // 
            this.panelShadowEffect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadowEffect.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadowEffect.Location = new System.Drawing.Point(0, 70);
            this.panelShadowEffect.Name = "panelShadowEffect";
            this.panelShadowEffect.Size = new System.Drawing.Size(624, 4);
            this.panelShadowEffect.TabIndex = 3;
            // 
            // textBox_ThemeContent
            // 
            this.textBox_ThemeContent.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_ThemeContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ThemeContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ThemeContent.Location = new System.Drawing.Point(0, 74);
            this.textBox_ThemeContent.Multiline = true;
            this.textBox_ThemeContent.Name = "textBox_ThemeContent";
            this.textBox_ThemeContent.ReadOnly = true;
            this.textBox_ThemeContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ThemeContent.Size = new System.Drawing.Size(624, 487);
            this.textBox_ThemeContent.TabIndex = 5;
            // 
            // ReadForm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 561);
            this.Controls.Add(this.textBox_ThemeContent);
            this.Controls.Add(this.panelShadowEffect);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReadForm_Main";
            this.Text = "Учебное пособие";
            this.Load += new System.EventHandler(this.ReadForm_Main_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_Book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelShadowEffect;
        private System.Windows.Forms.Label label_infoOfThisBookPart;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_Book;
        private System.Windows.Forms.Label label_nameOfEdbook;
        private FontAwesome.Sharp.IconButton iconButton_Left;
        private FontAwesome.Sharp.IconButton iconButton_Right;
        private System.Windows.Forms.TextBox textBox_ThemeContent;
    }
}