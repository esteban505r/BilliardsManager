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
    public partial class PedirContraseñaForm : Form
    {
        Conector c;
        public Boolean passed = false;
        public PedirContraseñaForm()
        {
            InitializeComponent();
            c = new Conector();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            passed = c.checkAdminPassword(textBox1.Text, textBox2.Text);
            Dispose();
        }
    }
}
