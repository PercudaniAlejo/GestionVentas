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
    public partial class formPrendas : Form
    {
        private TipoPrenda obj;
        public formPrendas()
        {
            InitializeComponent();
        }
        private void formPrendas_Load(object sender, EventArgs e)
        {
            Buscar();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            obj = new TipoPrenda();
            pnlDatosPrenda.Enabled = true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPrenda.Text != "")
            {
                SetDatos();
                obj.Guardar();
                MessageBox.Show("Nueva prenda agregada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pnlDatosPrenda.Enabled = false;
                LimpiarCampos();
                Buscar();
            }
            else 
                MessageBox.Show("Completar campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            pnlDatosPrenda.Enabled = false;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            pnlDatosPrenda.Enabled = false;
            try
            {
                if (dgvPrendas.CurrentRow != null)
                {
                    TipoPrenda prenda = dgvPrendas.CurrentRow.DataBoundItem as TipoPrenda;
                    if ((MessageBox.Show("Eliminar la prenda: " + prenda.Tipo, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        prenda.Eliminar();
                        MessageBox.Show("La prenda '" + prenda.Tipo + "' fue eliminada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Buscar();
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("", "Elimine todos los productos relacionados a esta prenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region METHODS
        private void SetDatos() {
            obj.Tipo = txtPrenda.Text;
        }
        private void LimpiarCampos() {
            txtPrenda.Text = "";
        }
        private void Buscar() {
            dgvPrendas.DataSource = TipoPrenda.Buscar(txtPrenda.Text);
        }
        #endregion

        private void lblPrenda_Click(object sender, EventArgs e)
        {

        }
    }
}
