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
        private DetalleVenta objDetalle;
        public formVentas()
        {
            InitializeComponent();
        }
        private void formVentas_Load(object sender, EventArgs e)
        {
            Buscar();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            obj = new Venta(); ;
            formNuevaVenta f = new formNuevaVenta(obj);
            f.ShowDialog();
            Buscar();

            obj = new Venta();
            objDetalle = new DetalleVenta();
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVentas.CurrentRow != null)
                {
                    Venta v = null;
                    v = Venta.BuscarPorId((int)dgvVentas.CurrentRow.Cells["ID"].Value);
                    if (MessageBox.Show("Eliminar la venta con ID: " + v.IdVenta, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        v.Eliminar();
                        Buscar();
                        MessageBox.Show("Venta eliminada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            obj = Seleccionado();
            obj.DetalleList = DetalleVenta.Buscar(obj.IdVenta);
            formNuevaVenta dv = new formNuevaVenta(obj);
            dv.ShowDialog();
            Buscar();
        }
        #region METHODS
        private Venta Seleccionado() {
            if (dgvVentas.CurrentRow != null)
            {
                obj = Venta.BuscarPorId((int)dgvVentas.CurrentRow.Cells["ID"].Value);
                return obj;
            }
            return null;
        }
        private void Buscar() {

            //dgvVentas.DataSource = Venta.BuscarIQ(txtBuscar.Text);
            //DT
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = Venta.BuscarDT(txtBuscar.Text);
        }
        #endregion
    }
}
