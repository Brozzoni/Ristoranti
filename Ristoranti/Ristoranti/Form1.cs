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

    }

}
