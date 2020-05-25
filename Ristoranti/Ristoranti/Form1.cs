using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristoranti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            menu[num].nome = "Penne al sugo";
            menu[num].prez = 13.50M;
            num++;

            menu[num].nome = "Tartar di tonno";
            menu[num].prez = 12.00M;
            num++;

            menu[num].nome = "Pizza";
            menu[num].prez = 12.00M;
            num++;
        }

        int num = 0;
        Piatto[] menu = new Piatto[100];

        private void btnCercaAgg_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < num; x++)
            {
                if (menu[x].tavolo == int.Parse(txtTavoloAgg.Text))
                {
                    listBox1.Items.Clear();
                    ListViewItem riga;
                  

                    for (int y = 0; y < num; y++)
                    {
                        riga = new ListViewItem(new string[] { menu[x].tavolo.ToString(), menu[x].nome,
                            menu[x].qta.ToString() });

                        listBox1.Items.Add(riga);
                    }
                }
            }

            
                MessageBox.Show("Tavolo non trovato");
        }
    }

}
