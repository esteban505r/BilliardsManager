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
            AdministrarProductosForm administrarProductosForm = new AdministrarProductosForm();
            administrarProductosForm.ShowDialog();
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
        }
    }
}
