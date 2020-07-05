using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edbook.WinForms.Forms.ReadForm
{
    public partial class ReadForm_Main : Form
    {
        // Индекс
        public int index = 0;
        #region Конструктор
        public ReadForm_Main()
        {
            InitializeComponent();
        }
        #endregion
        #region Метод заполнения формы
        private void Content_fill()
        {
            if (SQL.clSQL.ds.Tables["edbooksShow"].Rows.Count != 0)
            {
                label_nameOfEdbook.Text = SQL.clSQL.ds.Tables["edbooksShow"].Rows[index]["Название пособия"].ToString();
                label_infoOfThisBookPart.Text = SQL.clSQL.ds.Tables["edbooksShow"].Rows[index]["Номер раздела"].ToString() + "."
                    + SQL.clSQL.ds.Tables["edbooksShow"].Rows[index]["Номер темы"].ToString() + " "
                    + SQL.clSQL.ds.Tables["edbooksShow"].Rows[index]["Название раздела"].ToString() + " - "
                    + SQL.clSQL.ds.Tables["edbooksShow"].Rows[index]["Название темы"].ToString();
                textBox_ThemeContent.Text = SQL.clSQL.ds.Tables["edbooksShow"].Rows[index]["Содержимое"].ToString();
            }
            else
            {
                MessageBox.Show("Данное пособие является пустым.", "Ошибка загрузки пособия");
                this.Close();
            }
        }
        #endregion
        #region Событие загрузки формы
        private void ReadForm_Main_Load(object sender, EventArgs e)
        {
            // SQL-команда
            string sql;

            // Содержимое SQL-команды
            sql = "SELECT edbooks.id_edbook AS \"ID\", " +
                "edbooks.name_ofedbook AS \"Название пособия\", " +
                "edbooks.name_ofdiscipline AS \"Учебная дисциплина\", " +
                "edbooks.author_firstname AS \"Имя автора\", " +
                "edbooks.author_secondname AS \"Фамилия автора\", " +
                "edbooks.author_thirdname AS \"Отчество автора\", " +

                "chapters.numberofchapter AS \"Номер раздела\", " +
                "chapters.nameofchapter AS \"Название раздела\", " +

                "themes.nameoftheme AS \"Название темы\", " +
                "themes.numberoftheme AS \"Номер темы\", " +
                "themes.contentoftheme AS \"Содержимое\" " +
            
                "FROM (edbooks INNER JOIN chapters ON edbooks.id_edbook = chapters.id_edbook) " +
                "INNER JOIN themes ON chapters.id_ofchapter = themes.id_ofchapter " +
                "WHERE edbooks.id_edbook = " + SQL.clSQL.ds.Tables["RQedbooks"].Rows[Requests.Requests_Edbooks.edBookRowIndex]["ID"] +
                "ORDER BY chapters.numberofchapter asc, themes.numberoftheme asc";

            // Обновление информации об учебных пособия в таблице "RQedbooks" в DataSet в соответствии с SQL-командой
            SQL.clSQL.TableFill("edbooksShow", sql);

            // Заполняем форму
            Content_fill();
        }
        #endregion
        #region Кнопка - Назад
        private void iconButton_Left_Click(object sender, EventArgs e)
        {
            if (index != 0)
            {
                index -= 1;
                Content_fill();
            }
        }
        #endregion
        #region Кнопка - Вперёд
        private void iconButton_Right_Click(object sender, EventArgs e)
        {
            if (index < (SQL.clSQL.ds.Tables["edbooksShow"].Rows.Count - 1))
            {
                index += 1;
                Content_fill();
            }
        }
        #endregion
    }
}
