using System;
using System.Drawing;
using System.Windows.Forms;

namespace BilliardsManager
{
    public partial class Form1 : Form
    {
        public static int valorHora = 7000;
        public static int valorMinuto = valorHora/60;
        public Mesa mesaBillar1, mesaBillar2, mesaBillar3, mesaBillar4, mesaBillar5, mesaBillar6, mesaBillar7;
        public Mesa Mesa1, Mesa2, Mesa3, Mesa4, Mesa5, Mesa6;

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDeForm a = new AcercaDeForm();
            a.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm s = new SettingsForm();
            s.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            nextTab();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            previousTab();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            nextTab();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            previousTab();
        }

        public Mesa mesaVarios, mesaCocina, mesaBaño;

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            previousTab();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nextTab();
        }



        public Form1()
        {
            this.mesaBillar1 = new BilliardsManager.Mesa(1);
            this.mesaBillar2 = new BilliardsManager.Mesa(1);
            this.mesaBillar3 = new BilliardsManager.Mesa(1);
            this.mesaBillar4 = new BilliardsManager.Mesa(1);
            this.mesaBillar5 = new BilliardsManager.Mesa(1);
            this.mesaBillar6 = new BilliardsManager.Mesa(1);
            this.mesaBillar7 = new BilliardsManager.Mesa(1);
            this.Mesa1 = new BilliardsManager.Mesa(2);
            this.Mesa2 = new BilliardsManager.Mesa(2);
            this.Mesa3 = new BilliardsManager.Mesa(2);
            this.Mesa4 = new BilliardsManager.Mesa(2);
            this.Mesa5 = new BilliardsManager.Mesa(2);
            this.Mesa6 = new BilliardsManager.Mesa(2);
            this.mesaVarios = new BilliardsManager.Mesa(3);
            this.mesaCocina = new BilliardsManager.Mesa(3);
            this.mesaBaño = new BilliardsManager.Mesa(3);
            InitializeComponent();

            label1.ForeColor = ColorTranslator.FromHtml("#24915e");
            label2.ForeColor = ColorTranslator.FromHtml("#f26c65");
            label3.ForeColor = ColorTranslator.FromHtml("#257191");

            mesaBillar1.Margin = new Padding(0,20,0,20);
            mesaBillar2.Margin = new Padding(0,20,0,20);
            Mesa1.Margin = new Padding(0,20,0,20);
            Mesa2.Margin = new Padding(0,20,0,20);
            mesaBaño.Margin = new Padding(0,20,0,20);
            mesaCocina.Margin = new Padding(0,20,0,20);

            mesaBillar1.setNumero("1");
            mesaBillar2.setNumero("2");
            mesaBillar3.setNumero("3");
            mesaBillar4.setNumero("4");
            mesaBillar5.setNumero("5");
            mesaBillar6.setNumero("6");
            mesaBillar7.setNumero("7");
            Mesa1.setNumero("1");
            Mesa2.setNumero("2");
            Mesa3.setNumero("3");
            Mesa4.setNumero("4");
            Mesa5.setNumero("5");
            Mesa6.setNumero("6");

            Mesa1.getNumero().ForeColor = Color.Black;
            Mesa2.getNumero().ForeColor = Color.Black;
            Mesa3.getNumero().ForeColor = Color.Black;
            Mesa4.getNumero().ForeColor = Color.Black;
            Mesa5.getNumero().ForeColor = Color.Black;
            Mesa6.getNumero().ForeColor = Color.Black;
            Mesa1.getCronometro().ForeColor = Color.Black;
            Mesa2.getCronometro().ForeColor = Color.Black;
            Mesa3.getCronometro().ForeColor = Color.Black;
            Mesa4.getCronometro().ForeColor = Color.Black;
            Mesa5.getCronometro().ForeColor = Color.Black;
            Mesa6.getCronometro().ForeColor = Color.Black;
            Mesa1.getCronometro().TextAlign = ContentAlignment.BottomLeft;
            Mesa2.getCronometro().TextAlign = ContentAlignment.BottomLeft;
            Mesa3.getCronometro().TextAlign = ContentAlignment.BottomLeft;
            Mesa4.getCronometro().TextAlign = ContentAlignment.BottomLeft;
            Mesa5.getCronometro().TextAlign = ContentAlignment.BottomLeft;
            Mesa6.getCronometro().TextAlign = ContentAlignment.BottomLeft;

            mesaCocina.setNumero("Cocina");
            mesaBaño.setNumero("Baño");
            mesaVarios.setNumero("Otros");

            mesaCocina.getNumero().ForeColor = Color.White;
            mesaBaño.getNumero().ForeColor = Color.White;
            mesaVarios.getNumero().ForeColor = Color.White;

            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.Controls.Add(mesaBillar1,0,1);
            tableLayoutPanel1.Controls.Add(mesaBillar2,1,1);
            tableLayoutPanel1.Controls.Add(mesaBillar3,0,2);
            tableLayoutPanel1.Controls.Add(mesaBillar4,1,2);
            tableLayoutPanel1.Controls.Add(mesaBillar5,0,3);
            tableLayoutPanel1.Controls.Add(mesaBillar6,1,3);
            tableLayoutPanel1.Controls.Add(mesaBillar7,0,4);

            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.Controls.Add(Mesa1,0,1);
            tableLayoutPanel3.Controls.Add(Mesa2,1,1);
            tableLayoutPanel3.Controls.Add(Mesa3,0,2);
            tableLayoutPanel3.Controls.Add(Mesa4,1,2);
            tableLayoutPanel3.Controls.Add(Mesa5,0,3);
            tableLayoutPanel3.Controls.Add(Mesa6,1,3);
            
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.Controls.Add(mesaBaño,0,1);
            tableLayoutPanel5.Controls.Add(mesaCocina,1,1);
            tableLayoutPanel5.Controls.Add(mesaVarios,0,2);

            Conector c = new Conector();
            if (c.firstConf())
            {
                AdminWelcome welcome = new AdminWelcome(c);
                welcome.ShowDialog();
            }
        }


        private void nextTab()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                tabControl1.SelectedTab = tabPage2;

            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                tabControl1.SelectedTab = tabPage3;

            }
        }
        private void previousTab()
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                tabControl1.SelectedTab = tabPage1;

            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                tabControl1.SelectedTab = tabPage2;

            };

        }
    }
}
