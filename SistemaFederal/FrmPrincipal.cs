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
    public partial class FrmPrincipal : Form
    {

        FrmInventario Inventario = new FrmInventario();
        FrmFacturacion Facturacion = new FrmFacturacion();
        FrmEmpleados Empleados = new FrmEmpleados();
        FrmClientes Clientes = new FrmClientes();
        FrmProveedores Proveedores = new FrmProveedores();
        FrmPedidos Pedidos = new FrmPedidos();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario.ShowDialog();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
           Facturacion.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores.ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Pedidos.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Validaciones de numeros y letras
        #region Validacion de Valores
        //Para validar campos solo letras
        public bool AceptarSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        public bool AceptarSoloNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            return e.Handled;
        }
        #endregion
    }

    

}
