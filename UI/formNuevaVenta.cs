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
    public partial class formNuevaVenta : Form
    {
        private Venta obj;
        private DetalleVenta objDetalle;
        public formNuevaVenta(Venta objVenta = null)
        {
            InitializeComponent();
            obj = objVenta;
            CargarCMB();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlDatosVenta.Enabled = true;
            obj = new Venta();
        }
        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (obj.IdVenta == 0)
            {
                if (numPrecio.Value != 0 &&
                    cmbProductos.Text != "Productos..." &&
                    txtNombre.Text != "" &&
                    txtApellido.Text != "")
                {
                    Venta nv = new Venta(0, txtNombre.Text, txtApellido.Text, dtpFecha.Value,
                                         txtDescripcion.Text, (int)numPrecio.Value);
                    DetalleVenta nuevoDetalle = new DetalleVenta(0, cmbProductos.SelectedItem as Producto, nv as Venta, (int)numPrecio.Value); ;
                    obj.DetalleList.Add(nuevoDetalle);
                    pnlDatosVenta.Enabled = false;
                    LimpiarCampos();
                }
                else
                    MessageBox.Show("Completar campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SetDatos();
            }
            pnlDatosVenta.Enabled = false;
            Buscar();
        }
        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatosVenta.Enabled = false;
            LimpiarCampos();
        }

        #region METHODS
        private void SetDatos() {
            objDetalle.Venta.NombreCliente = txtNombre.Text;
            objDetalle.Venta.ApellidoCliente = txtApellido.Text;
            objDetalle.Venta.Fecha = dtpFecha.Value;
            objDetalle.Venta.Precio = (int)numPrecio.Value;
            objDetalle.Venta.Observaciones = txtDescripcion.Text;
            objDetalle.Producto = cmbProductos.SelectedItem as Producto;

        }
        private void LimpiarCampos() {
            dtpFecha.Value = DateTime.Now;
            cmbProductos.Text = "Productos...";
            numPrecio.Value = 0;
            txtDescripcion.Text = "";
        }
        private void CargarCMB() {
            cmbProductos.DataSource = null;
            cmbProductos.DataSource = cmbProductos.DataSource = Producto.Buscar();
        }
        private void Buscar() {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = obj.DetalleList;
        }
        #endregion

        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            SetDatos();
            obj.Guardar();
            MessageBox.Show("Guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pnlDatosVenta.Enabled = false;
            Buscar();
        }
    }
}
