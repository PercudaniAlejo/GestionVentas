
namespace UI
{
    partial class formDetalleVenta
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbPrenda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescProd = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.numPrecioFinal = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescVenta = new System.Windows.Forms.RichTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "DETALLE DE LA VENTA";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(16, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(125, 20);
            this.txtNombre.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre del cliente";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(154, 76);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(95, 13);
            this.lblApe.TabIndex = 30;
            this.lblApe.Text = "Apellido del cliente";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(157, 92);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(125, 20);
            this.txtApellido.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Precio unitario";
            // 
            // numPrecioUnitario
            // 
            this.numPrecioUnitario.Enabled = false;
            this.numPrecioUnitario.Location = new System.Drawing.Point(16, 182);
            this.numPrecioUnitario.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numPrecioUnitario.Name = "numPrecioUnitario";
            this.numPrecioUnitario.ReadOnly = true;
            this.numPrecioUnitario.Size = new System.Drawing.Size(125, 20);
            this.numPrecioUnitario.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Color";
            // 
            // cmbColor
            // 
            this.cmbColor.Enabled = false;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(15, 284);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(125, 21);
            this.cmbColor.TabIndex = 37;
            // 
            // cmbPrenda
            // 
            this.cmbPrenda.Enabled = false;
            this.cmbPrenda.FormattingEnabled = true;
            this.cmbPrenda.Location = new System.Drawing.Point(16, 231);
            this.cmbPrenda.Name = "cmbPrenda";
            this.cmbPrenda.Size = new System.Drawing.Size(125, 21);
            this.cmbPrenda.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Prenda";
            // 
            // txtDescProd
            // 
            this.txtDescProd.Enabled = false;
            this.txtDescProd.Location = new System.Drawing.Point(157, 181);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.ReadOnly = true;
            this.txtDescProd.Size = new System.Drawing.Size(143, 124);
            this.txtDescProd.TabIndex = 40;
            this.txtDescProd.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.Location = new System.Drawing.Point(11, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label9.Location = new System.Drawing.Point(13, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Cliente";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(15, 378);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(124, 20);
            this.dtpFecha.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Fecha";
            // 
            // numPrecioFinal
            // 
            this.numPrecioFinal.Enabled = false;
            this.numPrecioFinal.Location = new System.Drawing.Point(16, 430);
            this.numPrecioFinal.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numPrecioFinal.Name = "numPrecioFinal";
            this.numPrecioFinal.ReadOnly = true;
            this.numPrecioFinal.Size = new System.Drawing.Size(125, 20);
            this.numPrecioFinal.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Precio final";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Descripcion";
            // 
            // txtDescVenta
            // 
            this.txtDescVenta.Enabled = false;
            this.txtDescVenta.Location = new System.Drawing.Point(157, 378);
            this.txtDescVenta.Name = "txtDescVenta";
            this.txtDescVenta.ReadOnly = true;
            this.txtDescVenta.Size = new System.Drawing.Size(143, 72);
            this.txtDescVenta.TabIndex = 48;
            this.txtDescVenta.Text = "";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(200, 480);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 32);
            this.btnAceptar.TabIndex = 50;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(324, 63);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(341, 287);
            this.dgvDetalles.TabIndex = 51;
            // 
            // formDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 538);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDescVenta);
            this.Controls.Add(this.numPrecioFinal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescProd);
            this.Controls.Add(this.cmbPrenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numPrecioUnitario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.MinimumSize = new System.Drawing.Size(708, 577);
            this.Name = "formDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.formDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPrecioUnitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbPrenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDescProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numPrecioFinal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtDescVenta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvDetalles;
    }
}