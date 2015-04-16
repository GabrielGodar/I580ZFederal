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
    public partial class FrmAgregarNuevoEmpleado : Form
    {
        FrmPrincipal Principal = new FrmPrincipal();
        public FrmAgregarNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void txtNombresDeEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=Principal.AceptarSoloLetras(sender, e);
        }

        private void txtApellidosDeEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Principal.AceptarSoloLetras(sender, e); //llamar funcion que solo permite letras al formulario Principal
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
