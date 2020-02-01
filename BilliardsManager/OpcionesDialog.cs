using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BilliardsManager
{
    public partial class OpcionesDialog : Form
    {
        public List<Producto> productos { get; set; }
        public Mesa mesa { get; set; }
        public OpcionesDialog()
        {
            InitializeComponent();
            productos = new List<Producto>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
            AgregarProductoDialog dialog = new AgregarProductoDialog();
            dialog.ShowDialog();
            this.productos.AddRange(dialog.productos);
            dialog.productos = new List<Producto>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerProductosForm ver = new VerProductosForm(mesa.productos);
            ver.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mesa.exit = true;
            Dispose();
        }
    }
}
