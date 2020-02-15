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
    public partial class UtilidadPorTipos : Form
    {
        Conector c;
        List<Record> lista;
        public UtilidadPorTipos()
        {
            InitializeComponent();
            c = new Conector();
            lista = c.getRecords();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Record> lista2 = new List<Record>();
            for(int i = 0;i< lista.Count ; i++)
            {
                if (lista[i].type.Equals("bebida"))
                {
                    lista2.Add(lista[i]);
                };
            }
            calcularUtilidad(lista2);
        }

        private void calcularUtilidad(List<Record> lista)
        {
            int totalIngresos = 0;
            int totalGastos = 0;
            
            for (int i = 0; i < lista.Count; i++)
            {
                totalIngresos += lista[i].entry;
                totalGastos += lista[i].expense;
            }
            int utilidad = totalIngresos - totalGastos;
            MessageBox.Show("Total Ingresos: "+totalIngresos.ToString()+"\n"+"Total Gastos"+totalGastos.ToString()+"\n"+
                "Utilidad "+utilidad.ToString(),"Utilidad",MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Record> lista2 = new List<Record>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].type.Equals("otro"))
                {
                    lista2.Add(lista[i]);
                };
            }
            calcularUtilidad(lista2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Record> lista2 = new List<Record>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].type.Equals("tiempo"))
                {
                    lista2.Add(lista[i]);
                };
            }
            calcularUtilidad(lista2);
        }

        private void Tipos_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            calcularUtilidad(lista);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Record> lista2 = new List<Record>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].type.Equals("comida"))
                {
                    lista2.Add(lista[i]);
                };
            }
            calcularUtilidad(lista2);
        }
    }
}
