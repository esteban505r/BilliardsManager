using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BilliardsManager
{
    public partial class ProductosForm : Form
    {

        public List<Producto> productos { get; set; }
        public List<Producto> productosAMostrar { get; set; }
        public ProductosForm(String tipo)
        {
            Conector c = new Conector();
            InitializeComponent();
            this.productos = new List<Producto>();
            this.productosAMostrar = new List<Producto>();
            List<Producto> productosDB = c.getProductos();

            for(int i = 0; i < productosDB.Count(); i++)
            {
                if (productosDB[i].getType().Equals(tipo))
                {
                    productosAMostrar.Add(productosDB[i]);
                }
            }

            this.tableLayoutPanel1.RowStyles.RemoveAt(0);

            for (int i = 0; i < productosAMostrar.Count(); i++)
            {
                ProductoButton boton = new ProductoButton(productosAMostrar[i]);
                boton.Text = productosAMostrar[i].getName() + " $"+productosAMostrar[i].getPrecio().ToString();
                boton.Font = new Font("Microsoft Sans Serif", 20.25F);
                boton.Dock = DockStyle.Top;
                boton.MinimumSize = new Size(200, 150);
                this.tableLayoutPanel1.Controls.Add(boton, 1,i);
                
                boton.Click += new EventHandler(delegate (Object o, EventArgs a) {
                    productos.Add(boton.producto);
                    Dispose();
                });


            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
