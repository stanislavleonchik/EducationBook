using System;
using System.Windows.Forms;

namespace Edbook.WinForms.Forms.Books.Disciplines
{
    public partial class Book_Disciplines : Form
    {
        #region Поля
        private int index = -1;                                                 // Индекс выделенной строки
        public static string RemoveCaptionError = "Ошибка удаления дсициплины"; // Заголовок при сообщениях об ошибке удаления
        public static string AddCaptionError = "Ошибка введения дисциплины";    // Заголовок при сообщениях об ошибке добавления
        #endregion
        #region Конструктор
        public Book_Disciplines()
        {
            InitializeComponent();
        }
        #endregion
        #region Загрузка формы
        private void Book_Disciplines_Load(object sender, EventArgs e)
        {
            string sql; // SQL-команда
            // Содержимое SQL-команды
            sql = "SELECT disciplines.name_ofdiscipline AS \"Наименования учебных дисциплин\" FROM disciplines ORDER BY name_ofdiscipline";

            // Обновление информации о дисциплинах в таблице "Дисциплины" в DataSet в соответствии с SQL-командой
            SQL.clSQL.TableFill("disciplines", sql);

            // Отображение в DataGridView данной формы таблицы "disciplines" из DataSet
            dataGridView_ofDisciplines.DataSource = SQL.clSQL.ds.Tables["disciplines"];

            // Метод, запрещающий изменения DataGridView
            Styles.DGVdefaultSettings.FormationDGV(dataGridView_ofDisciplines);

            // Убираем выделение какой либо ячейки в DataGridView
            dataGridView_ofDisciplines.CurrentCell = null;
        }
        #endregion
        #region Добавление новой записи в таблицу "Дисциплины"
        private void iconButton_Add_Click(object sender, EventArgs e)
        {
            if (Books_UClass.isRedactAdd == false)
            {
                Form ChildFormAdd = new Disciplines.Book_Disciplines_SubFormAdd();  // Открытие формы добавления
                Books_UClass.isRedactAdd = true;                                    // Переменная, отображающая, является ли форма добавления открытой
                ChildFormAdd.Show();                                                // Отображение формы добавления
            }
            else
            {
                // Сообщение об ошибке, если в данный момент форма добавления новой дисциплины уже открыта
                MessageBox.Show(Books_UClass.OpenSubFormErrorMessage, AddCaptionError);
            }
        }
        #endregion
        #region Удаление записи в таблице "Дисциплины"
        private void iconButton_Delete_Click(object sender, EventArgs e)
        {
            if (Books_UClass.isRedactAdd == false)
                {
                try
                {
                    index = dataGridView_ofDisciplines.CurrentRow.Index;
                    if (index != -1)
                    {
                        // Сообщение об удалении записи - начало
                        string message = "Вы точно хотите удалить дисциплину «" + dataGridView_ofDisciplines.Rows[index].Cells["Наименования учебных дисциплин"].Value + "»";
                        string caption = "Удаление дисциплины";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult MsgBoxResult = MessageBox.Show(message, caption, buttons);
                        if (MsgBoxResult == DialogResult.No)
                        {
                            return;
                        }
                        // Сообщение об удалении записи - конец

                        // SQL-команда на удаление дисциплины
                        string sql = "DELETE FROM disciplines WHERE name_ofdiscipline = '" +
                            dataGridView_ofDisciplines.Rows[index].Cells["Наименования учебных дисциплин"].Value + "'";
                        SQL.clSQL.Modification_Execute(sql);                                            // Отправляем команду на удаление
                        SQL.clSQL.ds.Tables["disciplines"].Rows.RemoveAt(index);                        // Удаляем строку с дисциплиной из DataSet (тем самым и из DataGridView)

                        dataGridView_ofDisciplines.CurrentCell = null;                                  // Сбрасываем CurrentCell
                        index = -1;                                                                     // Сбрасываем значение индекса
                    }
                    else // Сообщение об ошибке в случае некорректного выбора записи
                    {
                        MessageBox.Show("Дисциплина для удаления указана некорректна.", RemoveCaptionError);
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Дисциплина для удаления указана некорректна.", RemoveCaptionError);
                }
            }
            else
            {
                MessageBox.Show(Books_UClass.OpenSubFormErrorMessage, RemoveCaptionError);
            }
        }
        #endregion
    }
}
