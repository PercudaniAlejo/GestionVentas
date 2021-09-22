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
    public partial class formInicial : Form
    {
        public formInicial()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos f = new Productos();
            f.ShowDialog();
        }
    }
}
