using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_pracadomowa_1
{
    internal class BST
    {
        // Korzeń drzewa - pierwszy węzeł, od którego zaczyna się struktura drzewa.
        public NodeT root = null;

        //dodaje nowy wezel z wartoscia a do drzewa
        public void Add(int a)
        {
            //towrzenie nowego wezla ktory bedzie dodany
            NodeT dziecko = new NodeT(a);
            //jesli drzewo jest puste ustaw nowy el jako korzen
            if (this.root == null)
            {
                this.root = dziecko;
                return;
                // Kończymy dodawanie, ponieważ korzeń już został ustawiony.
            }
            // Znajduje rodzica (istniejący węzeł), pod którego zostanie wstawiony nowy węzeł.
            var rodzic = this.znajdzRodzica(dziecko);

            // Ustawia odniesienie do rodzica dla nowego węzła.
            dziecko.rodzic = rodzic;

            // Porównuje wartość nowego węzła z wartością rodzica.
            // Jeśli nowy węzeł ma wartość mniejszą niż rodzic, jest dodawany jako lewe dziecko.
            if (dziecko.data < rodzic.data)
            {
                rodzic.lewe = dziecko;
            }
            // W przeciwnym razie jest dodawany jako prawe dziecko rodzica.
            else
            {
                rodzic.prawe = dziecko;
            }
        }
        // Znajduje odpowiedniego rodzica dla nowego węzła w drzewie.
        public NodeT znajdzRodzica(NodeT dziecko)
        {// Zaczynamy od korzenia drzewa.
            NodeT rodzic = this.root;
            while (true)
            {
                // Porównujemy wartość nowego węzła z wartością obecnego węzła (rodzica).

                // Jeśli wartość nowego węzła jest mniejsza, przeszukujemy lewe poddrzewo.
                if (dziecko.data < rodzic.data)
                {
                    // Jeśli lewe dziecko obecnego węzła jest puste, oznacza to,
                    // że tutaj może zostać wstawiony nowy węzeł. Zwracamy obecny węzeł jako rodzica.
                    if (rodzic.lewe == null)
                    {
                        return rodzic;
                    }
                    // Jeśli lewe dziecko istnieje, przechodzimy głębiej w lewo.
                    rodzic = rodzic.lewe;
                }
                // W przeciwnym razie przeszukujemy prawe poddrzewo.
                else
                {// Jeśli prawe dziecko obecnego węzła jest puste, oznacza to,
                 // że tutaj może zostać wstawiony nowy węzeł. Zwracamy obecny węzeł jako rodzica.
                    if (rodzic.prawe == null)
                    {
                        return rodzic;
                    }
                    // Jeśli prawe dziecko istnieje, przechodzimy głębiej w prawo.
                    rodzic = rodzic.prawe;
                }
            }//zwraca wezel ktory bedzie rodzicem nowego wezla
        }

        public string ToString()
        {
            //jesli drzewo nie ma korzenia, czyli 1 elemntu to znaczy ze jest puste
            if (root == null) return "Drzewo jest puste";

            //Utworz liste do przechowywania wynikow(wartosci wezlow)
            //w kolejności in-order(lewo->węzeł->prawo).
            List<int> wyniki = new List<int>();

            // Stos (LIFO) służy do przechowywania węzłów podczas iteracyjnego przechodzenia drzewa.
            Stack<NodeT> stos = new Stack<NodeT>();

            //rozpoczynamy od korzenia drzewa
            NodeT obecny = root;

            // Pętla działa, dopóki istnieje coś na stosie lub mamy aktualny węzeł do przetworzenia.
            while (stos.Count > 0 || obecny != null)
            {
                while (obecny != null)
                {
                    //dodajemy wezel na stos poniewac bedziemy do niego wracac i przechodzimy do lewego dziecka
                    stos.Push(obecny);
                    //przechodzimy do lewego dziecka
                    obecny = obecny.lewe;
                }
                //Pobieramy wezel ze stosu (wracamy do ostatniego odwiedzonego wezla)
                obecny = stos.Pop();

                //dodajemy wartosc tego wezla do listy wynikow
                wyniki.Add(obecny.data);
                //przechodzimy do prawego dziecka jesli istnieje
                obecny = obecny.prawe;
            }
            // Łączymy wszystkie wartości z listy wyników w jeden ciąg znaków, oddzielony spacjami, i zwracamy go.
            return string.Join(" ", wyniki);
        }

        public NodeT RemoveO(NodeT w)
        {
            if (w == null)
            {
                this.root = null;
                return w;
            }
            var rodzic = w.rodzic;
            w.rodzic = null;
            if (rodzic.lewe == w)
            {
                rodzic.lewe = null;
            }
            if (rodzic.prawe == w)
            {
                rodzic.prawe = null;
            }
            return w;
        }

        public NodeT Remove1(NodeT w)
        {
            NodeT dziecko = null;
            if (w.lewe != null)
            {
                dziecko = this.RemoveO(w.lewe);

            }
            else if (w.prawe != null)
            {
                dziecko = this.RemoveO(w.prawe);
            }


            if (this.root == w)
            {
                this.root = dziecko;
            }
            else
            {
                dziecko.rodzic = w.rodzic;

                if (w.rodzic.lewe == w)
                {
                    this.RemoveO(w);
                    w.rodzic.lewe = dziecko;
                }
                else
                {
                    this.RemoveO(w);
                    w.rodzic.prawe = dziecko;
                }
            }

            return w;
        }

        //DOKONCZYC!!!!
        //public NodeT RemoveT(NodeT w)
        //{
        //    //k=kandydat
        //    switch (w.ileDzieci())
        //    {
        //        case 0:
        //            return this.RemoveT(w);
        //        case 1:
        //            return this.RemoveT(w);
        //        case 2:
        //            {
        //                var k = this.Min(w.prawe);
        //                this.RemoveT(k);
        //                return this.RemoveT(w);
        //                //przepiac kandydata
        //                //TUTAJ!!!
        //            }
        //    }
        //}

        public NodeT Min(NodeT w)

        {
            var wynik = w;
            while (wynik.lewe != null)
            {
                wynik = wynik.lewe;
            }
            return wynik;
        }
    }
}

