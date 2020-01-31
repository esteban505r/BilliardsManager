using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardsManager
{
    public partial class OpcionesDialog : Form
    {
        public Producto producto { get; set; }
        public Mesa mesa { get; set; }
        public OpcionesDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
            AgregarProductoDialog dialog = new AgregarProductoDialog();
            dialog.ShowDialog();
            this.producto = dialog.producto;
            
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
    }
}
