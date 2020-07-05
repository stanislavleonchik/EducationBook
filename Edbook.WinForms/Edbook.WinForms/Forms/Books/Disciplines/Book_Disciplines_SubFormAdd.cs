using System;
using System.Windows.Forms;

namespace Edbook.WinForms.Forms.Books.Disciplines
{
    public partial class Book_Disciplines_SubFormAdd : Form
    {
        #region Конструктор
        public Book_Disciplines_SubFormAdd()
        {
            InitializeComponent();
        }
        #endregion
        #region Кнопка введения новой дисциплины
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_nameOfDiscipline.Text.Length > 60) // Проверка на длину названия
            {
                MessageBox.Show("Максимальная длина названия дисциплины - 60. Вы не можете добавить эту дисциплину.", Book_Disciplines.AddCaptionError);
                return;
            }
            if (textBox_nameOfDiscipline.Text == "")       // Проверка на заполненность поля
            {
                MessageBox.Show("Вы не указали название учебной дисциплины.", Book_Disciplines.AddCaptionError);
                return;
            }

            // SQL-команда добавления в таблицу новой дисциплины
            string sql = "INSERT INTO disciplines values('" + textBox_nameOfDiscipline.Text + "')";
            // Проверка на повтор и другие несоответствия при добавлении
            if (!SQL.clSQL.Modification_Execute(sql))
            {
                MessageBox.Show("Указанная вами дисциплина либо уже существует в базе данных, " +
                    "либо же она имеет некорректное название.", Book_Disciplines.AddCaptionError);
                return;
            }
            SQL.clSQL.ds.Tables["disciplines"].Rows.Add(textBox_nameOfDiscipline.Text); // Дисциплина добавляется в dataSet (и тем самым отображается в DataGridView)

            this.Close(); // Закрытие формы добавления
        }
        #endregion
        #region Закрытие формы
        private void Book_Disciplines_SubFormAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Books_UClass.isRedactAdd = false; // Ставим переменную открытости формы на false
        }
        #endregion
    }
}
