using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_Objekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciranje objekta
            Osoba osoba = new Osoba();
            osoba.SetIme("Pero");
            osoba.SetPrezime("Perić");
            osoba.SetGodRodjenja(2005);
            osoba.SetVisina(179);
            osoba.SetTezina(89);
            osoba.SetSpol('M');

            //Ispis podataka
            Console.WriteLine("Osoba1");
            Console.WriteLine("Ime i Prezime: "+ osoba.GetIme()+ " " + osoba.GetPrezime()
                + "\r\nGodina rodjenja: " + osoba.GetGodRodjenja() 
                + "\r\nVisina: " + osoba.GetVisina() 
                + "\r\nTezina: " + osoba.GetTezina() 
                + "\r\nSpol: " + osoba.GetSpol());

            //instanciranje objekta 2 
            Osoba osoba2 = new Osoba("Ana", "Anić", 2001, 164, 62, 'Ž');

            Console.WriteLine("\r\nOsoba2"); 
            Console.WriteLine(osoba2.Ispis());

            Console.WriteLine("\r\nOsoba2 - override");
            Console.WriteLine(osoba2.ToString());

            Console.ReadKey();

        }
    }

    class Osoba
    {
        //Svojstva 
        string Ime, Prezime;
        int GodRodjenja, Visina, Tezina;
        char Spol;

        //Metode

        //Set metode - služe za postavljanje vrijednosti svojstva
        public void SetIme(string Ime)
        {
            this.Ime = Ime;
        }
        public void SetPrezime(string Prezime)
        {
            this.Prezime = Prezime;
        }
        public void SetGodRodjenja(int GodRodjenja)
        {
            this.GodRodjenja = GodRodjenja;
        }
        public void SetVisina(int Visina)
        {
            this.Visina = Visina;
        }
        public void SetTezina(int Tezina)
        {
            this.Tezina = Tezina;
        }
        public void SetSpol(char Spol)
        {
            this.Spol = Spol;
        }
        //Get metode - služe za čitasnje vrijednosti svojstva
        public string GetIme()
        {
            return this.Ime; 
        }
        public string GetPrezime()
        {
            return this.Prezime;
        }
        public int GetVisina()
        {
            return this.Visina;
        }
        public int GetTezina()
        {
            return this.Tezina;
        }
        public int GetGodRodjenja()
        {
            return this.GodRodjenja;
        }
        public char GetSpol()
        {
            return this.Spol;
        }
        //Metode za ispis
        public string Ispis()
        {
            string ispis = "Ime i Prezime: " + this.GetIme() + " " + this.GetPrezime()
                + "\r\nGodina rodjenja: " + this.GetGodRodjenja()
                + "\r\nVisina: " + this.GetVisina()
                + "\r\nTezina: " + this.GetTezina()
                + "\r\nSpol: " + this.GetSpol();
                return ispis;   
        }

        public override string ToString()
        {
            string ispis = "Ime i Prezime: " + this.GetIme() + " " + this.GetPrezime()
                + "\r\nGodina rodjenja: " + this.GetGodRodjenja()
                + "\r\nVisina: " + this.GetVisina()
                + "\r\nTezina: " + this.GetTezina()
                + "\r\nSpol: " + this.GetSpol();
            return ispis;
        }

        //Konstruktori

        public Osoba()
        {

        }

        public Osoba(string ime, string Prezime, int GodRodjenja, 
            int Tezina, int Visina, char Spol)
        {
            this.Ime = ime;
            this.Prezime = Prezime;
            this.GodRodjenja = GodRodjenja;
            this.Tezina = Tezina;
            this.Visina = Visina;
            this.Spol = Spol;
        }

        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
    }
}
