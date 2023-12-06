using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace Dashboard
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }


        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConexionDB.ConexionDB.GetConnection();


            string email, password;
            email = txtEmail.Text;
            password = txtPassword.Text;

            string sql = "select email, password from user where email = '" + email + "' AND password = '" + password + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 v = new Form1();
                v.Show();
                this.Hide();
                v.SetEmail(txtEmail.Text);
            }
            else
            {
                MessageBox.Show("Usuario no existe ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
