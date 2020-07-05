using System.Data;   // Необходимо для работы DataSet
using Npgsql;        // Подключение PostgreSQL

namespace Edbook.WinForms.SQL
{
    class clSQL
    {
        // Подключение к Базе данных EdBook.DB
        public static NpgsqlConnection Connection =
            new NpgsqlConnection("Server=localhost; Port=5432; Username=postgres; Password=ADMIN; Database=EdBook;");

        // Объект, представляющий расположенный в памяти кэш базы данных
        public static DataSet ds = new DataSet();

        // Создание (обновление) данных в таблице DataSet с указанным названием в соответствии с SQL-командой
        public static void TableFill(string name, string sql)
        {
            if (ds.Tables[name] != null)                                    // Если таблица в DataSet уже существует,
                ds.Tables[name].Clear();                                    // очищаем таблицу от предыдущих данных
            NpgsqlDataAdapter dat;                                          // SQL-запрос на создание и обновление страницы
            dat = new NpgsqlDataAdapter(sql, Connection);                   // Создаем SQL-запрос к БД на основе SQL-команды
            dat.Fill(ds, name);                                             // Выполняем SQL-запрос, создавая (обновляя) таблицу в DataSet
            Connection.Close();                                             // Закрываем соединение с базой данных
        }

        // Добавление (обновление, удаление) данных в БД на основе SQL-команды
        public static bool Modification_Execute(string sql)
        {
            NpgsqlCommand com;                        // SQL-запрос на добавление (обновление, удаление) данных в БД
            com = new NpgsqlCommand(sql, Connection); // Создаем  SQL-запрос к БД на основе SQL-команды
            Connection.Open();                        // Устанавливаем соединение с базой данных
            try
            {
                com.ExecuteNonQuery();                // Выполняем SQL-запрос, добавляя (обновляя или удаляя) данные в БД
                Connection.Close();                   // Закрываем соединение с базой данных
                return true;
            }
            catch (NpgsqlException)
            {
                Connection.Close();
                return false;
            }
        }
    }
}