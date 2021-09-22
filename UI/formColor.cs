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
    public partial class formColor : Form
    {
        private ColorPrenda obj;
        public formColor()
        {
            InitializeComponent();
        }
        private void formColor_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            obj = new ColorPrenda();
            pnlDatosColor.Enabled = true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtColor.Text != "") { 
            SetDatos();
            obj.Guardar();
            MessageBox.Show("Nuevo color agregado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pnlDatosColor.Enabled = false;
            LimpiarCampos();
            Buscar();
            }
            else
                MessageBox.Show("Completar campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            pnlDatosColor.Enabled = false;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            pnlDatosColor.Enabled = false;
            try
            {
                if (dgvColores.CurrentRow != null)
                {
                    ColorPrenda color = dgvColores.CurrentRow.DataBoundItem as ColorPrenda;
                    if((MessageBox.Show("Eliminar el color: " + color.ColorName, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        color.Eliminar();
                        MessageBox.Show("El color " + color.ColorName + " fue eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Buscar();
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("", "Elimine todos los productos relacionados a este color", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region METHODS
        private void LimpiarCampos() {
            txtColor.Text = "";
        }

        private void SetDatos() {
            obj.ColorName = txtColor.Text;
        }

        private void Buscar() {
            dgvColores.DataSource = ColorPrenda.Buscar(txtColor.Text);
        }
        #endregion
    }
}
