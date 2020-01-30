using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows;

namespace BilliardsManager
{
    class PanelMesaBillar : Panel 
    {
        private Label numero,cronometro;
        private Boolean active = false;

        public PanelMesaBillar():base()
        {
            this.BackgroundImage = global::BilliardsManager.Properties.Resources.table;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Dock = DockStyle.Fill;
            this.MinimumSize = new Size(200,300);
            this.Padding = new Padding(35);

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
                cronometro = new Label();
                cronometro.Text = "00:00:00";
                cronometro.TextAlign = ContentAlignment.BottomRight;
                cronometro.Font = new Font("Microsoft Sans Serif", 30.25F);
                cronometro.BackColor = Color.Transparent;
                cronometro.ForeColor = Color.White;
                cronometro.Dock = DockStyle.Bottom;
                cronometro.MinimumSize = new Size(20,60);
                cronometro.Padding = new Padding(0,0,0,15);


                Controls.Add(cronometro);
            }
        }
    }
}
