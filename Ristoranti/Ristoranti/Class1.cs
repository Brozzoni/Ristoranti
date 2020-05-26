using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ristoranti
{
    public struct Piatto
    {
        public string nome;
        public decimal prez;
        public int qta;
        public string tipo;
        public int tavolo;
        public bool stato;
    }

    

    class Class1
    {
        public static void ordinapiatti(Piatto[] elep, int n)
        {
            int x = default(int);
            int y = default(int);

            Piatto tmp = default;

            x = 0;

            while (x < n)
            {
                y = x + 1;

                while (y < n)
                {
                    if (elep[x].prez < elep[y].prez)
                    {
                        tmp = elep[x];
                        elep[x] = elep[y];
                        elep[y] = tmp;
                    }
                    y = y + 1;
                }
                x = x + 1;
            }
        }
    }
}
