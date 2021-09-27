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
        
        //private DetalleVenta objDetalle;
        public formNuevaVenta(Venta objVenta = null)
        {
            InitializeComponent();
            obj = objVenta;
            CargarCMB();
            
        }
        DetalleVenta objDetalle;
        private void formNuevaVenta_Load(object sender, EventArgs e)
        {
            if (obj != null)
                CargarDatosModificar(obj);
        }
        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (objDetalle.IdDetalleVenta == 0)
            {
                if (numPrecio.Value != 0 &&
                    cmbProductos.Text != "Productos..." &&
                    txtNombre.Text != "" &&
                    txtApellido.Text != "")
                {
                    DetalleVenta nuevoDetalle = new DetalleVenta(0, cmbProductos.SelectedItem as Producto, obj, (int)numPrecio.Value); ;
                    obj.DetalleList.Add(nuevoDetalle);
                    LimpiarCampos();
                }
                else
                    MessageBox.Show("Completar campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                objDetalle.Producto = cmbProductos.SelectedItem as Producto;
                objDetalle.Precio = (int)numPrecio.Value;
            }
            pnlDatosVenta.Enabled = false;
            Buscar();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            objDetalle = new DetalleVenta();
            pnlDatosVenta.Enabled = true;
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
        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            SetDatos();
            obj.Guardar();
            MessageBox.Show("Guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pnlDatosVenta.Enabled = false;
            this.Close();
        }

        #region METHODS
        private void SetDatos() {
            obj.NombreCliente = txtNombre.Text;
            obj.ApellidoCliente = txtApellido.Text;
            obj.Fecha = dtpFecha.Value;
            obj.Observaciones = txtDescripcion.Text;
            obj.Precio = (int)numPrecio.Value;
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
        private void CargarDatosModificar(Venta obj)
        {
            txtNombre.Text = obj.NombreCliente;
            txtApellido.Text = obj.ApellidoCliente;
            numPrecio.Value = (int)obj.Precio;
            dtpFecha.Value = obj.Fecha;
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = obj.DetalleList;
        }
        #endregion

    }
}
