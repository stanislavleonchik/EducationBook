namespace Edbook.WinForms.Forms.Others
{
    partial class Others_Reference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Others_Reference));
            this.pictureBox_CentralImage = new System.Windows.Forms.PictureBox();
            this.textBox_About = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CentralImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_CentralImage
            // 
            this.pictureBox_CentralImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_CentralImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CentralImage.Image")));
            this.pictureBox_CentralImage.Location = new System.Drawing.Point(292, 57);
            this.pictureBox_CentralImage.Name = "pictureBox_CentralImage";
            this.pictureBox_CentralImage.Size = new System.Drawing.Size(353, 205);
            this.pictureBox_CentralImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CentralImage.TabIndex = 13;
            this.pictureBox_CentralImage.TabStop = false;
            // 
            // textBox_About
            // 
            this.textBox_About.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox_About.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_About.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox_About.Location = new System.Drawing.Point(184, 295);
            this.textBox_About.Multiline = true;
            this.textBox_About.Name = "textBox_About";
            this.textBox_About.ReadOnly = true;
            this.textBox_About.Size = new System.Drawing.Size(568, 89);
            this.textBox_About.TabIndex = 17;
            this.textBox_About.Text = resources.GetString("textBox_About.Text");
            this.textBox_About.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(341, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Организация: ГБПОУ «РО РКИУ»";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(340, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Автор: Теорентер Артём Игоревич";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(378, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Версия продукта: 1.0.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Others_Reference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(936, 448);
            this.Controls.Add(this.textBox_About);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_CentralImage);
            this.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Others_Reference";
            this.Text = "Прочее - Справка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CentralImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_CentralImage;
        private System.Windows.Forms.TextBox textBox_About;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}