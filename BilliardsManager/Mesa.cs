using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;

namespace BilliardsManager
{
    public class Mesa : Panel 
    {
        private Label numero,cronometro;
        private Boolean active = false;
        private Boolean isActiveStopWatch = false;
        public List<Producto> productos { get; set; }


        public Mesa():base()
        {
            this.BackgroundImage = global::BilliardsManager.Properties.Resources.table;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.Dock = DockStyle.Fill;
            this.MinimumSize = new Size(200,300);
            this.Padding = new Padding(35);

            productos = new List<Producto>();
            cronometro = new Label();
            cronometro.ForeColor = Color.White;
            cronometro.Text = "00:00:00";
            cronometro.TextAlign = ContentAlignment.BottomRight;
            cronometro.Font = new Font("Microsoft Sans Serif", 30.25F);
            cronometro.BackColor = Color.Transparent;
            cronometro.Dock = DockStyle.Bottom;
            cronometro.MinimumSize = new Size(20, 60);
            cronometro.Padding = new Padding(0, 0, 0, 15);

            numero = new Label();
            numero.Dock = DockStyle.Fill;
            numero.Text = "1";
            numero.BackColor = Color.Transparent;
            numero.Font = new Font("Microsoft Sans Serif", 30.25F);
            numero.TextAlign = ContentAlignment.MiddleCenter;
            numero.ForeColor = Color.White;

            this.Controls.Add(numero);

            numero.Click += panelClick;
        }

        void panelClick(object sender, EventArgs e)
        {
            if (!active)
            {
                active = true;
                numero.TextAlign = ContentAlignment.TopLeft;

                Controls.Add(cronometro);

                Thread c = new Thread(new ThreadStart(stopWatch));
                c.IsBackground = true;
                c.Start();
            }
            else
            {
                OpcionesDialog opciones = new OpcionesDialog();
                opciones.mesa = this;
                opciones.ShowDialog();
                if (opciones.producto != null) { 
                productos.Add(opciones.producto);
                }
            }
        }

        public Label getNumero()
        {
            return numero;
        }

        public void setNumero(String numero)
        {
            this.numero.Text = numero;
        }

        public Label getCronometro()
        {
            return cronometro;
        }

        public void stopWatch()
        {
            isActiveStopWatch = true;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (isActiveStopWatch)
            {
                Thread.Sleep(10);
                cronometro.Invoke((MethodInvoker)(() =>
                {
                    cronometro.Text = String.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
                }));


            }

            stopwatch.Stop();
        }
    }
}
