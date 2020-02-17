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

        private void actualizarProductos()
        {
            Conector c = new Conector();
            Conf hourValue = c.getConf("hour_value");
            Conf minuteValue = c.getConf("minute_value");
            int hValue = Convert.ToInt32(hourValue.value);
            int mValue = Convert.ToInt32(minuteValue.value);
            if (mesa.productos == null) { mesa.productos = new List<Producto>(); }
            if (stopwatch != null)
            {
                Producto tiempo = new Producto(0, "Tiempo", (hValue * (Convert.ToInt32(stopwatch.Elapsed.TotalHours)))
                    + (mValue * (Convert.ToInt32(stopwatch.Elapsed.TotalMinutes))), "tiempo");

                for (int i = 0; i < mesa.productos.Count; i++)
                {
                    if (mesa.productos[i].getType().Equals("tiempo"))
                    {
                        mesa.productos.RemoveAt(i);
                    }
                }
                mesa.productos.Add(tiempo);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            actualizarProductos();
            VerProductosForm ver = new VerProductosForm(mesa.productos);
            ver.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < mesa.productos.Count; i++)
            {
                total = total + mesa.productos[i].getPrecio();
            }
            if (total > 100) { 
                DateTime now = DateTime.Now;
                Conector c = new Conector();
                List<Record> records = new List<Record>();
                for (int i = 0; i < mesa.productos.Count; i++)
                {
                    if (mesa.productos[i].getPrecio() != 0)
                    {
                        records.Add(new Record(0, now.ToString("dd/MM/yyyy HH:mm"), mesa.productos[i].getType(), mesa.productos[i].getPrecio(), 0));
                    }
                }
                c.saveRecords(records);
                mesa.exit = true;
                Dispose();
            }
            else
            {
                mesa.exit = true;
                Dispose();
            }
        }
    }
}
