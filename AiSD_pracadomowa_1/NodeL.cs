using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_pracadomowa_1
{
 //pojedynczy wezel listy dwukierunkowej
    internal class NodeL
    {
        //referencja do nastepnego wezła na liście
        public NodeL next;
        //referancja do poprzedniego elementu na liscie
        public NodeL prev;
        //przechowuje dane (liczbe) przypisana do wezla
        public int data;

        //konstruktor przyjmuje liczbe
        public NodeL(int liczba)
        {
            //przypisuje ją do do pola data
            this.data = liczba;
        }
    }
}
