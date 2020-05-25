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
            menu[num].tavolo = 3;
            num++;

            menu[num].nome = "Pizza";
            menu[num].prez = 12.00M;
            num++;
        }

        int num = 0;
        int b = 0;
        Piatto[] menu = new Piatto[100];

        private void btnCercaAgg_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            for (b = 0; b < num; b++)
            {
                if (menu[b].tavolo == int.Parse(txtTavoloAgg.Text))
                {
                    listBox2.Items.Add($"{menu[b].nome} x{menu[b].qta.ToString()}");
                }
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
            txtQtaAgg.Text = listBox2.SelectedItem.ToString();

            txtQtaAgg.Text.Split();
        }
    }

}
