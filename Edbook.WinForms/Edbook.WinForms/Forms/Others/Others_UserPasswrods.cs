using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Windows.Forms;

namespace Edbook.WinForms.Forms.Others
{
    public partial class Others_UserPasswrods : Form
    {
        #region Конструктор
        public Others_UserPasswrods()
        {
            InitializeComponent();

            toolTipOnPass1.SetToolTip(textBox_oldPass, "В данном поле необходимо указать действующий пароль для выбранного профиля.");
            toolTipOnPass1.SetToolTip(iconPictureBox_password, "В данном поле необходимо указать действующий пароль для выбранного профиля.");
            toolTipOnPass1.SetToolTip(panelUnderlinePassword, "В данном поле необходимо указать действующий пароль для выбранного профиля.");

            toolTipOnPass2.SetToolTip(textBox_newPass, "В данном поле необходимо указать новый пароль для выбранного профиля.");
            toolTipOnPass2.SetToolTip(iconPictureBox_newPassword, "В данном поле необходимо указать новый пароль для выбранного профиля.");
            toolTipOnPass2.SetToolTip(panelUnderLineNewPassword, "В данном поле необходимо указать новый пароль для выбранного профиля.");
        }
        #endregion
        #region Загрузка формы
        private void Others_UserPasswrods_Load(object sender, EventArgs e)
        {
            // Заполняем наш ComboBox информацией из DataSet disciplinesToEdBook
            for (int i = 0; i < SQL.clSQL.ds.Tables["usernames"].Rows.Count; i++)
            {
                comboBoxOfUsers.Items.Add(SQL.clSQL.ds.Tables["usernames"].Rows[i]["login"].ToString());
            }
            textBox_newPass.UseSystemPasswordChar = true;                 // Отображение пароля в текстовом поле в виде символов пароля
            textBox_oldPass.UseSystemPasswordChar = true;
        }
        #endregion
        #region CheckBox пароля
        private void checkBoxPasswords_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPasswords.Checked)
            {
                textBox_newPass.UseSystemPasswordChar = false;
                textBox_oldPass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_newPass.UseSystemPasswordChar = true;
                textBox_oldPass.UseSystemPasswordChar = true;
            }
        }
        #endregion
        #region Событие кнопки при смене пароля
        private void buttonRedactPass_Click(object sender, EventArgs e)
        {
            if (comboBoxOfUsers.Text != "") // Проверка на то, выбран ли пользователь
            {
                string sql; // SQL-команда
                NpgsqlCommand command;
                NpgsqlDataReader dataReader;
                SQL.clSQL.Connection.Open();

                // SQL-команда для выборки из таблицы значения и пароля пользователя, логин которого был выбран из списка
                sql = "SELECT password FROM users WHERE login = '" + comboBoxOfUsers.Text + "'";
                command = new NpgsqlCommand(sql, SQL.clSQL.Connection);     // SQL-запрос к БД на основе SQL-команды
                dataReader = command.ExecuteReader();                       // В результате выполнения SQL-запроса получаем поток строк
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                }
                else // Эта проверка существует лишь по причине моей невнимательности, в sql-запросе я забыл ссылался не на содержимое ComboBox'а, а на сам комбобокс
                     // в связи с чем не мог авторизоваться, т.к. пароли не выгружались в ДатаСет из БД.
                {
                    MessageBox.Show("В DataReader были некорректно переданы строки.", "Ошибка авторизации.");
                    return;
                }

                if (textBox_oldPass.Text == dataReader["password"].ToString())          // Проверка на совпаденеи пароля
                {

                    labelStatus.Visible = true;
                    labelStatus.ForeColor = Color.SeaGreen;
                    labelStatus.Text = "[!] Пароль указан корректно";

                    if (textBox_newPass.Text != "")
                    {
                        SQL.clSQL.Connection.Close();
                        sql = "UPDATE users SET password = '" + textBox_newPass.Text + "' WHERE login = '" + comboBoxOfUsers.Text + "'";
                        SQL.clSQL.Modification_Execute(sql);
                    }
                    else
                    {
                        labelStatus.Visible = true;
                        labelStatus.ForeColor = Color.Brown;
                        labelStatus.Text = "[!] Поле с новым паролём не заполнено";
                    }
                }
                else
                {
                    labelStatus.Visible = true;
                    labelStatus.ForeColor = Color.Brown;
                    labelStatus.Text = "[!] Пароль указан неверно";
                }
                SQL.clSQL.Connection.Close();
            }
            else
            {
                labelStatus.Visible = true;
                labelStatus.ForeColor = Color.Brown;
                labelStatus.Text = "[!] Выберите пользователя";
            }
        }
        #endregion
        #region Убираем оповещение об ошибке
        private void textBox_newPass_TextChanged(object sender, EventArgs e)
        {
            labelStatus.Visible = false;
        }

        private void textBox_oldPass_TextChanged(object sender, EventArgs e)
        {
            labelStatus.Visible = false;
        }

        private void comboBoxOfUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelStatus.Visible = false;
        }
        #endregion
    }
}
