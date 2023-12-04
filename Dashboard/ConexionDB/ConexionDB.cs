using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.ConexionDB
{
    internal class ConexionDB
    {
        public static MySqlConnection GetConnection()
        {
            string mysql = "datasource=localhost;port=3306;username=root;password=;database=systemlib";
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
    }
}
