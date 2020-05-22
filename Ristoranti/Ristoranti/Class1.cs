using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ristoranti
{
    public struct Tavolo
    {
        public string numero;
        public int posti;
        public string[] piatti;
        public decimal totale;
    }

    public struct Piatto
    {
        public string nome;
        public decimal prez;
        public string tipo;
    }

    

    class Class1
    {
        string[] piatti = new string[100];

    }
}
