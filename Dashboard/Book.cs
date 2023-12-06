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

    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
            CargarDatosEnDataGridView();
        }
        private void CargarDatosEnDataGridView()
        {
            try
            {
                List<Dashboard.Model.Books> datosTablaBook = ConexionBook.DataTableBooks();

                tableBooks.AutoGenerateColumns = false;
                tableBooks.DataSource = datosTablaBook;
                tableBooks.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en la Tabla.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Search(object sender, EventArgs e)
        {

        }
    }
}
