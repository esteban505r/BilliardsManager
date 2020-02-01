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
    public partial class AgregarProductoDialog : Form
    {
        public List<Producto> productos { get; set; }
        public AgregarProductoDialog()
        {
            InitializeComponent();
            productos = new List<Producto>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm("bebida");
            productosForm.ShowDialog();
            productos.AddRange(productosForm.productos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm("comida");
            productosForm.ShowDialog();
            productos.AddRange(productosForm.productos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm("otro");
            productosForm.ShowDialog();
            productos.AddRange(productosForm.productos);
        }
    }
}
