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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevoCliente AgregarNuevoCliente = new FrmAgregarNuevoCliente();
            AgregarNuevoCliente.Text = "Agregar Cliente";
            AgregarNuevoCliente.ShowDialog();
        }

        private void btnModificarModificarCliente_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevoCliente ModificarNuevoCliente = new FrmAgregarNuevoCliente();
            ModificarNuevoCliente.Text = "Modificar Cliente";
            ModificarNuevoCliente.ShowDialog();
        }
    }
}
