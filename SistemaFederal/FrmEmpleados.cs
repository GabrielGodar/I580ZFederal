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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevoEmpleado AgregarEmpleado = new FrmAgregarNuevoEmpleado();
            AgregarEmpleado.Text = "Agregar Empleado";
            AgregarEmpleado.ShowDialog();

        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevoEmpleado ModificarEmpleado = new FrmAgregarNuevoEmpleado();  //Se usa el mismo formulario de agragar nuevo empleado para modifcar
            ModificarEmpleado.Text = "Modificar Empleado";
            ModificarEmpleado.ShowDialog();
        }
    }
}
