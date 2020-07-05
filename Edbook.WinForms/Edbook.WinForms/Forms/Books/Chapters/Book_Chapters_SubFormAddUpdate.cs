using System;
using System.Drawing;
using System.Windows.Forms;

namespace Edbook.WinForms.Forms.Books.Chapters
{
    public partial class Book_Chapters_SubFormAddUpdate : Form
    {
        #region Конструктор
        public Book_Chapters_SubFormAddUpdate()
        {
            InitializeComponent();
        }
        #endregion
        #region Событие загрузки формы
        private void Book_Chapters_SubFormAddUpdate_Load(object sender, EventArgs e)
        {
            #region Загрузка полей и изменение формы в случае редактирования раздела
            if (Book_Chapters.loadRedactedForm == true)
            {
                this.Name = "Редактирование учебного раздела";
                button_AddRedact.Text = "Принять изменения";    // Заменяем текст кнопки для режима редактирования

                textBox_ID.ReadOnly = true;
                textBox_ID.BackColor = Color.LightGray;

                #region Заполнение полей редактирования из DataSet
                textBox_ID.Text = SQL.clSQL.ds.Tables["chapters"].Rows[Book_Chapters.index]["ID"].ToString();                    // Загрузка ID раздела
                textBox_Name.Text = SQL.clSQL.ds.Tables["chapters"].Rows[Book_Chapters.index]["Название раздела"].ToString();    // Загрузка названия раздела
                textBox_Numbers.Text = SQL.clSQL.ds.Tables["chapters"].Rows[Book_Chapters.index]["Номер"].ToString();            // Загрузка учебной дисциплины
                #endregion
            }
            #endregion
            #region Загрузка свободных разделов
            // sql-команда заполнения DataGridView'а свободных тем
            string sql = "SELECT themes.id_oftheme AS \"ID\", themes.numberoftheme AS \"Номер\", " +
                "themes.nameoftheme AS \"Название\" " +
                "FROM themes WHERE themes.id_ofchapter IS NULL " +
                "ORDER BY themes.numberoftheme";

            // Создаём table свободных тем
            SQL.clSQL.TableFill("freeThemes", sql);
            // Заполняем DGV table'ом свободных тем
            dataGridView_Free.DataSource = SQL.clSQL.ds.Tables["freeThemes"];

            // Метод, запрещающий изменения DataGridView
            Styles.DGVdefaultSettings.FormationDGV(dataGridView_Free);

            // Убираем выделение какой либо ячейки в DataGridView
            dataGridView_Free.CurrentCell = null;

            // Ресайз DataGridView исходя из содержмиого столбцов
            dataGridView_Free.AutoResizeColumns();
            #endregion
            #region Загрузка занятых разделов этого пособия
            if (Book_Chapters.loadRedactedForm == true)  // SQL-команда будет зависить от того, создаём мы новое пособие или же редактируем существующее
            {
                // sql-команда заполнения DataGridView'а занятых тем
                sql = "SELECT themes.id_oftheme AS \"ID\", themes.numberoftheme AS \"Номер\", " +
                        "themes.nameoftheme AS \"Название\" " +
                        "FROM themes WHERE themes.id_ofchapter = " + textBox_ID.Text + " ORDER BY themes.numberoftheme";
            }
            else
            {

                // sql-команда заполнения DataGridView'а свободных разделов
                sql = "SELECT themes.id_oftheme AS \"ID\", themes.numberoftheme AS \"Номер\", themes.nameoftheme AS \"Название\" FROM themes WHERE themes.id_ofchapter = " + (-10) + " ORDER BY themes.numberoftheme";
            }

            // Создаём table занятых тем
            SQL.clSQL.TableFill("takenThemes", sql);
            // Заполняем DGV table'ом свободных тем
            dataGridView_Taken.DataSource = SQL.clSQL.ds.Tables["takenThemes"];

            // Метод, запрещающий изменения DataGridView
            Styles.DGVdefaultSettings.FormationDGV(dataGridView_Taken);

            // Убираем выделение какой либо ячейки в DataGridView
            dataGridView_Free.CurrentCell = null;

            // Ресайз DataGridView исходя из содержмиого столбцов
            dataGridView_Free.AutoResizeColumns();
            #endregion
        }
        #endregion
        #region Событие закрытия формы
        private void Book_Chapters_SubFormAddUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Books_UClass.isRedactAdd = false; // Сообщаем при закрытии в данное поле то, что в данный момент никакая форма редактирования/добавления не открыта
            if (Book_Chapters.loadRedactedForm == true)
                Book_Chapters.loadRedactedForm = false;
        }
        #endregion
        #region Создание нового учебного раздела/редактирования учебного раздела
        private void button_AddRedact_Click(object sender, EventArgs e)
        {
            int ID;            // Поле, хранящее в себе ID раздела
            int ChapterNumber; // Поле, хранящее в себе номер раздела
            string sql;        // Поле для SQL-команд
            #region Проверки полей
            try
            {
                ID = Convert.ToInt32(textBox_ID.Text);
                ChapterNumber = Convert.ToInt32(textBox_Numbers.Text);
                // Проверка корректности содержимого полей:
                if (textBox_ID.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить поле «ID раздела».", Book_Chapters.AddCaptionError);
                    return;
                }
                if (textBox_Name.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить поле «Название раздела».", Book_Chapters.AddCaptionError);
                    return;
                }
                if (textBox_Numbers.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить поле «Номер раздела».", Book_Chapters.AddCaptionError);
                    return;
                }
            }
            catch (ArgumentOutOfRangeException) // Проверка выхода номера и ID раздела за пределы переменной int
            {
                MessageBox.Show("Поля «ID раздела» и «Номер раздела» не могут быть больше значения " + int.MaxValue + ".", Book_Chapters.AddCaptionError);
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Поле «ID раздела» или «Номер раздела» являются пустыми полями, либо же их формат некорректен. Значения данных полей могут являться только целочисленными положительными значениями.", Book_Chapters.AddCaptionError);
                return;
            }
            // Проверки на соответствие длинн переменных string с базой данных:
            if (textBox_Name.Text.Length > 64)
            {
                MessageBox.Show("Название раздела слишком длинное. Максимальная длина данного поля - 64 символов", Book_Chapters.AddCaptionError);
                return;
            }

            // Запрещаем указывать в номере раздела отрицательные значения
            if ((ID < 0) || (ChapterNumber <= 0))
            {
                MessageBox.Show("Номер раздела и его ID должны являться положительными целочисленными значениями.", Book_Chapters.AddCaptionError);
                return;
            }
            #endregion
            if (Book_Chapters.loadRedactedForm == true)
            {
                #region Редактирование текущего раздела
                // SQL-команда обновления
                sql = "UPDATE chapters SET nameofchapter = '" + textBox_Name.Text + "', numberofchapter = " + ChapterNumber + " WHERE id_ofchapter = " + ID;
                #endregion
            }
            else
            {
                #region Создание нового учебного раздела
                // SQL-команда для добавления нового учебного раздела в базу данных
                sql = "INSERT INTO chapters (id_ofchapter, numberofchapter, nameofchapter) values(" + ID
                    + ", " + ChapterNumber + ", '" + textBox_Name.Text + "')";
                #endregion
            }
            #region Добавление в БД с учётом проверки на ошибки
            if (!SQL.clSQL.Modification_Execute(sql))
            {
                MessageBox.Show("Указанный вами ID учебного раздела либо уже занят, " +
                    "либо же поля раздела заполнены некорректно", Book_Chapters.AddCaptionError);
                return;
            }
            #endregion
            #region Изменение информации в dataSet
            if (Book_Chapters.loadRedactedForm == true)
            {
                // Добавляем только что созданный учебный раздел в dataSet
                SQL.clSQL.ds.Tables["chapters"].Rows[Book_Chapters.index].ItemArray = new object[]
                { ID, textBox_Numbers.Text, textBox_Name.Text };

                CheckDGV();
            }
            else
            {
                // Добавляем только что созданное учебное пособие в dataSet
                SQL.clSQL.ds.Tables["chapters"].Rows.Add(new object[] { ID, textBox_Numbers.Text, textBox_Name.Text });

                CheckDGV();
            }
            #endregion

            this.Close(); // Закрытие формы добавления
        }
        #endregion
        #region Методы присваивания дополнительных элементов Dataset
        private void CheckDGV()
        {
            for (int i = 0; i < SQL.clSQL.ds.Tables["freeThemes"].Rows.Count; i++)
            {
                string sql = "UPDATE themes SET id_ofchapter = null WHERE id_oftheme = " + SQL.clSQL.ds.Tables["freeThemes"].Rows[i]["ID"];
                SQL.clSQL.Modification_Execute(sql);
            }

            for (int i = 0; i < SQL.clSQL.ds.Tables["takenThemes"].Rows.Count; i++)
            {
                string sql = "UPDATE themes SET id_ofchapter = " + textBox_ID.Text + " WHERE id_oftheme = " + SQL.clSQL.ds.Tables["takenThemes"].Rows[i]["ID"];
                SQL.clSQL.Modification_Execute(sql);
            }
        }
        #endregion
        #region Поля
        int indexSubDgv;
        #endregion
        #region Кнопки взамиодействия с сабDataGridView
        private void iconButton_ArrowRight_Click(object sender, EventArgs e)
        {
            try
            {
                indexSubDgv = dataGridView_Free.CurrentCell.RowIndex;

                SQL.clSQL.ds.Tables["takenThemes"].Rows.Add(new object[]
                {
                    SQL.clSQL.ds.Tables["freeThemes"].Rows[indexSubDgv]["ID"],
                    SQL.clSQL.ds.Tables["freeThemes"].Rows[indexSubDgv]["Номер"],
                    SQL.clSQL.ds.Tables["freeThemes"].Rows[indexSubDgv]["Название"]
                });
                SQL.clSQL.ds.Tables["freeThemes"].Rows.RemoveAt(indexSubDgv);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Тема для перемещения указана неорректно.", "Ошибка перемещения разделов");
                return;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Тема для перемещения указана неорректно.", "Ошибка перемещения разделов");
                return;
            }
        }

        private void iconButton_ArrowLeft_Click(object sender, EventArgs e)
        {
            try
            {
                indexSubDgv = dataGridView_Taken.CurrentCell.RowIndex;

                SQL.clSQL.ds.Tables["freeThemes"].Rows.Add(new object[]
                {
                    SQL.clSQL.ds.Tables["takenThemes"].Rows[indexSubDgv]["ID"],
                    SQL.clSQL.ds.Tables["takenThemes"].Rows[indexSubDgv]["Номер"],
                    SQL.clSQL.ds.Tables["takenThemes"].Rows[indexSubDgv]["Название"]
                });
                SQL.clSQL.ds.Tables["takenThemes"].Rows.RemoveAt(indexSubDgv);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Тема для перемещения указана неорректно.", "Ошибка перемещения разделов");
                return;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Тема для перемещения указана неорректно.", "Ошибка перемещения разделов");
                return;
            }
        }
        #endregion
    }
}
