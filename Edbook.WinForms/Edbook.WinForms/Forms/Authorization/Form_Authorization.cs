using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Npgsql;
using System.Windows.Forms;

namespace Edbook.WinForms.Forms.Authorization
{
    public partial class Form_Authorization : Form
    {
        #region Конструктор
        public Form_Authorization()
        {
            InitializeComponent();
        }
        #endregion
        #region Событие загрузки
        private void Form_Authorization_Load(object sender, EventArgs e)
        {
            #region Загрузка имён пользователей
            // SQL-команда для выборки из таблицы Uers упорядоченных значений поля Username
            string sql = "SELECT * FROM users ORDER BY login";

            // Создаём в DataSet список имён пользователей, которые будут отображаться в ComboBox
            SQL.clSQL.TableFill("usernames", sql);

            // Заполняем наш ComboBox информацией из DataSet disciplinesToEdBook
            for (int i = 0; i < SQL.clSQL.ds.Tables["usernames"].Rows.Count; i++)
            {
                comboBoxOfUsers.Items.Add(SQL.clSQL.ds.Tables["usernames"].Rows[i]["login"].ToString());
            }
            textBoxOfPassword.UseSystemPasswordChar = true;                 // Отображение пароля в текстовом поле в виде символов пароля
            #endregion
        }
        #endregion
        #region CheckBox пароля
        private void checkBoxPasswords_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPasswords.Checked)
            {
                textBoxOfPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxOfPassword.UseSystemPasswordChar = true;
            }
        }
        #endregion
        #region Кнопка "Войти"
        private void buttonAuth_Click(object sender, EventArgs e)
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

                if (textBoxOfPassword.Text == dataReader["password"].ToString())        // Проверка на совпаденеи пароля
                {

                    labelStatus.Visible = true;
                    labelStatus.ForeColor = Color.SeaGreen;
                    labelStatus.Text = "[!] Пароль указан корректно";

                    currentUser.username = comboBoxOfUsers.Text;

                    this.Hide();                                                        // Сокрытие формы авторизации
                    SQL.clSQL.Connection.Close();                                       // Закрытие подключения
                    MainForm.EdBook_mainForm Mform = new MainForm.EdBook_mainForm();    // Задаётся новая форма (основная форма программы)
                    Mform.ShowDialog();                                                 // Отображение новой формы (основной формы программы)
                    this.Close();                                                       // Закрытие формы авторизации
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
        #region Скрытие ошибки
        private void textBoxOfPassword_TextChanged(object sender, EventArgs e)
        {
            labelStatus.Visible = false;
        }

        private void textBoxOfPassword_Click(object sender, EventArgs e)
        {
            labelStatus.Visible = false;
        }

        private void comboBoxOfUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelStatus.Visible = false;
        }

        private void comboBoxOfUsers_Click(object sender, EventArgs e)
        {
            labelStatus.Visible = false;
        }
        #endregion
    }
}
