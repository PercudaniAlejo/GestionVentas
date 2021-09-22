using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace UI
{
    public partial class formDetalleVenta : Form
    {
        private Venta objV;
        private DetalleVenta objDetalle;
        public formDetalleVenta(Venta objVenta = null)
        {
            InitializeComponent();
            objV = objVenta;
            objDetalle = new DetalleVenta();
        }

        private void formDetalleVenta_Load(object sender, EventArgs e)
        {
            Buscar();
            txtNombre.Text = objV.NombreCliente;
            txtApellido.Text = objV.ApellidoCliente;

            numPrecioUnitario.Value = (int)objV.Producto.Precio;
            cmbPrenda.Text = objV.Producto.Tipo.ToString();
            cmbColor.Text = objV.Producto.ColorName.ToString();

            dtpFecha.Value = objV.Fecha;
            numPrecioFinal.Value = (int)objV.Precio;
            txtDescVenta.Text = objV.Observaciones;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region METHODS
        private void Buscar(){
            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = DetalleVenta.Buscar("");
        }

        private void SetDatos() {
            objDetalle.Producto = objV.Producto;
        }
        #endregion
    }
}
