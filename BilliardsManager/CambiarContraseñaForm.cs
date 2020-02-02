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
    public partial class CambiarContraseñaForm : Form
    {
        Conector c;
        public CambiarContraseñaForm(Conector c)
        {
            this.c = c;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c.changeAdminPassword(textBox1.Text, textBox2.Text, textBox1.Text, textBox3.Text))
            {
                Dispose();
            }
            else
            {
                MessageBox.Show("Error, el usuario y contraseña no concuerdan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
