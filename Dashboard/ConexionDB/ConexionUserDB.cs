using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Model;
using System.Data;
namespace Dashboard.ConexionDB
{
    internal class ConexionUserDB
    {
        public static MySqlConnection GetConnection()
        {
            string mysql = "datasource=localhost;port=3306;username=root;password=;database=libsystem";
            MySqlConnection conn = new MySqlConnection(mysql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Conexión fallida\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
            return conn;
        }
        public static List <Model.User> DataTableUsers()
        {
            List<User> user = new List<User> ();
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    string queryDB = "select person.id_person,birth_date, identification, name, lastName, secondName, telephone," +
                        " email, password, user.id_user " +
                        "from person inner join user on person.id_person = user.id_user";
                    using(MySqlCommand cmd = new MySqlCommand(queryDB, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User users = new User(
                                    reader.GetInt32("id_person"),
                                    reader.GetDateTime("birth_date"),
                                    reader.GetString("identification"),
                                    reader.GetString("name"),
                                    reader.GetString("lastName"),
                                    reader.GetString("secondName"),
                                    reader.GetInt32("telephone"),
                                    reader.GetInt32("id_user"),
                                    reader.GetString("email"),
                                    reader.GetString("password")
                                    );
                                user.Add(users);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos de la tabla 'book'\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return user;
        }
    }
}
