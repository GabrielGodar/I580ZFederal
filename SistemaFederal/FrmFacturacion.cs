using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaFederal
{
    public partial class FrmFacturacion : Form
    {
        public SqlConnection oconexion;
        public SqlCommand oComand;
        //public SqlDataReader oLector;
        public SqlDataAdapter oAdaptador;
        public DataSet dataset;
        
        
        public FrmFacturacion()
        {
            InitializeComponent();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            this.oconexion = new SqlConnection();
            this.oconexion.ConnectionString = "Data Source=UNDERTAKER;Initial Catalog=IngenieriaDelSoftwareFinal;Integrated Security=true";
            this.oconexion.Open();
            this.oAdaptador = new SqlDataAdapter("SELECT * from FACTURA_VENTA",oconexion );
            this.dataset = new DataSet();
            this.oAdaptador.Fill(dataset, "FACTURA_VENTA");
            this.oconexion.Close();            

            generarFactura();
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

        private void generarFactura() { 
        }

        private void btnAgregarProductoAFactura_Click(object sender, EventArgs e)
        {
            lstFactura.Items.Add(txtCodigoDelProducto.Text  +" "+ txtDescripcionDelProducto.Text  );
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            DataRow fila;
            fila = dataset.Tables[0].NewRow();
            fila[0]=this.txtNumeroDeFactura .Text ;
            fila[1]=0.15;
            fila[2] = 3;
            fila[3] = 1;
            fila[4] = this.txtCodigoDelCliente .Text;
            fila[5] = 1;           
        }

       
    }
}
