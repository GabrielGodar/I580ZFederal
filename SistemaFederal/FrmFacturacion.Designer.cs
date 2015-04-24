namespace SistemaFederal
{
    partial class FrmFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumeroDeFactura = new System.Windows.Forms.TextBox();
            this.txtCodigoDelCliente = new System.Windows.Forms.TextBox();
            this.txtNombreDelCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoDelProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcionDelProducto = new System.Windows.Forms.TextBox();
            this.numupdownCantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.btnAgregarProductoAFactura = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnFacturaCuentaPorCobrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFleteYSeguro = new System.Windows.Forms.TextBox();
            this.lstFactura = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownCantidadProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo del Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre del Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Codigo del Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripcion del Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad de Producto";
            // 
            // txtNumeroDeFactura
            // 
            this.txtNumeroDeFactura.Location = new System.Drawing.Point(133, 13);
            this.txtNumeroDeFactura.Name = "txtNumeroDeFactura";
            this.txtNumeroDeFactura.ReadOnly = true;
            this.txtNumeroDeFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDeFactura.TabIndex = 8;
            // 
            // txtCodigoDelCliente
            // 
            this.txtCodigoDelCliente.Location = new System.Drawing.Point(122, 72);
            this.txtCodigoDelCliente.Name = "txtCodigoDelCliente";
            this.txtCodigoDelCliente.Size = new System.Drawing.Size(72, 20);
            this.txtCodigoDelCliente.TabIndex = 11;
            // 
            // txtNombreDelCliente
            // 
            this.txtNombreDelCliente.Location = new System.Drawing.Point(297, 75);
            this.txtNombreDelCliente.Name = "txtNombreDelCliente";
            this.txtNombreDelCliente.Size = new System.Drawing.Size(137, 20);
            this.txtNombreDelCliente.TabIndex = 12;
            // 
            // txtCodigoDelProducto
            // 
            this.txtCodigoDelProducto.Location = new System.Drawing.Point(133, 116);
            this.txtCodigoDelProducto.Name = "txtCodigoDelProducto";
            this.txtCodigoDelProducto.Size = new System.Drawing.Size(66, 20);
            this.txtCodigoDelProducto.TabIndex = 13;
            // 
            // txtDescripcionDelProducto
            // 
            this.txtDescripcionDelProducto.Location = new System.Drawing.Point(334, 113);
            this.txtDescripcionDelProducto.Name = "txtDescripcionDelProducto";
            this.txtDescripcionDelProducto.Size = new System.Drawing.Size(135, 20);
            this.txtDescripcionDelProducto.TabIndex = 14;
            // 
            // numupdownCantidadProducto
            // 
            this.numupdownCantidadProducto.DecimalPlaces = 1;
            this.numupdownCantidadProducto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numupdownCantidadProducto.Location = new System.Drawing.Point(145, 149);
            this.numupdownCantidadProducto.Name = "numupdownCantidadProducto";
            this.numupdownCantidadProducto.Size = new System.Drawing.Size(54, 20);
            this.numupdownCantidadProducto.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio Unitario L.";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(297, 149);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(73, 20);
            this.txtPrecioUnitario.TabIndex = 17;
            // 
            // btnAgregarProductoAFactura
            // 
            this.btnAgregarProductoAFactura.Location = new System.Drawing.Point(376, 149);
            this.btnAgregarProductoAFactura.Name = "btnAgregarProductoAFactura";
            this.btnAgregarProductoAFactura.Size = new System.Drawing.Size(137, 23);
            this.btnAgregarProductoAFactura.TabIndex = 18;
            this.btnAgregarProductoAFactura.Text = "Agregar a la Factura";
            this.btnAgregarProductoAFactura.UseVisualStyleBackColor = true;
            this.btnAgregarProductoAFactura.Click += new System.EventHandler(this.btnAgregarProductoAFactura_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(475, 113);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(54, 23);
            this.btnBuscarProducto.TabIndex = 19;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(440, 73);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(54, 23);
            this.btnBuscarCliente.TabIndex = 20;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(505, 72);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(24, 23);
            this.btnNuevoCliente.TabIndex = 21;
            this.btnNuevoCliente.Text = "+";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Sub Total   L. 0.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(406, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "+ ISV L. 0.0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(373, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total a Pagar L. 0.0";
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(41, 406);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(139, 43);
            this.btnFactura.TabIndex = 25;
            this.btnFactura.Text = "Generar Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnFacturaCuentaPorCobrar
            // 
            this.btnFacturaCuentaPorCobrar.Location = new System.Drawing.Point(186, 406);
            this.btnFacturaCuentaPorCobrar.Name = "btnFacturaCuentaPorCobrar";
            this.btnFacturaCuentaPorCobrar.Size = new System.Drawing.Size(145, 43);
            this.btnFacturaCuentaPorCobrar.TabIndex = 26;
            this.btnFacturaCuentaPorCobrar.Text = "Generar Factura Cuenta por Cobrar";
            this.btnFacturaCuentaPorCobrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(338, 406);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 43);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Flete y Seguro";
            // 
            // txtFleteYSeguro
            // 
            this.txtFleteYSeguro.Location = new System.Drawing.Point(100, 42);
            this.txtFleteYSeguro.Name = "txtFleteYSeguro";
            this.txtFleteYSeguro.Size = new System.Drawing.Size(77, 20);
            this.txtFleteYSeguro.TabIndex = 31;
            // 
            // lstFactura
            // 
            this.lstFactura.FormattingEnabled = true;
            this.lstFactura.Location = new System.Drawing.Point(41, 196);
            this.lstFactura.Name = "lstFactura";
            this.lstFactura.Size = new System.Drawing.Size(393, 134);
            this.lstFactura.TabIndex = 7;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 461);
            this.Controls.Add(this.txtFleteYSeguro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFacturaCuentaPorCobrar);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnAgregarProductoAFactura);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numupdownCantidadProducto);
            this.Controls.Add(this.txtDescripcionDelProducto);
            this.Controls.Add(this.txtCodigoDelProducto);
            this.Controls.Add(this.txtNombreDelCliente);
            this.Controls.Add(this.txtCodigoDelCliente);
            this.Controls.Add(this.txtNumeroDeFactura);
            this.Controls.Add(this.lstFactura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmFacturacion";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numupdownCantidadProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroDeFactura;
        private System.Windows.Forms.TextBox txtCodigoDelCliente;
        private System.Windows.Forms.TextBox txtNombreDelCliente;
        private System.Windows.Forms.TextBox txtCodigoDelProducto;
        private System.Windows.Forms.TextBox txtDescripcionDelProducto;
        private System.Windows.Forms.NumericUpDown numupdownCantidadProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Button btnAgregarProductoAFactura;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnFacturaCuentaPorCobrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFleteYSeguro;
        private System.Windows.Forms.ListBox lstFactura;
    }
}