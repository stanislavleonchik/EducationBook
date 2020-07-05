using System;
using System.Windows.Forms;

namespace Edbook.WinForms.Forms.Requests
{
    public partial class Requests_Edbooks : Form
    {
        public static int edBookRowIndex;
        #region Конструктор формы
        public Requests_Edbooks()
        {
            InitializeComponent();
        }
        #endregion
        #region Событие загрузки формы
        private void Requests_Edbooks_Load(object sender, EventArgs e)
        {
            // SQL-команда
            string sql;

            // Содержимое SQL-команды
            sql = "SELECT edbooks.id_edbook AS \"ID\", " +
            "edbooks.name_ofedbook AS \"Название пособия\", " +
            "edbooks.name_ofdiscipline AS \"Учебная дисциплина\", " +
            "edbooks.author_firstname AS \"Имя автора\", " +
            "edbooks.author_secondname AS \"Фамилия автора\", " +
            "edbooks.author_thirdname AS \"Отчество автора\" " +
            "FROM edbooks ORDER BY edbooks.id_edbook";


            // Обновление информации об учебных пособия в таблице "RQedbooks" в DataSet в соответствии с SQL-командой
            SQL.clSQL.TableFill("RQedbooks", sql);

            // Отображение в DataGridView данной формы таблицы "RQedbooks" из DataSet
            dataGridView_ofBooksRQ.DataSource = SQL.clSQL.ds.Tables["RQedbooks"];

            // Скрываем лишнее
            /*
            dataGridView_ofBooksRQ.Columns[6].Visible = false;
            dataGridView_ofBooksRQ.Columns[7].Visible = false;
            dataGridView_ofBooksRQ.Columns[8].Visible = false;
            dataGridView_ofBooksRQ.Columns[9].Visible = false;
            dataGridView_ofBooksRQ.Columns[10].Visible = false;
            */

            // Метод, запрещающий изменения DataGridView
            Styles.DGVdefaultSettings.FormationDGV(dataGridView_ofBooksRQ);

            // Убираем выделение какой либо ячейки в DataGridView
            dataGridView_ofBooksRQ.CurrentCell = null;

            // Ресайз DataGridView исходя из содержмиого столбцов
            dataGridView_ofBooksRQ.AutoResizeColumns();
            #region Загрузка списка дисциплин для combobox'a
            // SQL-команда для отображения дисциплин в списке
            sql = "SELECT disciplines.name_ofdiscipline AS \"Наименования учебных дисциплин\" FROM disciplines ORDER BY disciplines.name_ofdiscipline";
            // Создаём в DataSet список дисциплин, которые будут отображаться в ComboBox
            SQL.clSQL.TableFill("disciplines", sql);

            // Заполняем наш ComboBox информацией из DataSet disciplinesToEdBook
            for (int i = 0; i < SQL.clSQL.ds.Tables["disciplines"].Rows.Count; i++)
            {
                comboBox_ofDiscips.Items.Add(SQL.clSQL.ds.Tables["disciplines"].Rows[i]["Наименования учебных дисциплин"].ToString());
            }
            #endregion
        }
        #endregion
        #region Поиск по имени автора
        private void radioButton_byName_CheckedChanged(object sender, EventArgs e)
        {
            SQL.clSQL.ds.Tables["RQedbooks"].DefaultView.RowFilter = "[Название пособия] = '" + textBox_byName.Text + "'";
            dataGridView_ofBooksRQ.CurrentCell = null;
        }
        #endregion
        #region Поиск по фамилии автора
        private void radioButton_byAuth_CheckedChanged(object sender, EventArgs e)
        {
            SQL.clSQL.ds.Tables["RQedbooks"].DefaultView.RowFilter = "[Фамилия автора] = '" + textBox_byAuth.Text + "'";
            dataGridView_ofBooksRQ.CurrentCell = null;
        }
        #endregion
        #region Поиск по дисциплине
        private void radioButton_byDiscip_CheckedChanged(object sender, EventArgs e)
        {
            SQL.clSQL.ds.Tables["RQedbooks"].DefaultView.RowFilter = "[Учебная дисциплина] = '" + comboBox_ofDiscips.Text + "'";
            dataGridView_ofBooksRQ.CurrentCell = null;
        }
        #endregion
        #region Все пособия
        private void radioButton_allEdbooks_CheckedChanged(object sender, EventArgs e)
        {
            SQL.clSQL.ds.Tables["RQedbooks"].DefaultView.RowFilter = "";
            dataGridView_ofBooksRQ.CurrentCell = null;
        }
        #endregion
        #region Событие кнопки открытия
        private void button_Open_Click(object sender, EventArgs e)
        {
            try
            {
                edBookRowIndex = dataGridView_ofBooksRQ.CurrentRow.Index;   // Передаем индекс текущей выдленной строки
                DateTime currentDT = DateTime.Now;

                // Заполняем журнал
                string sql = "INSERT INTO journal (dateredact_ofjournal, fromusers_login, content) values('" + currentDT + "','" + currentUser.username + "', '" + "Открыл пособие" + SQL.clSQL.ds.Tables["RQedbooks"].Rows[edBookRowIndex]["Название пособия"].ToString() + "')";
                SQL.clSQL.Modification_Execute(sql);

                Form ReadFormOpen = new ReadForm.ReadForm_Main();           // Открытие формы для чтения пособия
                ReadFormOpen.Show();                                        // Отображение формы для чтения пособия

                dataGridView_ofBooksRQ.CurrentCell = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Пособие для открытия указано некорректно", "Ошибка открытия пособия");
                return;
            }
        }
        #endregion
    }
}
