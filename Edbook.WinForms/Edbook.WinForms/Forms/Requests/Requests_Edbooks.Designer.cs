namespace Edbook.WinForms.Forms.Requests
{
    partial class Requests_Edbooks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_ofDiscips = new System.Windows.Forms.ComboBox();
            this.textBox_byAuth = new System.Windows.Forms.TextBox();
            this.textBox_byName = new System.Windows.Forms.TextBox();
            this.radioButton_byAuth = new System.Windows.Forms.RadioButton();
            this.radioButton_byDiscip = new System.Windows.Forms.RadioButton();
            this.radioButton_byName = new System.Windows.Forms.RadioButton();
            this.radioButton_allEdbooks = new System.Windows.Forms.RadioButton();
            this.dataGridView_ofBooksRQ = new System.Windows.Forms.DataGridView();
            this.label_top = new System.Windows.Forms.Label();
            this.button_Open = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ofBooksRQ)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comboBox_ofDiscips);
            this.panel1.Controls.Add(this.textBox_byAuth);
            this.panel1.Controls.Add(this.textBox_byName);
            this.panel1.Controls.Add(this.radioButton_byAuth);
            this.panel1.Controls.Add(this.radioButton_byDiscip);
            this.panel1.Controls.Add(this.radioButton_byName);
            this.panel1.Controls.Add(this.radioButton_allEdbooks);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 106);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_ofDiscips
            // 
            this.comboBox_ofDiscips.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ofDiscips.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_ofDiscips.FormattingEnabled = true;
            this.comboBox_ofDiscips.Location = new System.Drawing.Point(407, 69);
            this.comboBox_ofDiscips.Name = "comboBox_ofDiscips";
            this.comboBox_ofDiscips.Size = new System.Drawing.Size(389, 25);
            this.comboBox_ofDiscips.TabIndex = 8;
            // 
            // textBox_byAuth
            // 
            this.textBox_byAuth.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_byAuth.Location = new System.Drawing.Point(452, 41);
            this.textBox_byAuth.Name = "textBox_byAuth";
            this.textBox_byAuth.Size = new System.Drawing.Size(344, 22);
            this.textBox_byAuth.TabIndex = 7;
            // 
            // textBox_byName
            // 
            this.textBox_byName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_byName.Location = new System.Drawing.Point(407, 14);
            this.textBox_byName.Name = "textBox_byName";
            this.textBox_byName.Size = new System.Drawing.Size(389, 22);
            this.textBox_byName.TabIndex = 6;
            // 
            // radioButton_byAuth
            // 
            this.radioButton_byAuth.AutoSize = true;
            this.radioButton_byAuth.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton_byAuth.Location = new System.Drawing.Point(218, 42);
            this.radioButton_byAuth.Name = "radioButton_byAuth";
            this.radioButton_byAuth.Size = new System.Drawing.Size(228, 23);
            this.radioButton_byAuth.TabIndex = 5;
            this.radioButton_byAuth.TabStop = true;
            this.radioButton_byAuth.Text = "Поиск по автору (фамилия)";
            this.radioButton_byAuth.UseVisualStyleBackColor = true;
            this.radioButton_byAuth.CheckedChanged += new System.EventHandler(this.radioButton_byAuth_CheckedChanged);
            // 
            // radioButton_byDiscip
            // 
            this.radioButton_byDiscip.AutoSize = true;
            this.radioButton_byDiscip.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton_byDiscip.Location = new System.Drawing.Point(218, 71);
            this.radioButton_byDiscip.Name = "radioButton_byDiscip";
            this.radioButton_byDiscip.Size = new System.Drawing.Size(182, 23);
            this.radioButton_byDiscip.TabIndex = 4;
            this.radioButton_byDiscip.TabStop = true;
            this.radioButton_byDiscip.Text = "Поиск по дисциплине";
            this.radioButton_byDiscip.UseVisualStyleBackColor = true;
            this.radioButton_byDiscip.CheckedChanged += new System.EventHandler(this.radioButton_byDiscip_CheckedChanged);
            // 
            // radioButton_byName
            // 
            this.radioButton_byName.AutoSize = true;
            this.radioButton_byName.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton_byName.Location = new System.Drawing.Point(218, 13);
            this.radioButton_byName.Name = "radioButton_byName";
            this.radioButton_byName.Size = new System.Drawing.Size(166, 23);
            this.radioButton_byName.TabIndex = 3;
            this.radioButton_byName.TabStop = true;
            this.radioButton_byName.Text = "Поиск по названию";
            this.radioButton_byName.UseVisualStyleBackColor = true;
            this.radioButton_byName.CheckedChanged += new System.EventHandler(this.radioButton_byName_CheckedChanged);
            // 
            // radioButton_allEdbooks
            // 
            this.radioButton_allEdbooks.AutoSize = true;
            this.radioButton_allEdbooks.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton_allEdbooks.Location = new System.Drawing.Point(7, 13);
            this.radioButton_allEdbooks.Name = "radioButton_allEdbooks";
            this.radioButton_allEdbooks.Size = new System.Drawing.Size(116, 23);
            this.radioButton_allEdbooks.TabIndex = 0;
            this.radioButton_allEdbooks.TabStop = true;
            this.radioButton_allEdbooks.Text = "Все пособия";
            this.radioButton_allEdbooks.UseVisualStyleBackColor = true;
            this.radioButton_allEdbooks.CheckedChanged += new System.EventHandler(this.radioButton_allEdbooks_CheckedChanged);
            // 
            // dataGridView_ofBooksRQ
            // 
            this.dataGridView_ofBooksRQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ofBooksRQ.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_ofBooksRQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ofBooksRQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ofBooksRQ.Location = new System.Drawing.Point(12, 124);
            this.dataGridView_ofBooksRQ.Name = "dataGridView_ofBooksRQ";
            this.dataGridView_ofBooksRQ.Size = new System.Drawing.Size(912, 272);
            this.dataGridView_ofBooksRQ.TabIndex = 1;
            // 
            // label_top
            // 
            this.label_top.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_top.AutoSize = true;
            this.label_top.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_top.Location = new System.Drawing.Point(15, 3);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(142, 19);
            this.label_top.TabIndex = 0;
            this.label_top.Text = "Запросы к данным";
            // 
            // button_Open
            // 
            this.button_Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.button_Open.FlatAppearance.BorderSize = 0;
            this.button_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Open.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Open.Location = new System.Drawing.Point(12, 402);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(912, 34);
            this.button_Open.TabIndex = 2;
            this.button_Open.Text = "Открыть пособие";
            this.button_Open.UseVisualStyleBackColor = false;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // Requests_Edbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(936, 448);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.label_top);
            this.Controls.Add(this.dataGridView_ofBooksRQ);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Requests_Edbooks";
            this.Text = "Запросы - Учебные пособия";
            this.Load += new System.EventHandler(this.Requests_Edbooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ofBooksRQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_ofDiscips;
        private System.Windows.Forms.TextBox textBox_byAuth;
        private System.Windows.Forms.TextBox textBox_byName;
        private System.Windows.Forms.RadioButton radioButton_byAuth;
        private System.Windows.Forms.RadioButton radioButton_byDiscip;
        private System.Windows.Forms.RadioButton radioButton_byName;
        private System.Windows.Forms.RadioButton radioButton_allEdbooks;
        private System.Windows.Forms.DataGridView dataGridView_ofBooksRQ;
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Button button_Open;
    }
}