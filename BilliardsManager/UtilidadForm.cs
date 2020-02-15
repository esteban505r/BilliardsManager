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
    public partial class UtilidadForm : Form
    {
        private List<Record> lista;
        private Conector c;
        public UtilidadForm(int type)
        {
            InitializeComponent();
            c = new Conector();
            lista = c.getRecords();
            for (int i = 0; i < lista.Count(); i++)
            {
                int s = 0;
                switch (lista[i].type)
                {
                    case "bebida":
                        s = 1;
                        break;
                    case "comida":
                        s = 2;
                        break;
                    case "otro":
                        s = 3;
                        break;
                }
                if (type == s || type==0) { dataGridView1.Rows.Add(lista[i].date, lista[i].type, lista[i].entry, lista[i].expense, "Eliminar"); }                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                List<Record> records = new List<Record>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!string.IsNullOrEmpty(row.Cells[3].Value.ToString()))
                    {
                        try
                        {
                            if (Convert.ToInt32(row.Cells[3].Value) >= 0)
                            {
                                String date = row.Cells[0].Value.ToString();
                                String type = row.Cells[1].Value.ToString();
                                int entry = Convert.ToInt32(row.Cells[2].Value.ToString());
                                int expense = Convert.ToInt32(row.Cells[3].Value.ToString());
                                Record p = new Record(0, date, type, entry,expense);
                                records.Add(p);
                            }
                            else
                            {
                                MessageBox.Show("Error, el precio debe ser un número entero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (FormatException error2)
                        {
                            MessageBox.Show("Error, el precio debe ser un número entero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, ninguna celda debe estar vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }
                c.saveRecords(records, true);
                Dispose();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro?", "Eliminar registro", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes) { 
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    try
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (InvalidOperationException error)
                    {

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UtilidadPorTipos utilidadPorTipos = new UtilidadPorTipos();
            utilidadPorTipos.Show();
        }
    }
}
