using System;
using System.Windows.Forms;

namespace Edbook.WinForms.Forms.Books.EdBooks
{
    public partial class Book_EdBooks : Form
    {
        #region Поля
        public static int index = -1;                                                                  // Индекс выделенной строки
        public static bool isRedact = false;                                                           // Информация о редактировании формы
        public static string RemoveCaptionError = "Ошибка удаления учебного пособия";                  // Заголовок при сообщениях об ошибке удаления
        public static string AddCaptionError = "Ошибка добавления/редактирования учебного пособия";    // Заголовок при сообщениях об ошибке добавления
        #endregion
        #region Конструктор
        public Book_EdBooks()
        {
            InitializeComponent();
        }
        #endregion
        #region Загрузка формы
        private void Book_EdBooks_Load(object sender, EventArgs e)
        {
            string sql; // SQL-команда
            // Содержимое SQL-команды
            sql = "SELECT edbooks.id_edbook AS \"ID\", edbooks.name_ofedbook AS \"Название пособия\", edbooks.name_ofdiscipline AS \"Учебная дисциплина\", edbooks.author_firstname AS \"Имя автора\",  edbooks.author_secondname AS \"Фамилия автора\", edbooks.author_thirdname AS \"Отчество автора\"  FROM edbooks ORDER BY edbooks.id_edbook";

            // Обновление информации об учебных пособия в таблице "edbooks" в DataSet в соответствии с SQL-командой
            SQL.clSQL.TableFill("edbooks", sql);

            // Отображение в DataGridView данной формы таблицы "education_books" из DataSet
            dataGridView_ofBooks.DataSource = SQL.clSQL.ds.Tables["edbooks"];

            // Метод, запрещающий изменения DataGridView
            Styles.DGVdefaultSettings.FormationDGV(dataGridView_ofBooks);

            // Убираем выделение какой либо ячейки в DataGridView
            dataGridView_ofBooks.CurrentCell = null;

            // Ресайз DataGridView исходя из содержмиого столбцов
            dataGridView_ofBooks.AutoResizeColumns();

        }
        #endregion
        #region Новое учебное пособие
        private void iconButton_Add_Click(object sender, EventArgs e)
        {
            if (Books_UClass.isRedactAdd == false)
            {
                Form ChildFormAdd = new Book_EdBooks_SubFormAddUpdate();          // Открытие формы добавления
                Books_UClass.isRedactAdd = true;                                  // Переменная, отображающая, является ли форма добавления открытой
                ChildFormAdd.Show();                                              // Отображение формы добавления
            }
            else
            {
                // Сообщение об ошибке, если в данный момент форма добавления нового пособия уже открыта
                MessageBox.Show(Books_UClass.OpenSubFormErrorMessage, AddCaptionError);
            }
            dataGridView_ofBooks.CurrentCell = null; // Сброс активной ячейки
        }
        #endregion
        #region Редактирование пособия
        private void iconButton_Redact_Click(object sender, EventArgs e)
        {
            try
            {
                if (Books_UClass.isRedactAdd == false)
                {
                    index = dataGridView_ofBooks.CurrentRow.Index;                    // Поле Index принимает значение текузей выделенной строки

                    Form ChildFormAdd = new Book_EdBooks_SubFormAddUpdate();          // Открытие формы редактирования
                    isRedact = true;                                                  // Переменная, отображающая, является ли форма добавления открытой
                    Books_UClass.isRedactAdd = true;                                  // Изменяем переменную, отображающую то, что форма будет редактироваться
                    ChildFormAdd.Show();                                              // Отображение формы добавления
                }
                else
                {
                    // Сообщение об ошибке, если в данный момент форма добавления новой дисциплины уже открыта
                    MessageBox.Show(Books_UClass.OpenSubFormErrorMessage, AddCaptionError);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Учебное пособие для редактирования указано некорректно.", AddCaptionError);
            }
            dataGridView_ofBooks.CurrentCell = null; // Сброс активной ячейки
        }
        #endregion
        #region Удаление пособия
        private void iconButton_Delete_Click(object sender, EventArgs e)
        {
            if (Books_UClass.isRedactAdd == false)
            {
                try
                {
                    index = dataGridView_ofBooks.CurrentRow.Index;
                    if (index != -1)
                    {
                        // Сообщение об удалении записи - начало
                        string message = "Вы точно хотите удалить учебное пособие «" + dataGridView_ofBooks.Rows[index].Cells["Название пособия"].Value + "» под ID №"
                            + dataGridView_ofBooks.Rows[index].Cells["ID"].Value;
                        string caption = "Удаление пособия";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult MsgBoxResult = MessageBox.Show(message, caption, buttons);
                        if (MsgBoxResult == DialogResult.No)
                        {
                            return;
                        }
                        // Сообщение об удалении записи - конец

                        // SQL-команда на удаление дисциплины
                        string sql = "DELETE FROM edbooks WHERE id_edbook = " +
                            dataGridView_ofBooks.Rows[index].Cells["ID"].Value;
                        SQL.clSQL.Modification_Execute(sql);                                            // Отправляем команду на удаление
                        SQL.clSQL.ds.Tables["edbooks"].Rows.RemoveAt(index);                            // Удаляем строку с пособием из DataSet (тем самым и из DataGridView)

                        dataGridView_ofBooks.CurrentCell = null;                                        // Сбрасываем CurrentCell
                        index = -1;                                                                     // Сбрасываем значение индекса
                    }
                    else // Сообщение об ошибке в случае некорректного выбора записи
                    {
                        MessageBox.Show("Учебное пособие для удаления указано некорректно.", RemoveCaptionError);
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Учебное пособие для удаления указано некорректно.", RemoveCaptionError);
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
