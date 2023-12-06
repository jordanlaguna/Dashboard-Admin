using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Model;
namespace Dashboard.ConexionDB
{
    internal class ConexionBook
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
        public static List<Model.Books> DataTableBooks()
        {
            List<Books> books = new List<Books>();

            using (MySqlConnection conexion = GetConnection())
            {
                try
                {
                    string consulta = "select * from book";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Books book = new Books(
                                    reader.GetInt32("isbn"),
                                    reader.GetString("authorBook"),
                                    reader.GetString("title"),
                                    reader.GetString("editorial"),
                                    reader.GetString("available"),
                                    reader.GetDateTime("releaseDate")
                                );
                                books.Add(book);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos de la tabla 'book'\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return books;
        }
    }
}
