
namespace UI
{
    partial class formPrendas
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
            this.pnlDatosPrenda = new System.Windows.Forms.Panel();
            this.lblPrenda = new System.Windows.Forms.Label();
            this.txtPrenda = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvPrendas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDatosPrenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatosPrenda
            // 
            this.pnlDatosPrenda.Controls.Add(this.lblPrenda);
            this.pnlDatosPrenda.Controls.Add(this.txtPrenda);
            this.pnlDatosPrenda.Controls.Add(this.btnCancelar);
            this.pnlDatosPrenda.Controls.Add(this.btnAceptar);
            this.pnlDatosPrenda.Enabled = false;
            this.pnlDatosPrenda.Location = new System.Drawing.Point(0, 280);
            this.pnlDatosPrenda.Name = "pnlDatosPrenda";
            this.pnlDatosPrenda.Size = new System.Drawing.Size(241, 92);
            this.pnlDatosPrenda.TabIndex = 12;
            // 
            // lblPrenda
            // 
            this.lblPrenda.AutoSize = true;
            this.lblPrenda.Location = new System.Drawing.Point(10, 0);
            this.lblPrenda.Name = "lblPrenda";
            this.lblPrenda.Size = new System.Drawing.Size(41, 13);
            this.lblPrenda.TabIndex = 9;
            this.lblPrenda.Text = "Prenda";
            this.lblPrenda.Click += new System.EventHandler(this.lblPrenda_Click);
            // 
            // txtPrenda
            // 
            this.txtPrenda.Location = new System.Drawing.Point(12, 16);
            this.txtPrenda.Name = "txtPrenda";
            this.txtPrenda.Size = new System.Drawing.Size(218, 20);
            this.txtPrenda.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Location = new System.Drawing.Point(125, 55);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 26);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAceptar.Location = new System.Drawing.Point(12, 55);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 26);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Location = new System.Drawing.Point(125, 214);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 47);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Location = new System.Drawing.Point(12, 214);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 47);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvPrendas
            // 
            this.dgvPrendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrendas.Location = new System.Drawing.Point(0, 42);
            this.dgvPrendas.Name = "dgvPrendas";
            this.dgvPrendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrendas.Size = new System.Drawing.Size(242, 155);
            this.dgvPrendas.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "PRENDAS";
            // 
            // formPrendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDatosPrenda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvPrendas);
            this.MaximumSize = new System.Drawing.Size(258, 412);
            this.MinimumSize = new System.Drawing.Size(258, 412);
            this.Name = "formPrendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prendas";
            this.Load += new System.EventHandler(this.formPrendas_Load);
            this.pnlDatosPrenda.ResumeLayout(false);
            this.pnlDatosPrenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatosPrenda;
        private System.Windows.Forms.Label lblPrenda;
        private System.Windows.Forms.TextBox txtPrenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvPrendas;
        private System.Windows.Forms.Label label1;
    }
}