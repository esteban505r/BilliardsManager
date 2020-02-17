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
    public partial class VerProductosForm : Form
    {
        public VerProductosForm(List<Producto> productos)
        {
            InitializeComponent();


            tableLayoutPanel1.RowStyles.Clear();

            if (productos != null && productos.Count != 0)
            {
                List<int> agregados = new List<int>();
                for (int i = 0; i < productos.Count; i++)
                {
                    Boolean agregado = false;
                    for (int k = 0; k < agregados.Count; k++)
                    {
                        if (productos[i].getID() == agregados[k]) { agregado = true; }
                    }
                    if (!agregado)
                    {
                        int cantidad = 0;
                        for (int j = 0; j < productos.Count; j++)
                        {
                            if (productos[i].getID() == productos[j].getID())
                            {
                                cantidad++;
                            }
                        }
                        agregados.Add(productos[i].getID());
                        Label label = new Label();
                        label.Text = cantidad + " x " + productos[i].getName() + "  " + "$" + productos[i].getPrecio().ToString();
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.Dock = DockStyle.Top;
                        label.MinimumSize = new Size(200, 150);
                        label.Font = new Font("Microsoft Sans Serif", 20.25F);

                        this.tableLayoutPanel1.Controls.Add(label, 1, i);
                    }
                }
            }
            else
            {
                Label label = new Label();
                label.Text = "No hay productos para mostrar";
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Microsoft Sans Serif", 35.25F);

                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
                this.tableLayoutPanel1.Controls.Add(label, 1, 0);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
