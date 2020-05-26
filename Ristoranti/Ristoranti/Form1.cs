﻿using System;
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
        int b = 0;
        Piatto[] menu = new Piatto[15];
        Piatto[] ordini = new Piatto[100];


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
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
                if (textBox4.Text == menu[x].nome)
                {
                    ordini[num].nome = menu[x].nome;
                    ordini[num].prez = menu[x].prez;
                }
                x++;
            }

            ordini[num].qta = int.Parse(tbQI.Text);
            ordini[num].tavolo = int.Parse(tbTI.Text);

            num++;

            tbTI.Clear();
            tbQI.Clear();
            textBox4.Clear();

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = listBox1.Text;
        }

        private void btnCercaAgg_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            for (b = 0; b < num; b++)
            {
                if (ordini[b].tavolo == int.Parse(txtTavoloAgg.Text))
                {
                    listBox2.Items.Add($"{ordini[b].nome} {ordini[b].qta}");
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
            domainUpDown1.Text = listBox2.SelectedItem.ToString();
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
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked==false)
            {
                MessageBox.Show("Scegli un ordinamento");
                return;
            }

            int x = 0;

            ListViewItem riga = default;
            listView1.Items.Clear();
            
            if (radioButton1.Checked == true)
            {
                Class1.ordinapiatti(ordini, num);

                while (x < num)
                {
                    riga = new ListViewItem(new string[]{ ordini[x].nome,
                    ordini[x].prez.ToString(),
                    ordini[x].tavolo.ToString(),
                    ordini[x].tipo });
                    listView1.Items.Add(riga);
                    x++;
                }
            } 

            if (radioButton2.Checked == true)
            {
                if (string.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("Inserisci un tavolo");
                    return;
                }

                while(x<num)
                {
                    if (ordini[x].tavolo == int.Parse(textBox5.Text))
                    {
                        riga = new ListViewItem(new string[]{ ordini[x].nome,
                    ordini[x].prez.ToString(),
                    ordini[x].tavolo.ToString(),
                    ordini[x].tipo });
                        listView1.Items.Add(riga);
                        
                    }
                    x++;
                }               

                textBox5.Clear();
            } 
        }
    }
}
