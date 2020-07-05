namespace Edbook.WinForms.Forms.Reports
{
    partial class Reports_Form
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
            this.dataGridView_ofLogs = new System.Windows.Forms.DataGridView();
            this.iconButton_Delete = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ofLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ofLogs
            // 
            this.dataGridView_ofLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ofLogs.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_ofLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ofLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ofLogs.Location = new System.Drawing.Point(12, 13);
            this.dataGridView_ofLogs.Name = "dataGridView_ofLogs";
            this.dataGridView_ofLogs.Size = new System.Drawing.Size(912, 354);
            this.dataGridView_ofLogs.TabIndex = 21;
            // 
            // iconButton_Delete
            // 
            this.iconButton_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.iconButton_Delete.FlatAppearance.BorderSize = 0;
            this.iconButton_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Delete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_Delete.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.iconButton_Delete.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton_Delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton_Delete.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton_Delete.IconSize = 32;
            this.iconButton_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_Delete.Location = new System.Drawing.Point(12, 375);
            this.iconButton_Delete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.iconButton_Delete.Name = "iconButton_Delete";
            this.iconButton_Delete.Padding = new System.Windows.Forms.Padding(40, 0, 25, 0);
            this.iconButton_Delete.Rotation = 0D;
            this.iconButton_Delete.Size = new System.Drawing.Size(912, 60);
            this.iconButton_Delete.TabIndex = 23;
            this.iconButton_Delete.Text = "Удалить запись";
            this.iconButton_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton_Delete.UseVisualStyleBackColor = false;
            this.iconButton_Delete.Click += new System.EventHandler(this.iconButton_Delete_Click);
            // 
            // Reports_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(936, 448);
            this.Controls.Add(this.iconButton_Delete);
            this.Controls.Add(this.dataGridView_ofLogs);
            this.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reports_Form";
            this.Text = "Отчётность";
            this.Load += new System.EventHandler(this.Reports_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ofLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_ofLogs;
        private FontAwesome.Sharp.IconButton iconButton_Delete;
    }
}