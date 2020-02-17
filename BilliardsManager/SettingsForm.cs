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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conector c = new Conector();
            if (c.getConf("manage_products_require_admin").Equals("false"))
            {
                AdministrarProductosForm administrarProductosForm = new AdministrarProductosForm();
                administrarProductosForm.ShowDialog();
            }
            else
            {
                PedirContraseñaForm pedirContraseñaForm = new PedirContraseñaForm();
                pedirContraseñaForm.ShowDialog();
                if (pedirContraseñaForm.passed)
                {
                    AdministrarProductosForm administrarProductosForm = new AdministrarProductosForm();
                    administrarProductosForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambiarContraseñaForm cambiarContraseña = new CambiarContraseñaForm(new Conector());
            cambiarContraseña.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PedirContraseñaForm pedirContraseñaForm = new PedirContraseñaForm();
            pedirContraseñaForm.ShowDialog();
            if (pedirContraseñaForm.passed) { 
                UtilidadForm utilidadForm = new UtilidadForm(0);
                utilidadForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PedirContraseñaForm pedirContraseñaForm = new PedirContraseñaForm();
            pedirContraseñaForm.ShowDialog();
            if (pedirContraseñaForm.passed)
            {
                SettingsOtrosForm otros = new SettingsOtrosForm();
                otros.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
