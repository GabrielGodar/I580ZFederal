using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFederal
{
    public partial class FrmInventario : Form
    {
        FrmAgregarNuevoProducto AgregarNuevoProducto;
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarNuevoProducto=new FrmAgregarNuevoProducto();
            AgregarNuevoProducto.Text="Agregar un Nuevo Producto";
            AgregarNuevoProducto.ShowDialog();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            AgregarNuevoProducto.Text = "Modificar Producto";
            
            AgregarNuevoProducto.ShowDialog();
            
        }
    }
}
