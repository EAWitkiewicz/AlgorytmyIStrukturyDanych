using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_pracadomowa_1
{
    internal class Lista
    {
        //pierwszy element listy
        public NodeL head;
        //ostatni element listy
        public NodeL tail;
        //liczba elementow w liscie
        public uint count;

        //dodaje element na poczatku listy
        public void AddFirst(int liczba)
        {
            //towrzenie nowego wezła z liczba w konstruktorze
            var nowy = new NodeL(liczba);

            //Ten krok przypisuje obecny pierwszy element listy (this.head) jako next dla nowego węzła.
            nowy.next = this.head;
            //Dzięki nowy.next = this.head mówimy, że nowy węzeł (nowy element) będzie wskazywał na obecny pierwszy element listy.
            //Nowy węzeł wskazuje na dawną głowę listy. Takie przypisanie zapewnia, że dawny pierwszy element nie zostaje „porzucony” i jest dostępny jako następny element po nowym węźle.

            //jesli w liscie sa juz jakies elementy(czy jest juz jakas glowa)
            if (this.count > 0)
            {
                //this.head.prev = nowy; — dawny pierwszy element (wczesniejsza głowa) dostaje w polu prev referencję na nowy węzeł.(obecna glowe)
                this.head.prev = nowy;
            }
            else
            {//jesli na liscie nie ma elementów nasz nowy wezel ustawiamy jako ogon/ostani element listy
                this.tail = nowy;
            }
            //i głową jest zarówno głową jak i ogonem
            this.head = nowy;

            //dodalismy element wiec inkrementujemy liste
            count++;
        }

        public void AddLast(int liczba)
        {
            var nowy= new NodeL(liczba);

            // this.tail wskazuje na ostatni element w liście, więc nowy.prev = this.tail oznacza, że nowy węzeł staje się „następnikiem” aktualnego ogona listy.
            nowy.prev = this.tail;

             if(this.count > 0)
            {
                //Dotychczasowy ogon listy (this.tail) dostaje w polu next referencję na nowy węzeł (this.tail.next = nowy).
                //Dzięki temu dotychczasowy ogon jest połączony z nowym węzłem jako jego następnik.
                this.tail.next = nowy;
            }
            else
            {
                //W tym przypadku ustawiamy this.head = nowy, aby nowy węzeł był zarówno głową, jak i ogonem listy.
                this.head = nowy;
            }
            //Niezależnie od tego, czy lista była pusta, czy nie, nowy węzeł staje się ogonem listy, więc this.tail wskazuje teraz na niego.
            this.tail = nowy;
            count++;
        }

        public void RemoveFirst()
        {
            count--;
            if (count == 0)
            {
                this.tail = null;
            }
            else
            {
                this.head = this.head.next;
                this.head.prev.next = null;
                this.head.prev = null;
            }
        }
    }
}
