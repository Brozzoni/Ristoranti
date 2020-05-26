using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Funzioni_Ristoranti;

namespace Ristoranti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            menu[1].nome = "Vino";
            menu[1].prez = 12.00M;

            menu[2].nome = "Pizza";
            menu[2].prez = 12.00M;

            menu[3].nome = "Cotoletta";
            menu[3].prez = 12.00M;

            menu[4].nome = "Patatine";
            menu[4].prez = 12.00M;

            menu[5].nome = "Acqua";
            menu[5].prez = 1.00M;

            menu[6].nome = "Coca-Cola";
            menu[6].prez = 2.00M;

            menu[7].nome = "Gelato";
            menu[7].prez = 12.00M;

            menu[8].nome = "Bistecca";
            menu[8].prez = 12.00M;

            menu[9].nome = "Tagliata";
            menu[9].prez = 12.00M;

            menu[10].nome = "Risotto";
            menu[10].prez = 12.00M;

            menu[11].nome = "Grigliata";
            menu[11].prez = 12.00M;

            menu[12].nome = "Fritto misto";
            menu[12].prez = 12.00M;

            menu[13].nome = "Branzino";
            menu[13].prez = 12.00M;

            menu[14].nome = "Cheesecake";
            menu[14].prez = 12.00M;
        }

        int num = 0;
        Piatto[] menu = new Piatto[15];
        Piatto[] ordini = new Piatto[100];


        private void btnOrdina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("Selezionare un piatto");
                return;
            }

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
                if (tbNome.Text == menu[x].nome)
                {
                    ordini[num].nome = menu[x].nome;
                    ordini[num].prez = menu[x].prez;
                }
                x++;
            }

            ordini[num].qta = int.Parse(tbQI.Text);
            ordini[num].tavolo = int.Parse(tbTI.Text);

            num++;

            tbNome.Clear();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNome.Text = listBox1.Text;
        }

        private void btnCercaAgg_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            for (int b = 0; b < num; b++)
            {
                if (ordini[b].tavolo == int.Parse(txtTavoloAgg.Text))
                {
                    listBox2.Items.Add($"{ordini[b].nome}");
                    listBox3.Items.Add($"{ordini[b].qta}");
                }
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        { 
            domainUpDown1.Text = listBox3.SelectedItem.ToString();
        }

        private void btnEliminOrdin_Click(object sender, EventArgs e)
        {
            int x = 0;

            while (x < num)
            {
                if (listBox2.SelectedItem.ToString() == ordini[x].nome)
                {
                    if (ordini[x].tavolo == int.Parse(txtTavoloAgg.Text))
                    {
                        ordini[x] = ordini[num - 1];
                        num--;
                    }  
                }

                x++;
            }

            btnCercaAgg.PerformClick();
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            int x = 0;

            while (x < num)
            {
                if (ordini[x].tavolo == int.Parse(txtTavoloAgg.Text))
                {
                    if (ordini[x].nome == listBox2.SelectedItem.ToString())
                    {
                        ordini[x].qta = int.Parse(domainUpDown1.Text);
                    }
                }
                x++;
            }

            btnCercaAgg.PerformClick();
        }

        private void listBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            domainUpDown1.Text = listBox3.SelectedItem.ToString();
        }

        private void btnScontrino_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("inserire il numero di un tavolo");
                return;
            }

            bool.TryParse(textBox1.Text, out bool a);
            if (a == true)
            {
                MessageBox.Show("inserire un valore valido");
                return;
            }

            int i = int.Parse(textBox1.Text);

            decimal x = default(decimal);
            for (int b = 0; b <= num; b++)
            {
                if (ordini[b].tavolo == i)
                {
                    x = x + ordini[b].prez;
                }
            }

            label9.Text = $"{x}";
        }

        private void btnPaga_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label9.Text) == true)
            {
                MessageBox.Show("inserire il numero di un tavolo");
                return;
            }

            if (File.Exists("SommaGuadagno.txt") != true)
            {
                FileInfo fi = new FileInfo("SommaGuadagno.txt");
            }

            using (StreamWriter scrv = new StreamWriter("SommaGuadagno.txt", true))
            {
                scrv.WriteLine($"{label9.Text}");
            }

            label10.Text = "";

            for (int b = 0; b <= num; b++)
            {
                if (menu[b].tavolo == int.Parse(textBox1.Text))
                {
                    ordini[b] = ordini[num - 1];
                    ordini[num - 1] = ordini[num];
                    num = num - 1;
                }
            }

            MessageBox.Show("prezzo caricato");
        }

        private void btnFatturato_Click(object sender, EventArgs e)
        {
            using (StreamReader legg = new StreamReader("SommaGuadagno.txt"))
            {
                decimal x = 0;
                decimal y = 0;
                while (legg.EndOfStream != true)
                {
                    x = decimal.Parse(legg.ReadLine());
                    y = y + x;
                }
                label11.Text = $"prezzo totale {y}";
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Scegli un ordinamento");
                return;
            }

            int x = 0;

            ListViewItem riga = default;
            listView2.Items.Clear();

            if (radioButton4.Checked == true)
            {
                Class1.ordinapiatti(ordini, num);

                while (x < num)
                {
                    riga = new ListViewItem(new string[]{ ordini[x].nome,
                    ordini[x].prez.ToString(),
                    ordini[x].tavolo.ToString()});
                    listView2.Items.Add(riga);
                    x++;
                }
            }

            if (radioButton3.Checked == true)
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Inserisci un tavolo");
                    return;
                }

                while (x < num)
                {
                    if (ordini[x].tavolo == int.Parse(textBox2.Text))
                    {
                        riga = new ListViewItem(new string[]{ ordini[x].nome,
                    ordini[x].prez.ToString(),
                    ordini[x].tavolo.ToString() });
                        listView2.Items.Add(riga);

                    }
                    x++;
                }

                textBox2.Clear();
            }
        }

    }
}
