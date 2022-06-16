using System;
using System.Collections.Generic;
using System.Linq;

namespace apka
{
    public class Pizza
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public double CenaDodatkow { get; set; }

        public Pizza(string naz, double cena = 10)
        {
            naz = Nazwa;
            cena = Cena;
            

        }

        public void NazwaPizzy()
        {
            Console.WriteLine("Pizza ");
        }


        public double FinalPrice()
        {
            return Cena;
        }


    }

    static void Main(string[] args)
    {
        string[] Dodatki = new string[] { "ser", "szynka", "pieczarki",
        "owoce morza", "oliwki", "ananas", "kurczak"};
        double CenaDodatkow = 2.5;

        // Gdzieś trzeba stworzyć obiekt Pizza. Nie wiem w któym miejscu i jakie metody do niej użyć
        // Tak jakby w naszej aplikacji niepotrzebna jest klasa hmm... 
        // Podziałaj coś z tym kodem może na coś wpadniesz
        Console.WriteLine("Witamy w Pizzeri XYZ :D Ile pizz chciałbyś zamówić");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine("Ile dodatków do {0} pizzy", n);
            int l = Convert.ToInt32(Console.ReadLine());
            // tu tworze petle do wyliczania dodatkow ale doszedłem do wniosku że można wypisać je 
            // na ekranie, policzyć i pomnożyć ilość słów przez cene dodatku
            // na razie pętla została jakbyśmy woleli po kolei dodawać dodatki
            for (int k = 0; k <= l; k++)
            {
                Console.WriteLine("Jakie dodatki chcesz do pizzy (rozdzielone przecinkiem");
               // Console.WriteLine(Dodatki);
                string dodatki = Console.ReadLine();
                string searchTerm = dodatki;

                //Convert the string into an array of words  
                string[] source = dodatki.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

                // Create the query.  Use the InvariantCultureIgnoreCase comparision to match "data" and "Data"
                var matchQuery = from word in source
                                 where word.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
                                 select word;

                // Count the matches, which executes the query.  
                int wordCount = matchQuery.Count();

                var Ilosc = dodatki.Count();
                double CenaKoncowa = 10 + (2.5 * Ilosc);

            }


        }


        Console.ReadKey();
    }
}