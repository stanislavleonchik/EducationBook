namespace Edbook.WinForms.Forms.Books.Chapters
{
    partial class Book_Chapters_SubFormAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Chapters_SubFormAddUpdate));
            this.label_InfoAboutPos = new System.Windows.Forms.Label();
            this.panel_EdBookInfo = new System.Windows.Forms.Panel();
            this.textBox_Numbers = new System.Windows.Forms.TextBox();
            this.label_IDchapter = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_NumberofChapter = new System.Windows.Forms.Label();
            this.label_ChapterName = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_downDGVs = new System.Windows.Forms.Panel();
            this.label_parForCurrentEdBook = new System.Windows.Forms.Label();
            this.label_FreePar = new System.Windows.Forms.Label();
            this.iconButton_ArrowRight = new FontAwesome.Sharp.IconButton();
            this.iconButton_ArrowLeft = new FontAwesome.Sharp.IconButton();
            this.dataGridView_Taken = new System.Windows.Forms.DataGridView();
            this.dataGridView_Free = new System.Windows.Forms.DataGridView();
            this.button_AddRedact = new System.Windows.Forms.Button();
            this.panel_EdBookInfo.SuspendLayout();
            this.panel_downDGVs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Taken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Free)).BeginInit();
            this.SuspendLayout();
            // 
            // label_InfoAboutPos
            // 
            this.label_InfoAboutPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_InfoAboutPos.AutoSize = true;
            this.label_InfoAboutPos.ForeColor = System.Drawing.Color.Brown;
            this.label_InfoAboutPos.Location = new System.Drawing.Point(18, 7);
            this.label_InfoAboutPos.Name = "label_InfoAboutPos";
            this.label_InfoAboutPos.Size = new System.Drawing.Size(195, 20);
            this.label_InfoAboutPos.TabIndex = 24;
            this.label_InfoAboutPos.Text = "Информация о разделе";
            // 
            // panel_EdBookInfo
            // 
            this.panel_EdBookInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_EdBookInfo.Controls.Add(this.textBox_Numbers);
            this.panel_EdBookInfo.Controls.Add(this.label_IDchapter);
            this.panel_EdBookInfo.Controls.Add(this.textBox_ID);
            this.panel_EdBookInfo.Controls.Add(this.label_NumberofChapter);
            this.panel_EdBookInfo.Controls.Add(this.label_ChapterName);
            this.panel_EdBookInfo.Controls.Add(this.textBox_Name);
            this.panel_EdBookInfo.Location = new System.Drawing.Point(12, 16);
            this.panel_EdBookInfo.Name = "panel_EdBookInfo";
            this.panel_EdBookInfo.Size = new System.Drawing.Size(694, 162);
            this.panel_EdBookInfo.TabIndex = 23;
            // 
            // textBox_Numbers
            // 
            this.textBox_Numbers.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_Numbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Numbers.Location = new System.Drawing.Point(10, 125);
            this.textBox_Numbers.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox_Numbers.Name = "textBox_Numbers";
            this.textBox_Numbers.Size = new System.Drawing.Size(676, 19);
            this.textBox_Numbers.TabIndex = 18;
            // 
            // label_IDchapter
            // 
            this.label_IDchapter.AutoSize = true;
            this.label_IDchapter.Location = new System.Drawing.Point(6, 11);
            this.label_IDchapter.Name = "label_IDchapter";
            this.label_IDchapter.Size = new System.Drawing.Size(96, 20);
            this.label_IDchapter.TabIndex = 17;
            this.label_IDchapter.Text = "ID раздела:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ID.Location = new System.Drawing.Point(10, 34);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(676, 19);
            this.textBox_ID.TabIndex = 16;
            // 
            // label_NumberofChapter
            // 
            this.label_NumberofChapter.AutoSize = true;
            this.label_NumberofChapter.Location = new System.Drawing.Point(6, 102);
            this.label_NumberofChapter.Name = "label_NumberofChapter";
            this.label_NumberofChapter.Size = new System.Drawing.Size(133, 20);
            this.label_NumberofChapter.TabIndex = 15;
            this.label_NumberofChapter.Text = "Номер раздела:";
            // 
            // label_ChapterName
            // 
            this.label_ChapterName.AutoSize = true;
            this.label_ChapterName.Location = new System.Drawing.Point(6, 56);
            this.label_ChapterName.Name = "label_ChapterName";
            this.label_ChapterName.Size = new System.Drawing.Size(151, 20);
            this.label_ChapterName.TabIndex = 13;
            this.label_ChapterName.Text = "Название раздела:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Name.Location = new System.Drawing.Point(10, 79);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(676, 19);
            this.textBox_Name.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(15, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Темы раздела";
            // 
            // panel_downDGVs
            // 
            this.panel_downDGVs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_downDGVs.Controls.Add(this.label_parForCurrentEdBook);
            this.panel_downDGVs.Controls.Add(this.label_FreePar);
            this.panel_downDGVs.Controls.Add(this.iconButton_ArrowRight);
            this.panel_downDGVs.Controls.Add(this.iconButton_ArrowLeft);
            this.panel_downDGVs.Controls.Add(this.dataGridView_Taken);
            this.panel_downDGVs.Controls.Add(this.dataGridView_Free);
            this.panel_downDGVs.Location = new System.Drawing.Point(12, 192);
            this.panel_downDGVs.Name = "panel_downDGVs";
            this.panel_downDGVs.Size = new System.Drawing.Size(694, 312);
            this.panel_downDGVs.TabIndex = 21;
            // 
            // label_parForCurrentEdBook
            // 
            this.label_parForCurrentEdBook.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_parForCurrentEdBook.AutoSize = true;
            this.label_parForCurrentEdBook.Location = new System.Drawing.Point(372, 13);
            this.label_parForCurrentEdBook.Name = "label_parForCurrentEdBook";
            this.label_parForCurrentEdBook.Size = new System.Drawing.Size(184, 20);
            this.label_parForCurrentEdBook.TabIndex = 19;
            this.label_parForCurrentEdBook.Text = "Темы данного раздела:";
            // 
            // label_FreePar
            // 
            this.label_FreePar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_FreePar.AutoSize = true;
            this.label_FreePar.Location = new System.Drawing.Point(6, 13);
            this.label_FreePar.Name = "label_FreePar";
            this.label_FreePar.Size = new System.Drawing.Size(143, 20);
            this.label_FreePar.TabIndex = 18;
            this.label_FreePar.Text = "Свободные темы:";
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
            // dataGridView_Taken
            // 
            this.dataGridView_Taken.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridView_Taken.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Taken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Taken.Location = new System.Drawing.Point(376, 36);
            this.dataGridView_Taken.Name = "dataGridView_Taken";
            this.dataGridView_Taken.Size = new System.Drawing.Size(310, 262);
            this.dataGridView_Taken.TabIndex = 11;
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
            // button_AddRedact
            // 
            this.button_AddRedact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AddRedact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_AddRedact.FlatAppearance.BorderSize = 0;
            this.button_AddRedact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddRedact.Location = new System.Drawing.Point(12, 510);
            this.button_AddRedact.Name = "button_AddRedact";
            this.button_AddRedact.Size = new System.Drawing.Size(694, 36);
            this.button_AddRedact.TabIndex = 20;
            this.button_AddRedact.Text = "Создать новый учебный раздел";
            this.button_AddRedact.UseVisualStyleBackColor = false;
            this.button_AddRedact.Click += new System.EventHandler(this.button_AddRedact_Click);
            // 
            // Book_Chapters_SubFormAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 558);
            this.Controls.Add(this.label_InfoAboutPos);
            this.Controls.Add(this.panel_EdBookInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel_downDGVs);
            this.Controls.Add(this.button_AddRedact);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(733, 597);
            this.MinimumSize = new System.Drawing.Size(733, 597);
            this.Name = "Book_Chapters_SubFormAddUpdate";
            this.Text = "Создание нового учебного раздела";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Book_Chapters_SubFormAddUpdate_FormClosed);
            this.Load += new System.EventHandler(this.Book_Chapters_SubFormAddUpdate_Load);
            this.panel_EdBookInfo.ResumeLayout(false);
            this.panel_EdBookInfo.PerformLayout();
            this.panel_downDGVs.ResumeLayout(false);
            this.panel_downDGVs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Taken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Free)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InfoAboutPos;
        private System.Windows.Forms.Panel panel_EdBookInfo;
        private System.Windows.Forms.Label label_IDchapter;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_NumberofChapter;
        private System.Windows.Forms.Label label_ChapterName;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_downDGVs;
        private System.Windows.Forms.Label label_parForCurrentEdBook;
        private System.Windows.Forms.Label label_FreePar;
        private FontAwesome.Sharp.IconButton iconButton_ArrowRight;
        private FontAwesome.Sharp.IconButton iconButton_ArrowLeft;
        private System.Windows.Forms.DataGridView dataGridView_Taken;
        private System.Windows.Forms.DataGridView dataGridView_Free;
        private System.Windows.Forms.Button button_AddRedact;
        private System.Windows.Forms.TextBox textBox_Numbers;
    }
}