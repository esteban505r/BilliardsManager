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
    public partial class SettingsOtrosForm : Form
    {
        Conector c;
        List<Conf> confsLista;
        public SettingsOtrosForm()
        {
            InitializeComponent();
            c = new Conector();
            confsLista = c.getConfs();
            for(int i = 0; i < confsLista.Count; i++)
            {
                switch (confsLista[i].name)
                {
                    case "hour_value":
                        textBox1.Text = confsLista[i].value;
                        break;
                    case "minute_value":
                        textBox2.Text = confsLista[i].value;
                        break;
                    case "is_minute_value_hour_divided":
                        if (confsLista[i].value.Equals("true")) { checkBox1.Checked = true; } else { checkBox1.Checked = false; }
                        break;
                    case "manage_products_require_admin":
                        if (confsLista[i].value.Equals("true")) { checkBox2.Checked = true; } else { checkBox2.Checked = false; }
                        break;
                }
            }
        }

        private void SettingsOtrosForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Conf minuteValue = new Conf(0, "minute_value", "", false);
                Conf hourValue = new Conf(0, "hour_value", Convert.ToInt32(textBox1.Text).ToString(), false);
                Conf isMinuteValueHourDivided = new Conf(0, "is_minute_value_hour_divided", (checkBox1.Checked)?"true":"false", false);
                Conf manageProductsRequireAdmin= new Conf(0, "manage_products_require_admin", (checkBox2.Checked) ? "true" : "false", false);
                c.saveConf(hourValue);
                if (checkBox1.Checked)
                {
                    minuteValue.value = (Convert.ToInt32(hourValue.value) / 60).ToString();
                    isMinuteValueHourDivided.value = "true";
                }
                else
                {
                    minuteValue.value = Convert.ToInt32(textBox2.Text).ToString();
                }
                c.saveConf(minuteValue);
                c.saveConf(isMinuteValueHourDivided);
                c.saveConf(manageProductsRequireAdmin);
                Dispose();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error, los campos deben ser un número entero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { 
                try
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text)/60).ToString();
                }
                catch (FormatException)
                {
                    textBox2.Text = "Escribe un número valido";
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { 
            textBox2.Enabled = false;
            }
            else
            {
            textBox2.Enabled = true;
            textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
