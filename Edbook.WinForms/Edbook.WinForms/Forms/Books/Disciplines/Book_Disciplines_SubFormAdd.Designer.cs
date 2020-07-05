namespace Edbook.WinForms.Forms.Books.Disciplines
{
    partial class Book_Disciplines_SubFormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Disciplines_SubFormAdd));
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_nameOfDiscipline = new System.Windows.Forms.TextBox();
            this.label_nameOfDiscipline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Location = new System.Drawing.Point(12, 56);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(360, 36);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Ввести дисциплину";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_nameOfDiscipline
            // 
            this.textBox_nameOfDiscipline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_nameOfDiscipline.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_nameOfDiscipline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_nameOfDiscipline.Location = new System.Drawing.Point(12, 26);
            this.textBox_nameOfDiscipline.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox_nameOfDiscipline.Name = "textBox_nameOfDiscipline";
            this.textBox_nameOfDiscipline.Size = new System.Drawing.Size(360, 19);
            this.textBox_nameOfDiscipline.TabIndex = 1;
            // 
            // label_nameOfDiscipline
            // 
            this.label_nameOfDiscipline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_nameOfDiscipline.AutoSize = true;
            this.label_nameOfDiscipline.Location = new System.Drawing.Point(12, 3);
            this.label_nameOfDiscipline.Name = "label_nameOfDiscipline";
            this.label_nameOfDiscipline.Size = new System.Drawing.Size(180, 20);
            this.label_nameOfDiscipline.TabIndex = 2;
            this.label_nameOfDiscipline.Text = "Название дисциплины:";
            // 
            // Book_Disciplines_SubFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 101);
            this.Controls.Add(this.label_nameOfDiscipline);
            this.Controls.Add(this.textBox_nameOfDiscipline);
            this.Controls.Add(this.button_Add);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(400, 140);
            this.MinimumSize = new System.Drawing.Size(400, 140);
            this.Name = "Book_Disciplines_SubFormAdd";
            this.Text = "Введение новой дисциплины";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Book_Disciplines_SubFormAdd_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_nameOfDiscipline;
        private System.Windows.Forms.Label label_nameOfDiscipline;
    }
}