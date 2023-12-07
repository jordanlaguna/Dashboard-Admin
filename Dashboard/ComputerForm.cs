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
    public partial class ComputerForm : Form
    {
        public ComputerForm()
        {
            InitializeComponent();
            LoadDataInTableLaptop();
        }
        private void LoadDataInTableLaptop()
        {
            try
            {
                List<Dashboard.Model.Laptop> loadDataList = ConexionLaptopDB.DataTableLaptop();
                tableLaptops.AutoGenerateColumns = false;
                tableLaptops.DataSource = loadDataList;
                tableLaptops.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en la Tabla.\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
