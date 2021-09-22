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
    public partial class formVentas : Form
    {
        private Venta obj;
        public formVentas()
        {
            InitializeComponent();
        }
        private void formVentas_Load(object sender, EventArgs e)
        {
            CargarCMB();
            LimpiarCampos();
            Buscar();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            obj = new Venta();
            pnlDatosVenta.Enabled = true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Productos f = new Productos();
            f.ShowDialog();
            CargarCMB();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            pnlDatosVenta.Enabled = false;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (numPrecio.Value != 0 &&
                cmbProductos.Text != "Productos..." &&
                txtNombre.Text != "" &&
                txtApellido.Text != "")
            {
                SetDatos();
                obj.Guardar();
                MessageBox.Show("Nueva venta agregada correctamente.", "Venta registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlDatosVenta.Enabled = false;
                LimpiarCampos();
                Buscar();
            }
            else
                MessageBox.Show("Completar campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pnlDatosVenta.Enabled = false;
            LimpiarCampos();
            try
            {
                if (dgvVentas.CurrentRow != null)
                {
                    Venta v = Venta.BuscarPorId((int)dgvVentas.CurrentRow.Cells["ID"].Value);
                    if (MessageBox.Show("Eliminar la venta con ID: " + v.IdVenta, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        v.Eliminar();
                        MessageBox.Show("Venta eliminada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Buscar();
                    }
                }
                else
                    MessageBox.Show("Debe seleccionar una fila antes de eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVentas.CurrentRow != null)
                {
                    obj = Venta.BuscarPorId((int)dgvVentas.CurrentRow.Cells["ID"].Value);
                    SetDatosModificar();
                    pnlDatosVenta.Enabled = true;
                }
                else
                    MessageBox.Show("Debe seleccionar una fila antes de modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region METHODS
        private void LimpiarCampos() {
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFecha.Value = DateTime.Now;
            cmbProductos.Text = "Productos...";
            numPrecio.Value = 0;
            txtDescripcion.Text = "";
        }
        private void CargarCMB() {
            cmbProductos.DataSource = null;
            cmbProductos.DataSource = Producto.Buscar(); ;
        }
        private void SetDatos() {
            obj.ApellidoCliente = txtApellido.Text;
            obj.NombreCliente = txtNombre.Text;
            obj.Producto = cmbProductos.SelectedItem as Producto;
            obj.Fecha = dtpFecha.Value;
            obj.Precio = (int)numPrecio.Value;
            obj.Observaciones = txtDescripcion.Text;
        }
        private void Buscar() {
            dgvVentas.DataSource = Venta.BuscarIQ(txtBuscar.Text);
        }
        private void SetDatosModificar() {
            numPrecio.Value = (decimal)obj.Precio;
            if (obj.Producto != null)
                cmbProductos.Text = obj.Producto.ToString();
            txtDescripcion.Text = obj.Observaciones;
            txtNombre.Text = obj.NombreCliente;
            txtApellido.Text = obj.ApellidoCliente;
            dtpFecha.Value = obj.Fecha;
        }
        #endregion



    }
}
