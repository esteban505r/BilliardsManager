using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BilliardsManager
{
    public partial class AdministrarProductosForm : Form
    {
        Conector c;
        List<Producto> lista;
        public AdministrarProductosForm()
        {
            InitializeComponent();
            c = new Conector();
            lista = c.getProductos();
            for (int i = 0; i < lista.Count(); i++)
            {
                dataGridView1.Rows.Add(lista[i].getID(), lista[i].getName(), lista[i].getPrecio(), lista[i].getType(), "Eliminar");
                dataGridView1.Rows[i].Cells["tipo"].Value = lista[i].getType();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                catch (InvalidOperationException error)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Producto> productos = new List<Producto>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row != dataGridView1.Rows[dataGridView1.Rows.Count-1]) { 
                if (!string.IsNullOrEmpty((string)row.Cells[1].Value) && !string.IsNullOrEmpty(row.Cells[3].Value.ToString()))
                {
                    try
                    {
                        if (Convert.ToInt32(row.Cells[2].Value) > 0)
                        {
                            String nombre = row.Cells[1].Value.ToString();
                            int precio = Convert.ToInt32(row.Cells[2].Value);
                            String tipo = row.Cells[3].Value.ToString();
                            Producto p = new Producto(0, nombre, precio, tipo);
                            productos.Add(p);
                        }
                        else
                        {
                            MessageBox.Show("Error, el precio debe ser un número entero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (FormatException error2)
                    {
                        MessageBox.Show("Error, el precio debe ser un número entero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, ninguna celda debe estar vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
            c.saveProductos(productos, true);
            Dispose();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
