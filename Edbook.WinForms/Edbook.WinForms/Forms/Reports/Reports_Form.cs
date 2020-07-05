using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edbook.WinForms.Forms.Reports
{
    public partial class Reports_Form : Form
    {
        #region Конструктор
        public Reports_Form()
        {
            InitializeComponent();
        }
        #endregion
        #region Событие загрузки
        private void Reports_Form_Load(object sender, EventArgs e)
        {
            // SQL-команда
            string sql;

            // Содержимое SQL-команда
            sql = "SELECT journal.dateredact_ofjournal AS \"Дата\", " +
                "journal.fromusers_login AS \"Пользователь\", " +
                "journal.content AS \"Содержимое\" " +
                "FROM journal";

            // Обновление информации о разделах в таблице "logs" в DataSet в соответствии с SQL-командой
            SQL.clSQL.TableFill("logs", sql);

            // Отображение в DataGridView данной формы таблицы "chapters" из DataSet
            dataGridView_ofLogs.DataSource = SQL.clSQL.ds.Tables["logs"];

            // Метод, запрещающий изменения DataGridView
            Styles.DGVdefaultSettings.FormationDGV(dataGridView_ofLogs);

            // Убираем выделение какой либо ячейки в DataGridView
            dataGridView_ofLogs.CurrentCell = null;

            // Ресайз DataGridView исходя из содержмиого столбцов
            dataGridView_ofLogs.AutoResizeColumns();
        }
        #endregion
        #region Событие удаления
        private void iconButton_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView_ofLogs.CurrentRow.Index;
                if (index != -1)
                {
                    // Сообщение об удалении записи - начало
                    string message = "Вы точно хотите удалить запись за " + dataGridView_ofLogs.Rows[index].Cells["Дата"].Value;
                    string caption = "Удаление записи";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult MsgBoxResult = MessageBox.Show(message, caption, buttons);
                    if (MsgBoxResult == DialogResult.No)
                    {
                        return;
                    }
                    // Сообщение об удалении записи - конец
                    
                    // SQL-команда на удаление раздела
                    string sql = "DELETE FROM journal WHERE journal.dateredact_ofjournal = '" + dataGridView_ofLogs.Rows[index].Cells["Дата"].Value + "' and journal.fromusers_login = '" + currentUser.username + "'";
                    SQL.clSQL.Modification_Execute(sql);                                        // Отправляем команду на удаление
                    SQL.clSQL.ds.Tables["journal"].Rows.RemoveAt(index);                        // Удаляем строку с разделом из DataSet (тем самым и из DataGridView)
                    
                    dataGridView_ofLogs.CurrentCell = null;                                     // Сбрасываем CurrentCell
                    index = -1;                                                                 // Сбрасываем значение индекса
                }
                else
                {
                    MessageBox.Show("Запись для удаления указана некорректно.", "Ошибка удаления записи");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Запись для удаления указана некорректно.", "Ошибка удаления записи");
            }
        }
        #endregion
    }
}
