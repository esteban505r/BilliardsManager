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

            tableLayoutPanel1.RowStyles.RemoveAt(0);
            for(int i = 0; i < productos.Count; i++)
            {
                Label label = new Label();
                label.Text = productos[i].getName() + "  " + "$" + productos[i].getPrecio().ToString();
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Microsoft Sans Serif", 20.25F);

                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, ((float)productos.Count) / 100));
                this.tableLayoutPanel1.Controls.Add(label, 1, i);
            }
        }
    }
}
