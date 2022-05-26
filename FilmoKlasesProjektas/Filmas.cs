using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmoKlasesProjektas
{
    internal class Filmas
    {
        // Klasės kintamieji
        private string pavadinimas;
        private string zanras;
        private int trukme;
        private string rezisierius;
        private int amziausCenzas;
        private double reitingas;

        // Konstruktoriai 
        // PILNAS konstruktorius
        public Filmas(string pavadinimas, string zanras, int trukme, string rezisierius, int amziausCenzas, double reitingas)
        {
            this.pavadinimas = pavadinimas;
            this.zanras = zanras;
            this.trukme = trukme;
            this.rezisierius = rezisierius;
            this.amziausCenzas = amziausCenzas;
            this.reitingas = reitingas;
        }

        // TUŠČIAS konstruktrius
        public Filmas()
        {
        }

        // GALI BŪTI DAR KITOKIŲ KONSTRUKTORIŲ, JEIGU JŲ REIKIA.

        // TOLIAU BŪTŲ GETTERIAI SETTERIAI
        public string Pavadinimas 
        {
            get
            {
                return pavadinimas;
            }
            set
            {
                this.pavadinimas = value;
            }
        }
        public string Zanras
        {
            get
            {
                return zanras;
            }
            set
            {
                zanras = value;
            }
        }
        public int Trukme 
        {
            get { return trukme; }
            set { trukme = value; }
        }
        public string Rezisierius 
        {
            get { return rezisierius; }
            set { rezisierius = value; }
        }
        public double Reitingas 
        {
            get { return reitingas;}
            set { reitingas = value; }
        }
        public int AmziausCenzas 
        {
            get { return amziausCenzas;}
            set { amziausCenzas = value; }
        }

        // TOLIAU BŪTŲ KITI KLASĖS METODAI/FUNKCIJOS


    }
}
