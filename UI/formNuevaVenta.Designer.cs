
namespace UI
{
    partial class formNuevaVenta
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
            this.pnlDatosVenta = new System.Windows.Forms.Panel();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.Precio = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCargarVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlDatosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatosVenta
            // 
            this.pnlDatosVenta.Controls.Add(this.btnNuevoProducto);
            this.pnlDatosVenta.Controls.Add(this.label6);
            this.pnlDatosVenta.Controls.Add(this.dtpFecha);
            this.pnlDatosVenta.Controls.Add(this.label5);
            this.pnlDatosVenta.Controls.Add(this.cmbProductos);
            this.pnlDatosVenta.Controls.Add(this.label4);
            this.pnlDatosVenta.Controls.Add(this.txtApellido);
            this.pnlDatosVenta.Controls.Add(this.label2);
            this.pnlDatosVenta.Controls.Add(this.txtNombre);
            this.pnlDatosVenta.Controls.Add(this.label1);
            this.pnlDatosVenta.Controls.Add(this.btnCancelar);
            this.pnlDatosVenta.Controls.Add(this.txtDescripcion);
            this.pnlDatosVenta.Controls.Add(this.btnAgregarVenta);
            this.pnlDatosVenta.Controls.Add(this.numPrecio);
            this.pnlDatosVenta.Controls.Add(this.Precio);
            this.pnlDatosVenta.Enabled = false;
            this.pnlDatosVenta.Location = new System.Drawing.Point(-1, 46);
            this.pnlDatosVenta.Name = "pnlDatosVenta";
            this.pnlDatosVenta.Size = new System.Drawing.Size(385, 178);
            this.pnlDatosVenta.TabIndex = 25;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(145, 104);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(27, 21);
            this.btnNuevoProducto.TabIndex = 28;
            this.btnNuevoProducto.Text = "+";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(14, 150);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(125, 20);
            this.dtpFecha.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Productos";
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(14, 104);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(125, 21);
            this.cmbProductos.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Apellido del cliente";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(14, 61);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 20);
            this.txtApellido.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre del cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(14, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 20);
            this.txtNombre.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Descripcion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnCancelar.Location = new System.Drawing.Point(209, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 37);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(209, 59);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtDescripcion.Size = new System.Drawing.Size(155, 68);
            this.txtDescripcion.TabIndex = 15;
            this.txtDescripcion.Text = "";
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAgregarVenta.Location = new System.Drawing.Point(290, 133);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(74, 37);
            this.btnAgregarVenta.TabIndex = 13;
            this.btnAgregarVenta.Text = "Agregar";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(209, 18);
            this.numPrecio.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(125, 20);
            this.numPrecio.TabIndex = 8;
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(206, 0);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(37, 13);
            this.Precio.TabIndex = 7;
            this.Precio.Text = "Precio";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(-1, 224);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(385, 155);
            this.dgvVentas.TabIndex = 29;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnNuevo.Location = new System.Drawing.Point(13, 385);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(84, 37);
            this.btnNuevo.TabIndex = 30;
            this.btnNuevo.Text = "Nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCargarVenta
            // 
            this.btnCargarVenta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCargarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnCargarVenta.Location = new System.Drawing.Point(270, 385);
            this.btnCargarVenta.Name = "btnCargarVenta";
            this.btnCargarVenta.Size = new System.Drawing.Size(96, 37);
            this.btnCargarVenta.TabIndex = 29;
            this.btnCargarVenta.Text = "Cargar venta";
            this.btnCargarVenta.UseVisualStyleBackColor = true;
            this.btnCargarVenta.Click += new System.EventHandler(this.btnCargarVenta_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnCancelarVenta.Location = new System.Drawing.Point(270, 428);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(96, 37);
            this.btnCancelarVenta.TabIndex = 31;
            this.btnCancelarVenta.Text = "Cancelar venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnEliminar.Location = new System.Drawing.Point(13, 428);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 37);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "NUEVA VENTA";
            // 
            // formNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 476);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnCargarVenta);
            this.Controls.Add(this.pnlDatosVenta);
            this.Name = "formNuevaVenta";
            this.Text = "formNuevaVenta";
            this.pnlDatosVenta.ResumeLayout(false);
            this.pnlDatosVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatosVenta;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCargarVenta;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
    }
}