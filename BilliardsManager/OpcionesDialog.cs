using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BilliardsManager
{
    public partial class OpcionesDialog : Form
    {
        public List<Producto> productos { get; set; }
        public Mesa mesa { get; set; }

        private System.Diagnostics.Stopwatch stopwatch;
        public OpcionesDialog(Mesa mesa)
        {
            InitializeComponent();
            productos = new List<Producto>();
            this.mesa = mesa;
            stopwatch = mesa.stopwatch;
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
            if (mesa.productos == null) { mesa.productos = new List<Producto>(); }
            Producto tiempo = new Producto(0, "Tiempo", (Form1.valorHora*(Convert.ToInt32(stopwatch.Elapsed.TotalHours)))
                + (Form1.valorMinuto * (Convert.ToInt32(stopwatch.Elapsed.TotalMinutes))), "tiempo");
            for (int i = 0; i < mesa.productos.Count; i++)
            {
                if (mesa.productos[i].getType().Equals("tiempo")){
                    mesa.productos.RemoveAt(i);
                }
            }

            mesa.productos.Add(tiempo);
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
