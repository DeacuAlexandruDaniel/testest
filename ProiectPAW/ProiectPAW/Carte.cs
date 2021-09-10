using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace ProiectPAW
{
    class Carte :ICloneable, IComparable
    {
        private readonly int cod;
        private string titlu;
        private string autor;
        private string gen;
        private DateTime dataPublicare;

        public int Cod => cod;

        public string Titlu { get => titlu; set { if (value != null) titlu = value; } }
        public string Autor { get => autor; set { if (value != null) autor = value; } }
        public string Gen { get => gen; set { if (value != null) gen = value; } }

        //Constructor fara parametri
        public Carte()
        {
            cod = 0;
            titlu = null;
            autor = null;
            gen = null;
        }

        //Constructor cu parametri
        public Carte (int c, string t, string a, string g, int an, int luna, int zi)
        {
            cod = c;
            if (t != null) 
            {
                titlu = t;
            }
            if (a != null)
            {
                autor = null;
            }
            if (g != null)
            {
                gen = null;
            }
            dataPublicare = new DateTime(an, luna, zi);
        }

        //Implementare Clone
        public object Clone()
        {
            Carte clona = (Carte)this.MemberwiseClone();
            clona.titlu = titlu;
            clona.autor = autor;
            clona.gen = gen;
            clona.dataPublicare = dataPublicare;
            return clona;
        }

        //Implementare Comparable
        public int CompareTo(object obj)
        {
            return cod.CompareTo(obj);
        }

        public override string ToString()
        {
            string rezultat =  base.ToString();
            rezultat = "Cartea " + titlu + " are codul " + cod + ". Aceasta este scrisa de " + autor + " in data de " + dataPublicare + " si apartine genului " + gen + ".";
            return rezultat;
        }
    }
}

