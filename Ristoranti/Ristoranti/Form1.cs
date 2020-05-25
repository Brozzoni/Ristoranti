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

            menu[0].nome = "Penne al sugo";
            menu[0].prez = 13.50M;
            num++;

            menu[1].nome = "Vino";
            menu[1].prez = 12.00M;
            num++;

            menu[2].nome = "Pizza";
            menu[2].prez = 12.00M;
            num++;

            menu[3].nome = "Cotoletta";
            menu[3].prez = 12.00M;
            num++;

            menu[4].nome = "Patatine";
            menu[4].prez = 12.00M;
            num++;

            menu[5].nome = "Acqua";
            menu[5].prez = 1.00M;
            num++;

            menu[6].nome = "Coca-Cola";
            menu[6].prez = 2.00M;
            num++;

            menu[7].nome = "Gelato";
            menu[7].prez = 12.00M;
            num++;

            menu[8].nome = "Bistecca";
            menu[8].prez = 12.00M;
            num++;

            menu[9].nome = "Tagliata";
            menu[9].prez = 12.00M;
            num++;

            menu[10].nome = "Risotto";
            menu[10].prez = 12.00M;
            num++;

            menu[11].nome = "Grigliata";
            menu[11].prez = 12.00M;
            num++;

            menu[12].nome = "Fritto misto";
            menu[12].prez = 12.00M;
            num++;

            menu[13].nome = "Branzino";
            menu[13].prez = 12.00M;
            num++;

            menu[14].nome = "Cheesecake";
            menu[14].prez = 12.00M;
            num++;
        }

        int num = 0;        
        Piatto[] menu = new Piatto[15];
        Piatto[] ordini = new Piatto[100];

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTI.Text))
            {
                MessageBox.Show("Inserire un tavolo");
                return;
            }

            if (string.IsNullOrEmpty(tbQI.Text))
            {
                MessageBox.Show("Inserire una quantità");
                return;
            }

            int x = 0;

            while (x < 15)
            {
                if (textBox4.Text == menu[x].nome)
                {
                    ordini[num].nome = menu[x].nome;
                    ordini[num].prez = menu[x].prez;
                }
                x++;
            }

            ordini[num].qta = int.Parse(tbQI.Text);
            ordini[num].tavolo = int.Parse(tbTI.Text);    
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = listBox1.Text;
        }
    }

}
