namespace Edbook.WinForms.Forms.Books.Disciplines
{
    partial class Book_Disciplines
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
            this.dataGridView_ofDisciplines = new System.Windows.Forms.DataGridView();
            this.iconButton_Delete = new FontAwesome.Sharp.IconButton();
            this.iconButton_Add = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ofDisciplines)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ofDisciplines
            // 
            this.dataGridView_ofDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ofDisciplines.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_ofDisciplines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ofDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ofDisciplines.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_ofDisciplines.Name = "dataGridView_ofDisciplines";
            this.dataGridView_ofDisciplines.Size = new System.Drawing.Size(912, 354);
            this.dataGridView_ofDisciplines.TabIndex = 0;
            // 
            // iconButton_Delete
            // 
            this.iconButton_Delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.iconButton_Delete.Location = new System.Drawing.Point(624, 374);
            this.iconButton_Delete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.iconButton_Delete.Name = "iconButton_Delete";
            this.iconButton_Delete.Padding = new System.Windows.Forms.Padding(40, 0, 25, 0);
            this.iconButton_Delete.Rotation = 0D;
            this.iconButton_Delete.Size = new System.Drawing.Size(300, 60);
            this.iconButton_Delete.TabIndex = 14;
            this.iconButton_Delete.Text = "Удалить учебную дисциплину";
            this.iconButton_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton_Delete.UseVisualStyleBackColor = false;
            this.iconButton_Delete.Click += new System.EventHandler(this.iconButton_Delete_Click);
            // 
            // iconButton_Add
            // 
            this.iconButton_Add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconButton_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.iconButton_Add.FlatAppearance.BorderSize = 0;
            this.iconButton_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Add.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_Add.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.iconButton_Add.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton_Add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton_Add.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton_Add.IconSize = 32;
            this.iconButton_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_Add.Location = new System.Drawing.Point(12, 374);
            this.iconButton_Add.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.iconButton_Add.Name = "iconButton_Add";
            this.iconButton_Add.Padding = new System.Windows.Forms.Padding(40, 0, 25, 0);
            this.iconButton_Add.Rotation = 0D;
            this.iconButton_Add.Size = new System.Drawing.Size(300, 60);
            this.iconButton_Add.TabIndex = 13;
            this.iconButton_Add.Text = "Ввести учебную дисциплину";
            this.iconButton_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton_Add.UseVisualStyleBackColor = false;
            this.iconButton_Add.Click += new System.EventHandler(this.iconButton_Add_Click);
            // 
            // Book_Disciplines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(936, 448);
            this.Controls.Add(this.iconButton_Delete);
            this.Controls.Add(this.iconButton_Add);
            this.Controls.Add(this.dataGridView_ofDisciplines);
            this.Font = new System.Drawing.Font("Century Gothic", 10.75F);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Book_Disciplines";
            this.Text = "Справочники - Дисциплины";
            this.Load += new System.EventHandler(this.Book_Disciplines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ofDisciplines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ofDisciplines;
        private FontAwesome.Sharp.IconButton iconButton_Add;
        private FontAwesome.Sharp.IconButton iconButton_Delete;
    }
}