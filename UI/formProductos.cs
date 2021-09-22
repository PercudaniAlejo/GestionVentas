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
    public partial class Productos : Form
    {
        private Producto obj;
        public Productos()
        {
            InitializeComponent();
        }
        private void Productos_Load(object sender, EventArgs e)
        {
            CargarCMB();
            LimpiarCampos();
            Buscar();
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            formColor f = new formColor();
            f.ShowDialog();
        }
        private void btnPrendas_Click(object sender, EventArgs e)
        {
            formPrendas f = new formPrendas();
            f.ShowDialog();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            obj = new Producto();
            pnlDatosProducto.Enabled = true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(numPrecio.Value != 0 && 
               cmbPrenda.Text != "Prenda..." &&
               cmbColor.Text != "Color...") { 
                SetDatos();
                obj.Guardar();
                MessageBox.Show("Nuevo producto agregado correctamente.", "Producto agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlDatosProducto.Enabled = false;
                LimpiarCampos();
                Buscar();
            }else
                MessageBox.Show("Completar campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            pnlDatosProducto.Enabled = false;
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
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow != null)
                {
                    obj = Producto.BuscarPorId((int)dgvProductos.CurrentRow.Cells["ID"].Value);
                    SetDatosModificar();
                    pnlDatosProducto.Enabled = true;
                }
                else
                    MessageBox.Show("Debe seleccionar una fila antes de modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pnlDatosProducto.Enabled = false;
            LimpiarCampos();
            try
            {
                if (dgvProductos.CurrentRow != null)
                {
                    Producto p = Producto.BuscarPorId((int)dgvProductos.CurrentRow.Cells["ID"].Value);
                    if (MessageBox.Show("Eliminar el producto con ID: " + p.IdProducto, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        p.Eliminar();
                        MessageBox.Show("Producto eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #region METHODS
        private void LimpiarCampos() {
            numPrecio.Value = 0;
            txtDescripcion.Text = "";
            cmbColor.Text = "Color...";
            cmbPrenda.Text = "Prenda...";
        }
        private void SetDatos() {
            obj.Precio = (int)numPrecio.Value;
            obj.ColorName = cmbColor.SelectedItem as ColorPrenda;
            obj.Tipo = cmbPrenda.SelectedItem as TipoPrenda;
            obj.Descipcion = txtDescripcion.Text;
        } // PENDIENTE: QUE SE LLENA EL NUMPRECIO AUTOMATICAMENTE CON EL PRECIO DEL PRODUCTO
        private void CargarCMB() {
            cmbColor.DataSource = null;
            cmbColor.DataSource = ColorPrenda.Buscar();
            cmbPrenda.DataSource = null;
            cmbPrenda.DataSource = TipoPrenda.Buscar();
        }
        private void Buscar() {
            dgvProductos.DataSource = Producto.BuscarIQ(txtBuscar.Text);
        }
        private void SetDatosModificar() {
            numPrecio.Value = (decimal)obj.Precio;
            if (obj.ColorName != null)
                cmbColor.Text = obj.ColorName.ToString();
            if (obj.Tipo != null)
                cmbPrenda.Text = obj.Tipo.ToString();
            txtDescripcion.Text = obj.Descipcion;
        }
        #endregion

    }
}
