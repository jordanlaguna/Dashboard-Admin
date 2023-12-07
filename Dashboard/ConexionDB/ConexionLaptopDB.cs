using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Model;
namespace Dashboard.ConexionDB
{
    internal class ConexionLaptopDB
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
        public static List <Model.Laptop> DataTableLaptop()
        {
            List<Laptop> laptop = new List<Laptop>(); 
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    string queryDB = "select * from laptop";
                    using (MySqlCommand cmd = new MySqlCommand(queryDB, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Laptop laptops = new Laptop(
                                    reader.GetString("code"),
                                    reader.GetString("trademark"),
                                    reader.GetString("ubication"),
                                    reader.GetString("available")
                                    );
                                laptop.Add(laptops);  
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al obtener datos de la tabla 'book'\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return laptop;
        }
    }
}
