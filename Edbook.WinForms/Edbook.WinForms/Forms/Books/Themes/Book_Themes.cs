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
    public partial class Book_Themes : Form
    {
        #region Поля
        public static string RemoveCaptionError = "Ошибка удаления учебной темы";                      // Заголовок при сообщениях об ошибке удаления
        public static string AddCaptionError = "Ошибка добавления/редактирования учебной темы";        // Заголовок при сообщениях об ошибке добавления
        public static bool loadRedactedForm = false;                                                   // Поле, служащее для отображения того, добавляется ли учебная тема или нет
        public static int index = -1;
        #endregion
        #region Конструктор
        public Book_Themes()
        {
            InitializeComponent();
        }
        #endregion
        #region Событие загрузки формы
        private void Book_Themes_Load(object sender, EventArgs e)
        {
            // SQL-команда и её содержимое для выборки темы (и отображение привязки этой темы к разделу)
            string sql = "SELECT themes.id_oftheme AS \"ID\", " +
                "themes.numberoftheme AS \"Номер\", " +
                "themes.nameoftheme AS \"Название темы\", " +
                "themes.contentoftheme AS \"Содержимое\", " +
                "chapters.nameofchapter AS \"Принадлежность к разделу\" " +
                "FROM(themes LEFT JOIN chapters ON themes.id_ofchapter = chapters.id_ofchapter) " +
                "ORDER BY themes.id_oftheme";

            // Обновление информации о темах в таблице "themes" в DataSet в соответствии с SQL-командой
            SQL.clSQL.TableFill("themes", sql);

            // Отображение в DataGridView данной формы таблицы "themes" из DataSet
            dataGridView_ofThemes.DataSource = SQL.clSQL.ds.Tables["themes"];

            // Метод, запрещающий изменения DataGridView
            Styles.DGVdefaultSettings.FormationDGV(dataGridView_ofThemes);

            // Убираем выделение какой либо ячейки в DataGridView
            dataGridView_ofThemes.CurrentCell = null;

            // Ресайз DataGridView исходя из содержмиого столбцов
            dataGridView_ofThemes.AutoResizeColumns();

            // Скрываем столбец содержимого тем
            dataGridView_ofThemes.Columns[3].Visible = false;
        }
        #endregion
        #region Добавление новой темы
        private void iconButton_Add_Click(object sender, EventArgs e)
        {
            if (Books_UClass.isRedactAdd == false)
            {
                Form ChildFormAdd = new Themes.Book_Themes_SubFormAddUpdate();    // Открытие формы добавления
                Books_UClass.isRedactAdd = true;                                  // Переменная, отображающая, является ли форма добавления открытой
                ChildFormAdd.Show();                                              // Отображение формы добавления
            }
            else
            {
                // Сообщение об ошибке, если форма открыта
                MessageBox.Show(Books_UClass.OpenSubFormErrorMessage, AddCaptionError);
            }
            dataGridView_ofThemes.CurrentCell = null; // Сброс активной ячейки
        }
        #endregion
        #region Редактирование темы
        private void iconButton_Redact_Click(object sender, EventArgs e)
        {
            try
            {
                if (Books_UClass.isRedactAdd == false)
                {
                    index = dataGridView_ofThemes.CurrentRow.Index;                   // Поле Index принимает значение текущей выделенной строки

                    Form ChildFormAdd = new Themes.Book_Themes_SubFormAddUpdate();    // Открытие формы редактирования
                    loadRedactedForm = true;                                          // Переменная, отображающая, форма редактируется или добавляется
                    Books_UClass.isRedactAdd = true;                                  // Переменная, отображающая, открыта ли форма 
                    ChildFormAdd.Show();                                              // Отображение формы добавления
                }
                else
                {
                    // Сообщение об ошибке, если в данный момент форма добавления нового раздела уже открыта
                    MessageBox.Show("В данный момент форма добавления/редактирования уже открыта.", AddCaptionError);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Учебный раздел для редактирования указан некорректно.", AddCaptionError);
            }
            dataGridView_ofThemes.CurrentCell = null; // Сброс активной ячейки
        }
        #endregion
        #region Удаление темы
        private void iconButton_Delete_Click(object sender, EventArgs e)
        {
            if (Books_UClass.isRedactAdd == false)
            {
                try
                {
                    index = dataGridView_ofThemes.CurrentRow.Index;
                    if (index != -1)
                    {
                        // Сообщение об удалении записи - начало
                        string message = "Вы точно хотите удалить учебную тему «" + dataGridView_ofThemes.Rows[index].Cells["Название темы"].Value + "» под ID №"
                            + dataGridView_ofThemes.Rows[index].Cells["ID"].Value;
                        string caption = "Удаление темы";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult MsgBoxResult = MessageBox.Show(message, caption, buttons);
                        if (MsgBoxResult == DialogResult.No)
                        {
                            return;
                        }
                        // Сообщение об удалении записи - конец

                        // SQL-команда на удаление дисциплины
                        string sql = "DELETE FROM themes WHERE themes.id_oftheme = " +
                            dataGridView_ofThemes.Rows[index].Cells["ID"].Value;
                        SQL.clSQL.Modification_Execute(sql);                                            // Отправляем команду на удаление
                        SQL.clSQL.ds.Tables["themes"].Rows.RemoveAt(index);                             // Удаляем строку с пособием из DataSet (тем самым и из DataGridView)

                        dataGridView_ofThemes.CurrentCell = null;                                       // Сбрасываем CurrentCell
                        index = -1;                                                                     // Сбрасываем значение индекса
                    }
                    else // Сообщение об ошибке в случае некорректного выбора записи
                    {
                        MessageBox.Show("Учебная тема для удаления указана некорректно.", RemoveCaptionError);
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Учебная тема для удаления указана некорректно.", RemoveCaptionError);
                }
            }
            else
            {
                MessageBox.Show("Вы не можете удалить учебную тему, если у вас в данный момент открыта форма для редактирования/добавления.", RemoveCaptionError);
            }
        }
        #endregion
    }
}
