namespace Edbook.WinForms.Forms.Books.EdBooks
{
    partial class Book_EdBooks_SubFormAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_EdBooks_SubFormAddUpdate));
            this.label_SecondName = new System.Windows.Forms.Label();
            this.textBox_secondname = new System.Windows.Forms.TextBox();
            this.button_AddRedact = new System.Windows.Forms.Button();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.label_ThirdName = new System.Windows.Forms.Label();
            this.textBox_thirdname = new System.Windows.Forms.TextBox();
            this.dataGridView_Free = new System.Windows.Forms.DataGridView();
            this.panel_aboutAuthor = new System.Windows.Forms.Panel();
            this.label_aboutAuthor = new System.Windows.Forms.Label();
            this.panel_downDGVs = new System.Windows.Forms.Panel();
            this.label_parForCurrentEdBook = new System.Windows.Forms.Label();
            this.label_FreePar = new System.Windows.Forms.Label();
            this.iconButton_ArrowRight = new FontAwesome.Sharp.IconButton();
            this.iconButton_ArrowLeft = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_EdBookInfo = new System.Windows.Forms.Panel();
            this.label_IDedbook = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_Discip = new System.Windows.Forms.Label();
            this.comboBox_Discip = new System.Windows.Forms.ComboBox();
            this.label_EdbookName = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_InfoAboutPos = new System.Windows.Forms.Label();
            this.dataGridView_Taken = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Free)).BeginInit();
            this.panel_aboutAuthor.SuspendLayout();
            this.panel_downDGVs.SuspendLayout();
            this.panel_EdBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Taken)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SecondName
            // 
            this.label_SecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SecondName.AutoSize = true;
            this.label_SecondName.Location = new System.Drawing.Point(14, 11);
            this.label_SecondName.Name = "label_SecondName";
            this.label_SecondName.Size = new System.Drawing.Size(82, 20);
            this.label_SecondName.TabIndex = 5;
            this.label_SecondName.Text = "Фамилия:";
            // 
            // textBox_secondname
            // 
            this.textBox_secondname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_secondname.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_secondname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_secondname.Location = new System.Drawing.Point(14, 34);
            this.textBox_secondname.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox_secondname.Name = "textBox_secondname";
            this.textBox_secondname.Size = new System.Drawing.Size(296, 19);
            this.textBox_secondname.TabIndex = 4;
            // 
            // button_AddRedact
            // 
            this.button_AddRedact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AddRedact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_AddRedact.FlatAppearance.BorderSize = 0;
            this.button_AddRedact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddRedact.Location = new System.Drawing.Point(12, 510);
            this.button_AddRedact.Name = "button_AddRedact";
            this.button_AddRedact.Size = new System.Drawing.Size(694, 36);
            this.button_AddRedact.TabIndex = 3;
            this.button_AddRedact.Text = "Создать учебное пособие";
            this.button_AddRedact.UseVisualStyleBackColor = false;
            this.button_AddRedact.Click += new System.EventHandler(this.button_AddRedact_Click);
            // 
            // label_FirstName
            // 
            this.label_FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(14, 56);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(44, 20);
            this.label_FirstName.TabIndex = 7;
            this.label_FirstName.Text = "Имя:";
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_firstname.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_firstname.Location = new System.Drawing.Point(14, 79);
            this.textBox_firstname.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(296, 19);
            this.textBox_firstname.TabIndex = 6;
            // 
            // label_ThirdName
            // 
            this.label_ThirdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ThirdName.AutoSize = true;
            this.label_ThirdName.Location = new System.Drawing.Point(14, 101);
            this.label_ThirdName.Name = "label_ThirdName";
            this.label_ThirdName.Size = new System.Drawing.Size(82, 20);
            this.label_ThirdName.TabIndex = 9;
            this.label_ThirdName.Text = "Отчество:";
            // 
            // textBox_thirdname
            // 
            this.textBox_thirdname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_thirdname.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_thirdname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_thirdname.Location = new System.Drawing.Point(14, 124);
            this.textBox_thirdname.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox_thirdname.Name = "textBox_thirdname";
            this.textBox_thirdname.Size = new System.Drawing.Size(296, 19);
            this.textBox_thirdname.TabIndex = 8;
            // 
            // dataGridView_Free
            // 
            this.dataGridView_Free.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridView_Free.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Free.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Free.Location = new System.Drawing.Point(10, 36);
            this.dataGridView_Free.Name = "dataGridView_Free";
            this.dataGridView_Free.Size = new System.Drawing.Size(310, 262);
            this.dataGridView_Free.TabIndex = 10;
            // 
            // panel_aboutAuthor
            // 
            this.panel_aboutAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_aboutAuthor.Controls.Add(this.textBox_thirdname);
            this.panel_aboutAuthor.Controls.Add(this.textBox_secondname);
            this.panel_aboutAuthor.Controls.Add(this.label_SecondName);
            this.panel_aboutAuthor.Controls.Add(this.textBox_firstname);
            this.panel_aboutAuthor.Controls.Add(this.label_FirstName);
            this.panel_aboutAuthor.Controls.Add(this.label_ThirdName);
            this.panel_aboutAuthor.Location = new System.Drawing.Point(382, 16);
            this.panel_aboutAuthor.Name = "panel_aboutAuthor";
            this.panel_aboutAuthor.Size = new System.Drawing.Size(324, 162);
            this.panel_aboutAuthor.TabIndex = 14;
            // 
            // label_aboutAuthor
            // 
            this.label_aboutAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_aboutAuthor.AutoSize = true;
            this.label_aboutAuthor.ForeColor = System.Drawing.Color.Brown;
            this.label_aboutAuthor.Location = new System.Drawing.Point(385, 6);
            this.label_aboutAuthor.Name = "label_aboutAuthor";
            this.label_aboutAuthor.Size = new System.Drawing.Size(264, 20);
            this.label_aboutAuthor.TabIndex = 15;
            this.label_aboutAuthor.Text = "Информация об авторе пособия";
            // 
            // panel_downDGVs
            // 
            this.panel_downDGVs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_downDGVs.Controls.Add(this.dataGridView_Taken);
            this.panel_downDGVs.Controls.Add(this.label_parForCurrentEdBook);
            this.panel_downDGVs.Controls.Add(this.label_FreePar);
            this.panel_downDGVs.Controls.Add(this.iconButton_ArrowRight);
            this.panel_downDGVs.Controls.Add(this.iconButton_ArrowLeft);
            this.panel_downDGVs.Controls.Add(this.dataGridView_Free);
            this.panel_downDGVs.Location = new System.Drawing.Point(12, 192);
            this.panel_downDGVs.Name = "panel_downDGVs";
            this.panel_downDGVs.Size = new System.Drawing.Size(694, 312);
            this.panel_downDGVs.TabIndex = 16;
            // 
            // label_parForCurrentEdBook
            // 
            this.label_parForCurrentEdBook.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_parForCurrentEdBook.AutoSize = true;
            this.label_parForCurrentEdBook.Location = new System.Drawing.Point(372, 13);
            this.label_parForCurrentEdBook.Name = "label_parForCurrentEdBook";
            this.label_parForCurrentEdBook.Size = new System.Drawing.Size(210, 20);
            this.label_parForCurrentEdBook.TabIndex = 19;
            this.label_parForCurrentEdBook.Text = "Разделы данного пособия:";
            // 
            // label_FreePar
            // 
            this.label_FreePar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_FreePar.AutoSize = true;
            this.label_FreePar.Location = new System.Drawing.Point(6, 13);
            this.label_FreePar.Name = "label_FreePar";
            this.label_FreePar.Size = new System.Drawing.Size(167, 20);
            this.label_FreePar.TabIndex = 18;
            this.label_FreePar.Text = "Свободные разделы:";
            // 
            // iconButton_ArrowRight
            // 
            this.iconButton_ArrowRight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButton_ArrowRight.BackColor = System.Drawing.Color.Gainsboro;
            this.iconButton_ArrowRight.FlatAppearance.BorderSize = 0;
            this.iconButton_ArrowRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_ArrowRight.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_ArrowRight.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltRight;
            this.iconButton_ArrowRight.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButton_ArrowRight.IconSize = 32;
            this.iconButton_ArrowRight.Location = new System.Drawing.Point(328, 121);
            this.iconButton_ArrowRight.Name = "iconButton_ArrowRight";
            this.iconButton_ArrowRight.Rotation = 0D;
            this.iconButton_ArrowRight.Size = new System.Drawing.Size(40, 40);
            this.iconButton_ArrowRight.TabIndex = 16;
            this.iconButton_ArrowRight.UseVisualStyleBackColor = false;
            this.iconButton_ArrowRight.Click += new System.EventHandler(this.iconButton_ArrowRight_Click);
            // 
            // iconButton_ArrowLeft
            // 
            this.iconButton_ArrowLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButton_ArrowLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.iconButton_ArrowLeft.FlatAppearance.BorderSize = 0;
            this.iconButton_ArrowLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_ArrowLeft.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_ArrowLeft.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltLeft;
            this.iconButton_ArrowLeft.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButton_ArrowLeft.IconSize = 32;
            this.iconButton_ArrowLeft.Location = new System.Drawing.Point(328, 167);
            this.iconButton_ArrowLeft.Name = "iconButton_ArrowLeft";
            this.iconButton_ArrowLeft.Rotation = 0D;
            this.iconButton_ArrowLeft.Size = new System.Drawing.Size(40, 40);
            this.iconButton_ArrowLeft.TabIndex = 15;
            this.iconButton_ArrowLeft.UseVisualStyleBackColor = false;
            this.iconButton_ArrowLeft.Click += new System.EventHandler(this.iconButton_ArrowLeft_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(15, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Разделы пособия";
            // 
            // panel_EdBookInfo
            // 
            this.panel_EdBookInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_EdBookInfo.Controls.Add(this.label_IDedbook);
            this.panel_EdBookInfo.Controls.Add(this.textBox_ID);
            this.panel_EdBookInfo.Controls.Add(this.label_Discip);
            this.panel_EdBookInfo.Controls.Add(this.comboBox_Discip);
            this.panel_EdBookInfo.Controls.Add(this.label_EdbookName);
            this.panel_EdBookInfo.Controls.Add(this.textBox_Name);
            this.panel_EdBookInfo.Location = new System.Drawing.Point(12, 16);
            this.panel_EdBookInfo.Name = "panel_EdBookInfo";
            this.panel_EdBookInfo.Size = new System.Drawing.Size(364, 162);
            this.panel_EdBookInfo.TabIndex = 18;
            // 
            // label_IDedbook
            // 
            this.label_IDedbook.AutoSize = true;
            this.label_IDedbook.Location = new System.Drawing.Point(6, 11);
            this.label_IDedbook.Name = "label_IDedbook";
            this.label_IDedbook.Size = new System.Drawing.Size(98, 20);
            this.label_IDedbook.TabIndex = 17;
            this.label_IDedbook.Text = "ID пособия:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ID.Location = new System.Drawing.Point(10, 34);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(333, 19);
            this.textBox_ID.TabIndex = 16;
            // 
            // label_Discip
            // 
            this.label_Discip.AutoSize = true;
            this.label_Discip.Location = new System.Drawing.Point(6, 102);
            this.label_Discip.Name = "label_Discip";
            this.label_Discip.Size = new System.Drawing.Size(172, 20);
            this.label_Discip.TabIndex = 15;
            this.label_Discip.Text = "Учебная дисциплина:";
            // 
            // comboBox_Discip
            // 
            this.comboBox_Discip.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox_Discip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Discip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Discip.FormattingEnabled = true;
            this.comboBox_Discip.Location = new System.Drawing.Point(10, 124);
            this.comboBox_Discip.Name = "comboBox_Discip";
            this.comboBox_Discip.Size = new System.Drawing.Size(333, 28);
            this.comboBox_Discip.TabIndex = 14;
            // 
            // label_EdbookName
            // 
            this.label_EdbookName.AutoSize = true;
            this.label_EdbookName.Location = new System.Drawing.Point(6, 56);
            this.label_EdbookName.Name = "label_EdbookName";
            this.label_EdbookName.Size = new System.Drawing.Size(153, 20);
            this.label_EdbookName.TabIndex = 13;
            this.label_EdbookName.Text = "Название пособия:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Name.Location = new System.Drawing.Point(10, 79);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(333, 19);
            this.textBox_Name.TabIndex = 12;
            // 
            // label_InfoAboutPos
            // 
            this.label_InfoAboutPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_InfoAboutPos.AutoSize = true;
            this.label_InfoAboutPos.ForeColor = System.Drawing.Color.Brown;
            this.label_InfoAboutPos.Location = new System.Drawing.Point(18, 7);
            this.label_InfoAboutPos.Name = "label_InfoAboutPos";
            this.label_InfoAboutPos.Size = new System.Drawing.Size(199, 20);
            this.label_InfoAboutPos.TabIndex = 19;
            this.label_InfoAboutPos.Text = "Информация о пособии";
            // 
            // dataGridView_Taken
            // 
            this.dataGridView_Taken.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridView_Taken.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Taken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Taken.Location = new System.Drawing.Point(374, 36);
            this.dataGridView_Taken.Name = "dataGridView_Taken";
            this.dataGridView_Taken.Size = new System.Drawing.Size(310, 262);
            this.dataGridView_Taken.TabIndex = 20;
            // 
            // Book_EdBooks_SubFormAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 558);
            this.Controls.Add(this.label_InfoAboutPos);
            this.Controls.Add(this.panel_EdBookInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel_downDGVs);
            this.Controls.Add(this.label_aboutAuthor);
            this.Controls.Add(this.panel_aboutAuthor);
            this.Controls.Add(this.button_AddRedact);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(733, 597);
            this.MinimumSize = new System.Drawing.Size(733, 597);
            this.Name = "Book_EdBooks_SubFormAddUpdate";
            this.Text = "Создание нового учебного пособия";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Book_EdBooks_SubFormAddUpdate_FormClosed);
            this.Load += new System.EventHandler(this.Book_EdBooks_SubFormAddUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Free)).EndInit();
            this.panel_aboutAuthor.ResumeLayout(false);
            this.panel_aboutAuthor.PerformLayout();
            this.panel_downDGVs.ResumeLayout(false);
            this.panel_downDGVs.PerformLayout();
            this.panel_EdBookInfo.ResumeLayout(false);
            this.panel_EdBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Taken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SecondName;
        private System.Windows.Forms.TextBox textBox_secondname;
        private System.Windows.Forms.Button button_AddRedact;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.Label label_ThirdName;
        private System.Windows.Forms.TextBox textBox_thirdname;
        private System.Windows.Forms.DataGridView dataGridView_Free;
        private System.Windows.Forms.Panel panel_aboutAuthor;
        private System.Windows.Forms.Label label_aboutAuthor;
        private System.Windows.Forms.Panel panel_downDGVs;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButton_ArrowLeft;
        private FontAwesome.Sharp.IconButton iconButton_ArrowRight;
        private System.Windows.Forms.Label label_parForCurrentEdBook;
        private System.Windows.Forms.Label label_FreePar;
        private System.Windows.Forms.Panel panel_EdBookInfo;
        private System.Windows.Forms.Label label_InfoAboutPos;
        private System.Windows.Forms.Label label_EdbookName;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Discip;
        private System.Windows.Forms.ComboBox comboBox_Discip;
        private System.Windows.Forms.Label label_IDedbook;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.DataGridView dataGridView_Taken;
    }
}