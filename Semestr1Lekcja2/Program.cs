using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1Lekcja2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Kartoteka pacjenta

            string imie = "Kamil";
            string nazwisko = "Nowak";
            int wiek = 21;
            string telefon = "123-123-425";
            int pesel = 1241254252;
            string mail = "pacjent@gmail.com";
            string miejsceZamieszkania = "Kraków";
            double waga = 80.4;
            float temperatura = 36.6f;
            decimal kosztLeczenia = 120.50m;
            char plec = 'm';
            bool czyPalacy = true;

            // SKŁADNIA DEKLARACJI ZMIENNYCH
            // TYP nazwa = wartość;

            //TYPY ZMIENNYCH

            //string - przechwuje ciąg znaków np. "Ala ma kota"
            //char - jeden pojedynczy znak  'a'  'm'  '&'

            //int - przechowuje liczby całkowite np. 1 10 -40
            //double - przechowuje liczby zmiennoprzecinkowe np. 15.5
            //float - przechowuje liczby zmiennoprzecinkowe np 10.5f 
            //decimal - przechowuje liczby zmiennoprzecinkowe np. 1.2m

            //bool - przechowuje wartość logiczną true lub false (0 lub 1)

            imie = "Karol";
            imie = "Adam";
            Console.WriteLine("KARTOTEKA PACJENTA NR"+pesel);
            Console.WriteLine();
            Console.WriteLine("Imię pacjenta: "+imie);
            Console.WriteLine("Nazwisko pacjenta: "+nazwisko);
            Console.WriteLine("Mam {0} lat, mój numer to {1}", wiek, telefon);
            Console.WriteLine($"Mail: {mail}, Miejsce zamieszkania: {miejsceZamieszkania}");
            Console.WriteLine("temperatura ciała: {0}", temperatura);
            Console.WriteLine("waga ciała: {0}", waga);
            Console.WriteLine("koszt leczenia: {0}", kosztLeczenia);
            Console.WriteLine("płeć: {0}", plec);
            Console.WriteLine("czy osoba pali: {0}", czyPalacy);


            //SPOSOBY WYPISYWANIA DANYCH
            //1.konkatenacja
            // Console.WriteLine("Imię pacjenta: "+imie);
            //2.argumentowy
            // Console.WriteLine("Mam {0} lat, mój numer to {1}", wiek, telefon);
            //3.interpolacja
            // Console.WriteLine($"Mail: {mail}, Miejsce zamieszkania: {miejsceZamieszkania}");


            //STAŁE
            //Składnia stałych
            // const TYP nazwa = wartość;

            Console.WriteLine();  
            const double PI = 3.14;
            const string IMIE2 = "Karol";

            //IMIE2 = "Kamil"; STAŁYCH NIE MOŻNA EDYTOWAĆ PO ZADEKLAROWANIU
            Console.WriteLine("LICZBA PI WYNOSI: "+PI);

            Console.ReadLine();
        }
    }
}
