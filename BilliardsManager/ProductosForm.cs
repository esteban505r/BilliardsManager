using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BilliardsManager
{
    public partial class ProductosForm : Form
    {

        List<Producto> productos;
        public Producto productSelected { get; set; }
        public ProductosForm(String tipo)
        {
            Conector c = new Conector();
            InitializeComponent();
            this.productos = new List<Producto>();
            List<Producto> productosDB = c.getProductos();

            for(int i = 0; i < productosDB.Count(); i++)
            {
                if (productosDB[i].getType().Equals(tipo))
                {
                    productos.Add(productosDB[i]);
                }
            }

            this.tableLayoutPanel1.RowStyles.RemoveAt(0);

            for (int i = 0; i < productos.Count(); i++)
            {
                ProductoButton boton = new ProductoButton(productos[i]);
                boton.Text = productos[i].getName() + " $"+productos[i].getPrecio().ToString();
                boton.Font = new Font("Microsoft Sans Serif", 20.25F);
                boton.Dock = DockStyle.Fill;

                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent,((float)productos.Count)/100));
                this.tableLayoutPanel1.Controls.Add(boton, 1,i);
                


                boton.Click += new EventHandler(delegate (Object o, EventArgs a) {
                    productSelected = boton.producto;
                    Dispose();
                });


            }
        }

    }
}
