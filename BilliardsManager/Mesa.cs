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
        private Label numero, cronometro;
        private Boolean active = false;
        private Boolean isActiveStopWatch = false;
        public Boolean exit { get; set; } = false;
        public List<Producto> productos { get; set; }
        private int tipo;

        public Mesa(int tipo):base()
        {
            this.BackgroundImage = global::BilliardsManager.Properties.Resources.table;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.Dock = DockStyle.Fill;
            this.MinimumSize = new Size(200,300);
            this.Padding = new Padding(35);

            this.tipo = tipo;
            this.productos = new List<Producto>();
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
                if (tipo == 1)
                {
                    this.BackgroundImage = global::BilliardsManager.Properties.Resources.table_clicked;
                }
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
                if (opciones.productos!=null && opciones.productos.Count != 0) {
                    if (productos == null) { productos = new List<Producto>(); };
                productos.AddRange(opciones.productos);
                opciones.productos = new List<Producto>();
                }
                if(opciones.mesa.exit == true)
                {
                    numero.TextAlign = ContentAlignment.MiddleCenter;
                    if (tipo == 1)
                    {
                        this.BackgroundImage = global::BilliardsManager.Properties.Resources.table;
                    }
                    else if(tipo==2)
                    {
                        this.BackgroundImage = global::BilliardsManager.Properties.Resources.table2;
                    }
                    else if (tipo == 3)
                    {
                        this.BackgroundImage = global::BilliardsManager.Properties.Resources.kitchen;
                    }
                    Controls.Remove(cronometro);
                    isActiveStopWatch = false;
                    productos = new List<Producto>();
                    active = false;
                    exit = false;
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
