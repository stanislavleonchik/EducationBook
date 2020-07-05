using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edbook.WinForms.Forms.Books.EdBooks
{
    public partial class Book_EdBooks_SubFormAddUpdate : Form
    {
        #region Конструктор
        public Book_EdBooks_SubFormAddUpdate()
        {
            InitializeComponent();
        }
        #endregion
        #region Событие закрытия формы
        private void Book_EdBooks_SubFormAddUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Books_UClass.isRedactAdd = false;       // Указываем, что форма более открытой не является

            if (Book_EdBooks.isRedact == true)      // Сбрасываем переменную bool,
                Book_EdBooks.isRedact = false;      // отвечающую за редактирование формы
        }
        #endregion
        #region Событие загрузки формы
        private void Book_EdBooks_SubFormAddUpdate_Load(object sender, EventArgs e)
        {
            #region Загрузка списка дисциплин для combobox'a
            // SQL-команда для отображения дисциплин в списке
            string sql = "SELECT disciplines.name_ofdiscipline AS \"Наименования учебных дисциплин\" FROM disciplines ORDER BY disciplines.name_ofdiscipline";
            // Создаём в DataSet список дисциплин, которые будут отображаться в ComboBox
            SQL.clSQL.TableFill("disciplines", sql);

            // Заполняем наш ComboBox информацией из DataSet disciplinesToEdBook
            for (int i = 0; i < SQL.clSQL.ds.Tables["disciplines"].Rows.Count; i++)
            {
                comboBox_Discip.Items.Add(SQL.clSQL.ds.Tables["disciplines"].Rows[i]["Наименования учебных дисциплин"].ToString());
            }
            #endregion
            #region Изменение полей и формы при редактировании пособия
            if (Book_EdBooks.isRedact == true)
            {
                textBox_ID.ReadOnly = true;                     // Запрещяем изменять ID пособия
                this.Text = "Редактирование учебного пособия";  // Заменяем текст формы для режима редактирования
                button_AddRedact.Text = "Принять изменения";    // Заменяем текст кнопки для режима редактирования

                textBox_ID.BackColor = Color.LightGray;

                #region Заполнение полей редактирования из DataSet
                textBox_ID.Text = SQL.clSQL.ds.Tables["edbooks"].Rows[Book_EdBooks.index]["ID"].ToString();                         // Загрузка ID пособия
                textBox_Name.Text = SQL.clSQL.ds.Tables["edbooks"].Rows[Book_EdBooks.index]["Название пособия"].ToString();         // Загрузка названия пособия
                comboBox_Discip.Text = SQL.clSQL.ds.Tables["edbooks"].Rows[Book_EdBooks.index]["Учебная дисциплина"].ToString();    // Загрузка учебной дисциплины
                textBox_firstname.Text = SQL.clSQL.ds.Tables["edbooks"].Rows[Book_EdBooks.index]["Имя автора"].ToString();          // Загрузка имени автора
                textBox_secondname.Text = SQL.clSQL.ds.Tables["edbooks"].Rows[Book_EdBooks.index]["Фамилия автора"].ToString();     // Загрузка фамилии автора
                textBox_thirdname.Text = SQL.clSQL.ds.Tables["edbooks"].Rows[Book_EdBooks.index]["Отчество автора"].ToString();     // Загрузка отчества автора
                #endregion
            }
            #endregion
            #region Загрузка свободных разделов
            // sql-команда заполнения DataGridView'а свободных разделов
            sql = "SELECT chapters.id_ofchapter AS \"ID\", chapters.numberofchapter AS \"Номер\", " +
                "chapters.nameofchapter AS \"Название\" " +
                "FROM chapters WHERE chapters.id_edbook IS NULL " +
                "ORDER BY chapters.numberofchapter";

            // Создаём table свободных разделов
            SQL.clSQL.TableFill("freeChapters", sql);
            // Заполняем DGV table'ом свободных разделов
            dataGridView_Free.DataSource = SQL.clSQL.ds.Tables["freeChapters"];

            // Метод, запрещающий изменения DataGridView
            Styles.DGVdefaultSettings.FormationDGV(dataGridView_Free);

            // Убираем выделение какой либо ячейки в DataGridView
            dataGridView_Free.CurrentCell = null;

            // Ресайз DataGridView исходя из содержмиого столбцов
            dataGridView_Free.AutoResizeColumns();
            #endregion
            #region Загрузка занятых разделов этого пособия
            if (Book_EdBooks.isRedact == true)  // SQL-команда будет зависить от того, создаём мы новое пособие или же редактируем существующее
            {
                // sql-команда заполнения DataGridView'а свободных разделов
                sql = "SELECT chapters.id_ofchapter AS \"ID\", chapters.numberofchapter AS \"Номер\", " +
                        "chapters.nameofchapter AS \"Название\" " +
                        "FROM chapters WHERE chapters.id_edbook = " + textBox_ID.Text + " ORDER BY chapters.numberofchapter";
            }
            else
            {

                // sql-команда заполнения DataGridView'а свободных разделов
                sql = "SELECT chapters.id_ofchapter AS \"ID\", chapters.numberofchapter AS \"Номер\", " +
                        "chapters.nameofchapter AS \"Название\" " +
                        "FROM chapters WHERE chapters.id_edbook = " + (-10) + " ORDER BY chapters.numberofchapter";
            }

            // Создаём table занятых разделов
            SQL.clSQL.TableFill("takenChapters", sql);
            // Заполняем DGV table'ом свободных разделов
            dataGridView_Taken.DataSource = SQL.clSQL.ds.Tables["takenChapters"];

            // Метод, запрещающий изменения DataGridView
            Styles.DGVdefaultSettings.FormationDGV(dataGridView_Taken);

            // Убираем выделение какой либо ячейки в DataGridView
            dataGridView_Free.CurrentCell = null;

            // Ресайз DataGridView исходя из содержмиого столбцов
            dataGridView_Free.AutoResizeColumns();
            #endregion
        }
        #endregion
        #region Кнопка добавления и редактирование пособия
        private void button_AddRedact_Click(object sender, EventArgs e)
        {
            int ID;         // Поле, хранящее в себе ID пособия
            string sql;     // Поле для SQL-команд
            #region Проверки полей
            try
            {
                // Поле с ID пособия
                ID = Convert.ToInt32(textBox_ID.Text);
                // Проверка корректности содержимого полей:
                if (textBox_Name.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить поле «Название пособия».", Book_EdBooks.AddCaptionError);
                    return;
                }
                if (comboBox_Discip.Text == "")
                {
                    MessageBox.Show("Вы должны указать учебную дисциплину, которой будет принадлежать данное учебное пособие.", Book_EdBooks.AddCaptionError);
                    return;
                }
                if (textBox_firstname.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить поле «Имя».", Book_EdBooks.AddCaptionError);
                    return;
                }
                if (textBox_secondname.Text == "")
                {
                    MessageBox.Show("Вы должны заполнить поле «Фамилия».", Book_EdBooks.AddCaptionError);
                    return;
                }
                if (textBox_thirdname.Text == "")
                {
                    textBox_thirdname.Text = null;
                }
            }
            catch (ArgumentOutOfRangeException) // Проверка выхода ID пособия за пределы переменной int
            {
                MessageBox.Show("ID пособия не может быть больше значения " + int.MaxValue + ".", Book_EdBooks.AddCaptionError);
                return;
            }
            catch (FormatException)            // Проверка на корректность формата в поле ID пособия
            {
                MessageBox.Show("«ID пособия» является пустым полем, либо же его формат некорректен. Значение данного поля может являться только целочисленным положительным значением.", Book_EdBooks.AddCaptionError);
                return;
            }
            // Проверки на соответствие длинн переменных string с базой данных:
            if (textBox_Name.Text.Length > 128)
            {
                MessageBox.Show("Название пособия слишком длинное. Максимальная длина данного поля - 128 символов", Book_EdBooks.AddCaptionError);
                return;
            }
            if (textBox_firstname.Text.Length > 36)
            {
                MessageBox.Show("Имя автора слишком длинное. Максимальная длина данного поля - 36 символов", Book_EdBooks.AddCaptionError);
                return;
            }
            if (textBox_secondname.Text.Length > 52)
            {
                MessageBox.Show("Фамилия автора слишком длинная. Максимальная длина данного поля - 52 символа", Book_EdBooks.AddCaptionError);
                return;
            }
            if (textBox_thirdname.Text.Length > 48)
            {
                MessageBox.Show("Отчество автора слишком длинное. Максимальная длина данного поля - 48 символов", Book_EdBooks.AddCaptionError);
                return;
            }

            // Запрещаем указывать в ID пособия отрицательные значения
            if (ID < 0)
            {
                MessageBox.Show("ID пособия может являться только целочисленным положительным значением.", Book_EdBooks.AddCaptionError);
                return;
            }
            #endregion
            if (Book_EdBooks.isRedact == true)
            {
                #region Редактирование существующего пособия
                // SQL-команда обновления
                sql = "UPDATE edbooks SET name_ofedbook = '" + textBox_Name.Text + "', name_ofdiscipline = '"
                    + comboBox_Discip.Text + "', author_firstname = '" + textBox_firstname.Text + "', author_secondname = '"
                    + textBox_secondname.Text + "', author_thirdname = '" + textBox_thirdname.Text + "' WHERE ID_edbook = " + ID;
                #endregion
            }
            else
            {
                #region Создание нового пособия
                // SQL-команда для добавления нового учебного пособия в базу данных
                sql = "INSERT INTO edbooks (ID_edbook, name_ofedbook, name_ofdiscipline, author_firstname, author_secondname, author_thirdname) values(" + ID
                    + ", '" + textBox_Name.Text + "', '" + comboBox_Discip.Text + "', '" + textBox_firstname.Text + "', '"
                    + textBox_secondname.Text + "', '" + textBox_thirdname.Text + "')";
                #endregion
            }
            #region Добавление в БД и проверка на ошибки
            if (!SQL.clSQL.Modification_Execute(sql))
            {
                MessageBox.Show("Указанный вами ID учебного пособия либо уже занят, " +
                    "либо же поля пособия заполнены некорректно", Book_EdBooks.AddCaptionError);
                return;
            }
            #endregion
            #region Изменение информации в dataSet
            if (Book_EdBooks.isRedact == true)
            {
                // Добавляем только что созданное учебное пособие в dataSet
                SQL.clSQL.ds.Tables["edbooks"].Rows[Book_EdBooks.index].ItemArray = new object[]
                { ID, textBox_Name.Text, comboBox_Discip.Text, textBox_firstname.Text, textBox_secondname.Text, textBox_thirdname.Text };

                CheckDGV();
            }
            else
            {
                // Добавляем только что созданное учебное пособие в dataSet
                SQL.clSQL.ds.Tables["edbooks"].Rows.Add(new object[] { ID, textBox_Name.Text,
                    comboBox_Discip.Text, textBox_firstname.Text, textBox_secondname.Text, textBox_thirdname.Text });

                CheckDGV();
            }
            #endregion

            this.Close(); // Закрытие формы добавления
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

                SQL.clSQL.ds.Tables["takenChapters"].Rows.Add(new object[]
                {
                    SQL.clSQL.ds.Tables["freeChapters"].Rows[indexSubDgv]["ID"],
                    SQL.clSQL.ds.Tables["freeChapters"].Rows[indexSubDgv]["Номер"],
                    SQL.clSQL.ds.Tables["freeChapters"].Rows[indexSubDgv]["Название"]
                });
                SQL.clSQL.ds.Tables["freeChapters"].Rows.RemoveAt(indexSubDgv);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Раздел для перемещения указан неорректно.", "Ошибка перемещения разделов");
                return;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Раздел для перемещения указан неорректно.", "Ошибка перемещения разделов");
                return;
            }
        }

        private void iconButton_ArrowLeft_Click(object sender, EventArgs e)
        {
            try
            {
                indexSubDgv = dataGridView_Taken.CurrentCell.RowIndex;

                SQL.clSQL.ds.Tables["freeChapters"].Rows.Add(new object[]
                {
                    SQL.clSQL.ds.Tables["takenChapters"].Rows[indexSubDgv]["ID"],
                    SQL.clSQL.ds.Tables["takenChapters"].Rows[indexSubDgv]["Номер"],
                    SQL.clSQL.ds.Tables["takenChapters"].Rows[indexSubDgv]["Название"]
                });
                SQL.clSQL.ds.Tables["takenChapters"].Rows.RemoveAt(indexSubDgv);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Раздел для перемещения указан неорректно.", "Ошибка перемещения разделов");
                return;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Раздел для перемещения указан неорректно.", "Ошибка перемещения разделов");
                return;
            }
        }
        #endregion
        #region Методы присваивания дополнительных элементов Dataset
        private void CheckDGV()
        {
            for (int i = 0; i < SQL.clSQL.ds.Tables["freeChapters"].Rows.Count; i++)
            {
                string sql = "UPDATE chapters SET id_edbook = null WHERE id_ofchapter = " + SQL.clSQL.ds.Tables["freeChapters"].Rows[i]["ID"];
                SQL.clSQL.Modification_Execute(sql);
            }

            for (int i = 0; i < SQL.clSQL.ds.Tables["takenChapters"].Rows.Count; i++)
            {
                string sql = "UPDATE chapters SET id_edbook = " + textBox_ID.Text  + " WHERE id_ofchapter = " + SQL.clSQL.ds.Tables["takenChapters"].Rows[i]["ID"];
                SQL.clSQL.Modification_Execute(sql);
            }
        }
        #endregion
    }
}
