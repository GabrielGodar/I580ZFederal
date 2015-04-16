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
    public partial class FrmFacturacion : Form
    {
        
        public FrmFacturacion()
        {
            InitializeComponent();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente BuscarCliente=new FrmBuscarCliente();
            BuscarCliente.ShowDialog();
            
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevoCliente AgregarNuevoCliente = new FrmAgregarNuevoCliente();
            AgregarNuevoCliente.Text = "Agregar Cliente";
            AgregarNuevoCliente.ShowDialog();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto BuscarProducto = new FrmBuscarProducto();
            BuscarProducto.ShowDialog();
        }
    }
}
