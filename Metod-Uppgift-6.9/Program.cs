using System;

namespace Uppgift_6_9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Välkommen till programmet, välj ett alternativ");

            while (true)
            {
                Console.WriteLine("1. Är n ett primtal?");
                Console.WriteLine("2. Antalet primtal mindre än n");
                Console.WriteLine("3. Avsluta programmet");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Ange n");
                        if (Prim(int.Parse(Console.ReadLine()))) Console.WriteLine("N är ett primtal");
                        else Console.WriteLine("N är inte ett primtal");
                        break;
                    case "2":
                        Console.WriteLine("Ange n");
                        Console.WriteLine($"Antal primtal som är mindre än n: {MindrePrim(int.Parse(Console.ReadLine()))}");
                        break;
                    case "3":
                        return;
                }
            }
        }

        static bool Prim(int tal)
        {
            for (int i = 2; i < tal - 1; i++)
            {
                if (tal % i == 0) return false;
            }

            return true;
        }

        static int MindrePrim(int tal)
        {
            int resultat = 0;

            for (int i = 2; i < tal; i++)
            {
                if (Prim(i)) resultat++;
            }

            return resultat;
        }
    }
}