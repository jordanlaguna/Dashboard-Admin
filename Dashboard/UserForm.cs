using Dashboard.ConexionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            LoadDataInTableUsers();
        }
        private void LoadDataInTableUsers()
        {
            try
            {
                List<Dashboard.Model.User> dataTableUser = ConexionUserDB.DataTableUsers();

                tableUsers.AutoGenerateColumns = false;
                tableUsers.DataSource = dataTableUser;
                tableUsers.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en la Tabla.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
