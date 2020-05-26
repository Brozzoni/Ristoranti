using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristoranti
{
    public partial class Form1 : Form
    {

        int num = 0;
        Piatto[] menu = new Piatto[100];

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

        private void button6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text) == true)
            {
                MessageBox.Show("inserire il numero di un tavolo");
                return;
            }

            bool.TryParse(textBox4.Text, out bool a);
            if (a == true)
            {
                MessageBox.Show("inserire un valore valido");
                return;
            }
                        
            int i = int.Parse(textBox4.Text);            

            decimal x = default(decimal);
            for (int b = 0; b <= num; b++)
            {
                if (menu[b].tavolo == i)
                {
                    x = x + menu[b].prez;
                }
            }

            label10.Text = $"{x}";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label10.Text) == true)
            {
                MessageBox.Show("inserire il numero di un tavolo");
                return;
            }

            if (File.Exists("SommaGuadagno.txt") != true)
            {
                FileInfo fi = new FileInfo("SommaGuadagno.txt");
            }

            using (StreamWriter scrv = new StreamWriter("SommaGuadagno.txt"))
            {
                scrv.WriteLine($"label10.Text");
            }

            label10.Text = "";

            for (int b = 0; b <= num; b++)
            {
                if (menu[b].tavolo == int.Parse(label10.Text))
                {                    
                    menu[b] = menu[num - 1];
                    menu[num - 1] = menu[num];
                    num = num - 1;
                }
            }

            MessageBox.Show("prezzo caricato");
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label10.Text = "";
        }
    }

}
