using System;

namespace FilmoKlasesProjektas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sukuriamas naujas tuščias filmas.
            Filmas filmas = new Filmas();
            
            // Pabandau išvesti filmą į konsolę.
            Console.WriteLine(filmas.ToString);

            Console.WriteLine("Išveda tik klasės pavadinimą, tačiau pačio objekto duomenų - nieko neišveda. TIESA, jis yra tuščias.");


            // SUSIKURIU PILNĄ FILMĄ
            Filmas filmas2 = new Filmas("Baisi naktis", "Siaubo", 102, "Vilandas Znamenskas", 18, 3.6);

            // Pabandau išvesti (netuščią) filmą
            Console.WriteLine(filmas2.ToString());

            Console.WriteLine("Išveda vėlgi tik klasės pavadinimą, nors ir filmas yra PILNAS (su duomenimis), bet tokie išvedimai klasių objektams netiks.... KOL NEPERSIDARYSITE ToString() funkcijos. Apie tai sekančiam projekto pavyzdyje");


            // TOLIAU, BANDOME GAUTI PO VIENĄ FILMO DUOMENĮ IR JĮ IŠVESTI Į KONSOLĘ
            Console.WriteLine("Filmo pavadinimas: " + filmas2.Pavadinimas);
            Console.WriteLine("Filmo zanras: " + filmas2.Zanras);
            Console.WriteLine("Filmo trukmė: " + filmas2.Trukme);
        }
    }
}