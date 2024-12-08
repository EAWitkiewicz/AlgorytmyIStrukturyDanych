using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiSD_pracadomowa_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static String Wypisz(int[] tab)
        {
            String tab1 = "";
            foreach (var item in tab)
            {
                tab1 = tab1 + item;
            }
            return tab1;
        }
        static void mergeSort(int[] tab)
        {
            //warunek konca-sprawdza czy tablice nie sa atomowe/czy maja juz tylko 1 element
            if (tab.Length > 1)
            {
                //wyznacza polowe tablicy np. 5/2=2
                int polowa = tab.Length / 2;
                int[] L = new int[polowa];//2
                int[] P = new int[tab.Length - polowa];//5-2=3
                int i = 0;
                while (i < polowa)//uzupelnianie lewej tablicy dopoki i jest mniejsze od dl/pojemnoci tablicy
                {
                    L[i] = tab[i];//L[0]=tab[0],L[1]=tab[1] itd.
                    i++;
                }
                int j = 0;
                while (j < tab.Length - polowa)//uspelnianie prawej tablicy dopoki n\j nie osiagnie jej rozmairu/poejmnosi
                {
                    P[j] = tab[polowa + j];//P[0]=tab[2] itd.
                    j++;
                }
                //Console.Write("tablica l: ");
                //wypiszTablice(L);
                //Console.WriteLine();
                //Console.Write("tablica p: ");
                //wypiszTablice(P);
                //Console.WriteLine();
                //Console.WriteLine();
                mergeSort(L);
                mergeSort(P);
                int k = 0, l = 0, m = 0;
                //wypalnianie tablicy glownej / scalanie wlsciwe
                while (k < L.Length && l < P.Length)//dopoki zakres ktorejsc czesci tablicy sie nie skonczy
                {
                    if (L[k] < P[l])//sprawdzanie czy wskazywny el lewej czesci tablicy jest mniejszy niz wskazywany el parawej czesci tbalicy
                                    //sortowanie
                    {
                        tab[m] = L[k];
                        k++;
                        m++;
                    }
                    else
                    {
                        tab[m] = P[l];
                        m++;
                        l++;
                    }
                }
                //sprawdzanie kotra tablica sie wyczerpala
                //i w zaleznosci od tego wypelnic reszte tablicy
                while (k < L.Length)
                {
                    tab[m] = L[k];
                    m++;
                    k++;
                }
                while (l < P.Length)
                {
                    tab[m] = P[l];
                    m++;
                    l++;
                }
                MessageBox.Show(Wypisz(tab));
            }
        }
        static void quickSort(int[] tab, int lewy, int prawy)
        {
            int os = tab[(lewy + prawy) / 2];//stawienie osi/pivota na srodku
            int i, j, swap;
            i = lewy;//ustawienie indexow poczatku tablicy
            j = prawy;//ustawianie indexw konca tablicy
            do
            {
                //oba wskazniki poronuja czy wartosc wskazywana przez nie jest mniejsza wieksza od pivota glownego
                //jesli te na poczatku/po lewej sa mniejsze to wskanznik zasuwa dalej i jesli te po prawejblizej konca sa wieksze to tez zasuwa dalej
                while (tab[i] < os) i++; //tu wskaznik na poczatek tablicy zasuwa w prawo w kierunku jej konca
                while (tab[j] > os) j--;//tu wznik zasuwa od konca do poczatku


                //jesli wskazniki się minęly trzeba dokonac zamiany wartosci pod nimi
                if (i <= j)
                {   //zamiana elementow
                    swap = tab[i];
                    tab[i] = tab[j];
                    tab[j] = swap;

                    MessageBox.Show(Wypisz(tab));

                    i++;// Przesunięcie wskaźnika i w prawo (bo tab[i] już jest poprawnie umieszczony)
                    j--;// Przesunięcie wskaźnika j w lewo (bo tab[j] już jest poprawnie umieszczony)
                }
            } while (i <= j);// Powtarzamy, dopóki wskaźniki się nie miną

            // Sortowanie lekurencyjne lewej  prawej strony
            if (j > lewy)// Jeśli prawy wskaźnik j jest dalej na prawo niż początek tablicy
            {
                quickSort(tab, lewy, j);
                MessageBox.Show(Wypisz(tab));
            }
            if (i < prawy) // Jeśli lewy wskaźnik i jest dalej na lewo niż koniec tablicy
            {
                quickSort(tab, i, prawy);
                MessageBox.Show(Wypisz(tab));
            }
        }
        private void BubbleSort_Click(object sender, EventArgs e)
        {
            int[] tab = { 7, 2, 1, 3, 5, 2, 8 };
            int swap = 0;
            for (int k = 0; k < tab.Length - 1; k++)
            {//tablica -1 aby ostatni porownywany element nie wypadl poza tablica
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    Console.WriteLine(tab[i]);
                    Console.WriteLine(tab[i + 1]);
                    Console.WriteLine(swap);
                    Console.WriteLine();
                    if (tab[i] > tab[i + 1])
                    {
                        //prawa strona jest wczesniejsza niz pozniej
                        //wieczor < -rano
                        swap = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = swap;
                        MessageBox.Show(Wypisz(tab));
                    }
                }
            }
            MessageBox.Show(Wypisz(tab));
        }
        private void InsertSort_Click(object sender, EventArgs e)
        {
            int[] tab1 = { 8, 2, 1, 9, 5 };
            //zakladamy ze el 0 jest posortowany
            //lecimy do konca tablicy bo nie wypadniemy poza zakres wiec nie ma tab.Lenght-1 .
            //Nie porownujemy kolejnego elementu tylko poprzedni wiec z tej strony nie ma zabezbieczenia
            for (int i = 1; i < tab1.Length; i++)
            {
                //ustawiamy wskaznik na el pod 1 indexem
                int wskaznik = tab1[i];
                //zmienna do poruszania sie w tyl po tablicy
                //ustawiana tuz przed wszanikiem po lewej stronie
                int j = i - 1;
                //lecimy od indexu wskaznika(j=i-1) do poczatku 0 indexu tablicy(j<=0) lub jesli wartosc pod indexem na ktory natrafimy jest mneijsza od tego na co wskazuje wskaznik
                //przesuwamy to co jest wieksze od wskaznika w prawo
                for (; j >= 0 && wskaznik < tab1[j]; j--)
                {
                    //przesuwanie wartosci
                    //prawa strona jest wczseniej
                    //wieczor<-rano
                    //tab[1] =8
                    tab1[j + 1] = tab1[j];
                    //0 1 2            0  1  2
                    //8 2,_, 1 9 5--->[8, 8, _, 1, 9, 5]
                }
                //wsadzanie wskaznika na wolne miejsce
                //BO J SIE DEKREMENTUJE GLABIE
                //tab[0]=2
                tab1[j + 1] = wskaznik;

                MessageBox.Show(Wypisz(tab1));
            }
        }
        private void MergeSort_Click(object sender, EventArgs e)
        {
            int[] tab = { 8, 2, 1, 9, 5 };
            mergeSort(tab);

        }
        private void QuickSort_Click(object sender, EventArgs e)
        {
            int[] tab = { 8, 2, 1, 9, 5 };
            quickSort(tab, 0, tab.Length - 1);
        }

        private void CountingSort_Click(object sender, EventArgs e)
        {
            int[] tab = { 1, 1, 5, 2, 2, 1, 5 };

            //znajdowanie najwiekszej wartosci w tablicy aby na jej posdtawie utworzyc tablice zliczającą o zakresie NAjwieksza+1 (bo liczone od 0)
            int Najwieksza = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > Najwieksza)
                {
                    Najwieksza = tab[i];
                }
            }
            //deklaracja tablicy liczikow
            int[] tabLiczników = new int[Najwieksza + 1];
            //deklaracja tablicy wynikkowej
            int[] tabPosortowana = new int[tab.Length];

            //uzuepnienaie tablicy licznikow
            for (int i = 0; i < tabLiczników.Length; i++)
            {
                tabLiczników[i] = 0;
                for (int j = 0; j < tab.Length; j++)
                {
                    //jesli wartosc w tablicy pierwotnej jest taka sama jak index tablicy licznikow to zwiekszamy wartosc w tablicy licznikow
                    if (tab[j] == i)
                    {
                        tabLiczników[i]++;
                    }
                }
            }

            //tu juz mamy tablice licznikow


            //usupelnainie tablicy posortowanej
            for (int i = 0; i < tabPosortowana.Length; i++)
            {
                for (int j = 0; j < tabLiczników.Length; j++)
                {
                    if (tabLiczników[j] != 0)
                    {
                        for (int k = 0; k < tabLiczników[j]; k++)
                        {
                            tabPosortowana[i] = j;
                            i++;
                            MessageBox.Show(Wypisz(tabPosortowana));
                        }
                    }
                }
            }

        }

        private void AddFirst_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dodawanie 1 elementu:");
            Lista lista = new Lista();
            MessageBox.Show("Lista: " + lista.ToString());
            lista.AddFirst(1);
            MessageBox.Show("Lista: " + lista.ToString());
            lista.AddFirst(2);
            MessageBox.Show("Lista: " + lista.ToString());
            lista.AddFirst(3);
            MessageBox.Show("Lista: " + lista.ToString());
            lista.AddFirst(4);
            MessageBox.Show("Lista: " + lista.ToString());
        }

        private void AddLast_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dodawanie ostatniego elementu:");
            Lista lista = new Lista();
            MessageBox.Show("Lista: " + lista.ToString());
            lista.AddLast(1);
            MessageBox.Show("Lista: " + lista.ToString());
            lista.AddLast(2);
            MessageBox.Show("Lista: " + lista.ToString());
            lista.AddLast(3);
            MessageBox.Show("Lista: " + lista.ToString());
            lista.AddLast(4);
            MessageBox.Show("Lista: " + lista.ToString());
        }

        private void RemoveFirst_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista();
            lista.AddLast(1);
            lista.AddLast(2);
            lista.AddLast(3);
            MessageBox.Show("Usuwanie 1 elementu:");
            MessageBox.Show(lista.ToString());
            lista.RemoveFirst();
            MessageBox.Show(lista.ToString());
        }

        private void RemoveLast_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista();
            lista.AddLast(1);
            lista.AddLast(2);
            lista.AddLast(3);
            MessageBox.Show("Usuwanie ostatniego elementu:");
            MessageBox.Show(lista.ToString());
            lista.RemoveLast();
            MessageBox.Show(lista.ToString());
        }

        private void Get_Click(object sender, EventArgs e)
        {

        }

        private void AddFirstTree_Click(object sender, EventArgs e)
        {
            var drzewo = new BST();
            MessageBox.Show(drzewo.ToString());
            drzewo.Add(2);
            drzewo.Add(5);
            drzewo.Add(1);
            drzewo.Add(4);
            MessageBox.Show(drzewo.ToString());
        }

        private void AddLastTree_Click(object sender, EventArgs e)
        {

        }

        private void RemoveFirstTree_Click(object sender, EventArgs e)
        {

        }

        private void RemoveLastTree_Click(object sender, EventArgs e)
        {

        }

        private void GetTree_Click(object sender, EventArgs e)
        {

        }
    }
}
