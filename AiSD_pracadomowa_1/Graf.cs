


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace AiSD_pracadomowa_1
{
    internal class Graf
    {
        List<NodeG> nodes;
        List<Edge> edges;

        //jesli nei na staru i enda
        //jesli 
        int IleNowychwezlow(Edge k)
        {
            //jesli 2 to biore przypadek 1. 
            //k.start jest w liscie
            //k.end jest w liscie 
            //contains
            //void Add(Edge k)
            //do listy krawedzi 
            //do listy nodeg 
            //musze sprawdzic czy to jest w liscie wezlow
            //3 ify krawedz,wezek,wezel

            //drugi omowiony nie zanotowalam

            //3. przypadek graf niespojny
            //4. zajdzie gdy cos niespojnego mozna to dac jako dwa przypadki

            //void Join (graf g)
            //g i this
            //for(int i=);i<g.edges;i++)
            //this.Add(g.wezel)

            //kontstruktor
            //graf(edge k){
            //this.Add(k)
            //}

        }
        //cwieki kolejne
        public Element[] AlgorytmDijkstry(NodeG start)
        {
            var tabelka = this.PrzygotujTabelke(start);
            //tabelka  znieskonczonosciami w petli fukcja przygotuj tabelke
            //int.MaxValue;
            var zlS = new List<NodeG>();
            ZnajdzNajmniejszyDystans(tabelka, zlS);
            tabela.Where(e =>)
        }

    }
}
