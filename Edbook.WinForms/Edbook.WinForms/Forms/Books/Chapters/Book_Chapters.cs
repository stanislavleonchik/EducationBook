using System;
using System.Windows.Forms;

namespace Edbook.WinForms.Forms.Books.Chapters
{
    public partial class Book_Chapters : Form
    {
        #region Конструктор
        public Book_Chapters()
        {
            InitializeComponent();
        }
        #endregion
        #region Поля
        public static string RemoveCaptionError = "Ошибка удаления учебного раздела";                  // Заголовок при сообщениях об ошибке удаления
        public static string AddCaptionError = "Ошибка добавления/редактирования учебного раздела";    // Заголовок при сообщениях об ошибке добавления
        public static bool loadRedactedForm = false;                                                   // Поле, служащее для отображения того, добавляется ли учебный раздел или нет
        public static int index = -1;
        #endregion
        #region Событие загрузки формы
        private void Book_Chapters_Load(object sender, EventArgs e)
        {
            // SQL-команда и её содержимое для выборки раздела (и отображение привязки этого раздела к пособию)
            string sql = "SELECT chapters.id_ofchapter AS \"ID\", " +
                "chapters.numberofchapter AS \"Номер\", " +
                "chapters.nameofchapter AS \"Название раздела\", " +
                "edbooks.name_ofedbook AS \"Принадлежность к пособию\" " +
                "FROM(chapters LEFT JOIN edbooks ON chapters.id_edbook = edbooks.id_edbook) " +
                "ORDER BY chapters.id_ofchapter";

            // Обновление информации о разделах в таблице "chapters" в DataSet в соответствии с SQL-командой
            SQL.clSQL.TableFill("chapters", sql);

            // Отображение в DataGridView данной формы таблицы "chapters" из DataSet
            dataGridView_ofChapters.DataSource = SQL.clSQL.ds.Tables["chapters"];

            // Метод, запрещающий изменения DataGridView
            Styles.DGVdefaultSettings.FormationDGV(dataGridView_ofChapters);

            // Убираем выделение какой либо ячейки в DataGridView
            dataGridView_ofChapters.CurrentCell = null;

            // Ресайз DataGridView исходя из содержмиого столбцов
            dataGridView_ofChapters.AutoResizeColumns();
        }
        #endregion
        #region Кнопка создания нового раздела
        private void iconButton_Add_Click(object sender, EventArgs e)
        {
            if (Books_UClass.isRedactAdd == false)
            {
                Form ChildFormAdd = new Chapters.Book_Chapters_SubFormAddUpdate();// Открытие формы добавления
                Books_UClass.isRedactAdd = true;                                  // Переменная, отображающая, является ли форма добавления открытой
                ChildFormAdd.Show();                                              // Отображение формы добавления
            }
            else
            {
                // Сообщение об ошибке, если в данный момент форма добавления нового раздела уже открыта
                MessageBox.Show(Books_UClass.OpenSubFormErrorMessage, AddCaptionError);
            }
            dataGridView_ofChapters.CurrentCell = null; // Сброс активной ячейки
        }
        #endregion
        #region Кнопка редактирования учебного раздела
        private void iconButton_Redact_Click(object sender, EventArgs e)
        {
            try
            {
                if (Books_UClass.isRedactAdd == false)
                {
                    index = dataGridView_ofChapters.CurrentRow.Index;                 // Поле Index принимает значение текущей выделенной строки

                    Form ChildFormAdd = new Book_Chapters_SubFormAddUpdate();         // Открытие формы редактирования
                    loadRedactedForm = true;                                          // Переменная, отображающая, форма редактируется или добавляется
                    Books_UClass.isRedactAdd = true;                                  // Переменная, отображающая, открыта ли форма 
                    ChildFormAdd.Show();                                              // Отображение формы добавления
                }
                else
                {
                    // Сообщение об ошибке, если в данный момент форма добавления нового раздела уже открыта
                    MessageBox.Show(Books_UClass.OpenSubFormErrorMessage, AddCaptionError);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Учебный раздел для редактирования указан некорректно.", AddCaptionError);
            }
            dataGridView_ofChapters.CurrentCell = null; // Сброс активной ячейки
        }
        #endregion
        #region Удаление раздела
        private void iconButton_Delete_Click(object sender, EventArgs e)
        {
            if (Books_UClass.isRedactAdd == false)
            {
                try
                {
                    index = dataGridView_ofChapters.CurrentRow.Index;
                    if (index != -1)
                    {
                        // Сообщение об удалении записи - начало
                        string message = "Вы точно хотите удалить учебный раздел «" + dataGridView_ofChapters.Rows[index].Cells["Название раздела"].Value + "» под ID №" 
                            + dataGridView_ofChapters.Rows[index].Cells["ID"].Value;
                        string caption = "Удаление раздела";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult MsgBoxResult = MessageBox.Show(message, caption, buttons);
                        if (MsgBoxResult == DialogResult.No)
                        {
                            return;
                        }
                        // Сообщение об удалении записи - конец

                        // SQL-команда на удаление раздела
                        string sql = "DELETE FROM chapters WHERE chapters.id_ofchapter = " +
                            dataGridView_ofChapters.Rows[index].Cells["ID"].Value;
                        SQL.clSQL.Modification_Execute(sql);                                            // Отправляем команду на удаление
                        SQL.clSQL.ds.Tables["chapters"].Rows.RemoveAt(index);                           // Удаляем строку с разделом из DataSet (тем самым и из DataGridView)

                        dataGridView_ofChapters.CurrentCell = null;                                     // Сбрасываем CurrentCell
                        index = -1;                                                                     // Сбрасываем значение индекса
                    }
                    else // Сообщение об ошибке в случае некорректного выбора записи
                    {
                        MessageBox.Show("Учебный раздел для удаления указано некорректно.", RemoveCaptionError);
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Учебный раздел для удаления указано некорректно.", RemoveCaptionError);
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
