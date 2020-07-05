using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edbook.WinForms.Forms.Books.Themes
{
    public partial class Book_Themes_SubFormAddUpdate : Form
    {
        #region Конструктор
        public Book_Themes_SubFormAddUpdate()
        {
            InitializeComponent();
        }
        #endregion
        #region Кнопка добавления/редактирования
        private void button_AddRedact_Click(object sender, EventArgs e)
        {
            #region Проверки полей
            int ID;            // Поле, хранящее в себе ID тнмы
            int ThemeNumber;   // Поле, хранящее в себе номер темы
            string sql;        // Поле для SQL-команд
            try
            {
                ID = Convert.ToInt32(textBox_ID.Text);
                ThemeNumber = Convert.ToInt32(textBox_Numbers.Text);
                // Проверка корректности содержимого полей:
                if (textBox_ID.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить поле «ID темы».", Book_Themes.AddCaptionError);
                    return;
                }
                if (textBox_Name.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить поле «Название темы».", Book_Themes.AddCaptionError);
                    return;
                }
                if (textBox_Numbers.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить поле «Номер темы».", Book_Themes.AddCaptionError);
                    return;
                }
                if (textBox_themeContent.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить содержимое темы.", Book_Themes.AddCaptionError);
                    return;
                }
            }
            catch (ArgumentOutOfRangeException) // Проверка выхода номера и ID раздела за пределы переменной int
            {
                MessageBox.Show("Поля «ID темы» и «Номер темы» не могут быть больше значения " + int.MaxValue + ".", Book_Themes.AddCaptionError);
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Поле «ID темы» или «Номер темы» являются пустыми полями, либо же их формат некорректен. Значения данных полей могут являться только целочисленными положительными значениями.", Book_Themes.AddCaptionError);
                return;
            }
            // Проверки на соответствие длинн переменных string с базой данных:
            if (textBox_Name.Text.Length > 64)
            {
                MessageBox.Show("Название темы слишком длинное. Максимальная длина данного поля - 64 символов", Book_Themes.AddCaptionError);
                return;
            }

            // Запрещаем указывать в номере раздела отрицательные значения
            if ((ID < 0) || (ThemeNumber <= 0))
            {
                MessageBox.Show("Номер темы и её ID должны являться положительными целочисленными значениями.", Book_Themes.AddCaptionError);
                return;
            }
            #endregion
            if (Book_Themes.loadRedactedForm == true)
            {
                #region Редактирование текущего раздела
                // SQL-команда обновления
                sql = "UPDATE themes SET nameoftheme = '" + textBox_Name.Text + "', numberoftheme = " + ThemeNumber + ", contentoftheme = '" + textBox_themeContent.Text + "' WHERE id_oftheme = " + ID;
                #endregion
            }
            else
            {
                #region Создание нового учебного раздела
                // SQL-команда для добавления новой темы в БД
                sql = "INSERT INTO themes (id_oftheme, numberoftheme, nameoftheme, contentoftheme) values(" + ID
                    + ", " + ThemeNumber + ", '" + textBox_Name.Text + "', '" + textBox_themeContent.Text + "')";
                #endregion
            }
            #region Добавление в БД с учётом проверки на ошибки
            if (!SQL.clSQL.Modification_Execute(sql))
            {
                MessageBox.Show("Указанный вами ID темы пособия либо уже занят, " +
                    "либо же поля темы заполнены некорректно", Book_Themes.AddCaptionError);
                return;
            }
            #endregion
            #region Изменение информации в dataSet
            if (Book_Themes.loadRedactedForm == true)
            {
                // Добавляем только что созданный учебный раздел в dataSet
                SQL.clSQL.ds.Tables["themes"].Rows[Book_Themes.index].ItemArray = new object[]
                { ID, textBox_Numbers.Text, textBox_Name.Text, textBox_themeContent.Text };
            }
            else
            {
                // Добавляем только что созданное учебное пособие в dataSet
                SQL.clSQL.ds.Tables["themes"].Rows.Add(new object[] { ID, textBox_Numbers.Text, textBox_Name.Text, textBox_themeContent.Text });
            }
            #endregion

            this.Close(); // Закрытие формы добавления
        }
        #endregion
        #region Событие закрытия формы
        private void Book_Themes_SubFormAddUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Books_UClass.isRedactAdd = false; // Сообщаем при закрытии в данное поле то, что в данный момент никакая форма редактирования/добавления не открыта
            if (Book_Themes.loadRedactedForm == true)
                Book_Themes.loadRedactedForm = false;
        }
        #endregion
        #region Событие загрузки формы
        private void Book_Themes_SubFormAddUpdate_Load(object sender, EventArgs e)
        {
            if (Book_Themes.loadRedactedForm == true)
            {

                // Смена названия и текста кнопки
                this.Name = "Редактирование учебной темы";
                button_AddRedact.Text = "Принять изменения";

                textBox_ID.ReadOnly = true;
                textBox_ID.BackColor = Color.LightGray;

                #region Заполнение полей редактирования из DataSet
                textBox_ID.Text = SQL.clSQL.ds.Tables["themes"].Rows[Book_Themes.index]["ID"].ToString();                    // Загрузка ID пособия
                textBox_Name.Text = SQL.clSQL.ds.Tables["themes"].Rows[Book_Themes.index]["Название темы"].ToString();       // Загрузка названия темы
                textBox_Numbers.Text = SQL.clSQL.ds.Tables["themes"].Rows[Book_Themes.index]["Номер"].ToString();            // Загрузка номера темы
                textBox_themeContent.Text = SQL.clSQL.ds.Tables["themes"].Rows[Book_Themes.index]["Содержимое"].ToString();  // Загрузка содержимого темы
                #endregion
            }
        }
        #endregion
    }
}
