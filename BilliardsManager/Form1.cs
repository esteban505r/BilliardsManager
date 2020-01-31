using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BilliardsManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Conector c = new Conector();

            InitializeComponent();

            label1.ForeColor = ColorTranslator.FromHtml("#24915e");
            label2.ForeColor = ColorTranslator.FromHtml("#f26c65");
            label3.ForeColor = ColorTranslator.FromHtml("#257191");

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
            

    
        }

        private void panelMesaBillar14_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            previousTab();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            nextTab();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nextTab();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            nextTab();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            previousTab();
        }

        private void Mesa1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
