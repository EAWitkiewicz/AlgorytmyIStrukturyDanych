using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_pracadomowa_1
{
    internal class NodeT
    {
            public NodeT rodzic, lewe, prawe;
            public int data;

            public NodeT(int liczba)
            {
                this.data = liczba;
            }

        public int ileDzieci()
        {
            int wynik = 0;

            if (this.lewe != null)
            {
                wynik++;
            }
            if (this.prawe != null)
            {
                wynik++;
            }
            return wynik;
        }

 
    }
}
