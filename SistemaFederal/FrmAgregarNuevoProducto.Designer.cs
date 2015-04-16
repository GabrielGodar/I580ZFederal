namespace SistemaFederal
{
    partial class FrmAgregarNuevoProducto
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
            this.txtCodigoDeProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreDeProducto = new System.Windows.Forms.TextBox();
            this.cbUnidadDeMedida = new System.Windows.Forms.ComboBox();
            this.numExistencia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numExistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codido del Producto";
            // 
            // txtCodigoDeProducto
            // 
            this.txtCodigoDeProducto.Location = new System.Drawing.Point(137, 28);
            this.txtCodigoDeProducto.Name = "txtCodigoDeProducto";
            this.txtCodigoDeProducto.Size = new System.Drawing.Size(88, 20);
            this.txtCodigoDeProducto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unidad de Medida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Existencia";
            // 
            // txtNombreDeProducto
            // 
            this.txtNombreDeProducto.Location = new System.Drawing.Point(137, 62);
            this.txtNombreDeProducto.Name = "txtNombreDeProducto";
            this.txtNombreDeProducto.Size = new System.Drawing.Size(179, 20);
            this.txtNombreDeProducto.TabIndex = 5;
            // 
            // cbUnidadDeMedida
            // 
            this.cbUnidadDeMedida.FormattingEnabled = true;
            this.cbUnidadDeMedida.Location = new System.Drawing.Point(137, 95);
            this.cbUnidadDeMedida.Name = "cbUnidadDeMedida";
            this.cbUnidadDeMedida.Size = new System.Drawing.Size(116, 21);
            this.cbUnidadDeMedida.TabIndex = 6;
            // 
            // numExistencia
            // 
            this.numExistencia.DecimalPlaces = 1;
            this.numExistencia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numExistencia.Location = new System.Drawing.Point(90, 136);
            this.numExistencia.Name = "numExistencia";
            this.numExistencia.Size = new System.Drawing.Size(45, 20);
            this.numExistencia.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proveedor";
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(90, 181);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(99, 21);
            this.cbProveedor.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(31, 233);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 34);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(150, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 34);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(257, 233);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 34);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmAgregarNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 284);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numExistencia);
            this.Controls.Add(this.cbUnidadDeMedida);
            this.Controls.Add(this.txtNombreDeProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoDeProducto);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarNuevoProducto";
            this.Text = "FrmAgregarNuevoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.numExistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoDeProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreDeProducto;
        private System.Windows.Forms.ComboBox cbUnidadDeMedida;
        private System.Windows.Forms.NumericUpDown numExistencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
    }
}