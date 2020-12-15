using System;
using static System.Console;
using System.IO;

namespace CS__AnfrageLagerlist
{
    class Artikel
    {
        private int Artikelnummer;
        private double Menge, Preis;
        private string Artikelbezeichnung, Mengeneinheit;

        public Artikel(int ANr, Double NewAmount)
        {
            Loading();
            //Check(NewAmount);
        }
        public Artikel(int ANr, Double NewAmount, Double Price, String Designation , String UnitOfMeasure)
        {
            Artikelnummer = ANr;
            Menge = NewAmount;
            Preis = Price;
            Artikelbezeichnung = Designation;
            Mengeneinheit = UnitOfMeasure;
        }

        private void Check(Double NewAmount)
        {
            if(NewAmount >= 0)
            {
                Additions(NewAmount);
            }
            else if(NewAmount < 0)
            {
                Withdrawal(NewAmount);
            }
        }
        private void Additions(double plusvalue)
        {
            Menge += plusvalue;
        }
        private void Withdrawal(double negativevalue)
        {
            Menge -= negativevalue;
        }
        private void Saving()
        {
            //FileInfo fileInfo = new FileInfo("Artikel.txt");
            //FileStream fileStream = fileInfo.Open(FileMode.Append, FileAccess.Write);
        }
        private void Loading()
        {
            //FileInfo fileInfo = new FileInfo("techcoil.txt");
            //FileStream fileStream = fileInfo.Open(FileMode.Open, FileAccess.Read);
            //if (fileInfo.Exists)
            //{
            //    WriteLine("techcoil.txt does exists.");
            //}
            //else
            //{
            //    WriteLine("techcoil.txt does not exists.");
            //}
        }
        public void Output()
        {
            WriteLine("Artikelnummer      " + Artikelnummer);
            WriteLine("Menge              " + Menge);
            WriteLine("Preis              " + Preis + "€");
            WriteLine("Artikelbezeichnung " + Artikelbezeichnung);
            WriteLine("Mengeneinheit      " + Mengeneinheit);
            WriteLine();
        }
    }
    class Program
    {
        private static int Artikelnummer;
        private static double Menge, Preis;
        private static string Artikelbezeichnung, Mengeneinheit;
        public static void Input()
        {
            WriteLine("Bitte eine Artikelnummer festlegen : ");
            while (!Int32.TryParse(ReadLine(), out Artikelnummer))
            {
                Clear();
                WriteLine("Bitte eine Artikelnummer festlegen : ");
            }

            WriteLine("Bitte eine Artikel anzahl festlegen : ");
            while (!Double.TryParse(ReadLine(), out Menge))
            {
                Clear();
                WriteLine("Bitte eine Artikel anzahl festlegen : ");
            }

            WriteLine("Bitte einen Preis festlegen : ");
            while (!Double.TryParse(ReadLine(), out Preis))
            {
                Clear();
                WriteLine("Bitte einen Preis festlegen : ");
            }
            WriteLine("Bitte eine Artikelbezeichnung festlegen : ");
            Artikelbezeichnung = ReadLine();
            WriteLine("Bitte die Mengeneinheit festlegen : ");
            Mengeneinheit = ReadLine();
        }
        static void Main(string[] args)
        {
            Input();
            Clear();
            Artikel Artikel0 = new Artikel(Artikelnummer, Menge, Preis, Artikelbezeichnung, Mengeneinheit);

            Input();

            Clear();
            Artikel Artikel1 = new Artikel(Artikelnummer, Menge, Preis, Artikelbezeichnung, Mengeneinheit);

            Input();
            Clear();
            Artikel Artikel2 = new Artikel(Artikelnummer, Menge, Preis, Artikelbezeichnung, Mengeneinheit);

            Artikel0.Output();
            Artikel1.Output();
            Artikel2.Output();
        }
    }
}
