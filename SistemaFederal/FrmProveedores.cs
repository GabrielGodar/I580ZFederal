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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevoProveedor AgregarNuevoProveedor = new FrmAgregarNuevoProveedor();
            AgregarNuevoProveedor.Text = "Nuevo Proveedor";
            AgregarNuevoProveedor.ShowDialog();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevoProveedor ModificarProveedor = new FrmAgregarNuevoProveedor();
            ModificarProveedor.Text = "Modificar Proveedor";
            ModificarProveedor.ShowDialog();
        }
    }
}
