using System;
using System.Collections.Generic;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;

            List<string> lista = new List<string>();

            Console.WriteLine("Välkommen till denna fantastiska miniräknare!");
            do {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("Tal 1: ");

                double tal1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Välj räknesätt: + | - | * | / ");
                Console.WriteLine("A.  Avsluta");

                menu = Console.ReadLine();

                switch (menu)
                {
                    case "+":
                        Console.WriteLine("Tal 2: ");
                        double tal_addition = double.Parse(Console.ReadLine());

                        double summan = tal1 + tal_addition;

                        lista.Add(tal1+"+"+ tal_addition + "="+summan);

                        Console.WriteLine("Summan av tal " + tal1 + " + " + tal_addition + " = " + summan);
                        
                        Console.WriteLine("\nAlla uträkningar hittills:");
                       for(int i = 0; i < lista.Count; i++)
                        {
                            Console.WriteLine(lista[i]);
                        }

                        break;

                    case "-":
                        Console.WriteLine("Tal 2: ");
                        double tal_subraktion = double.Parse(Console.ReadLine());


                        double differens = tal1 - tal_subraktion;

                        lista.Add(tal1 + "-" + tal_subraktion + "=" + differens);

                        Console.WriteLine("Differensen  av tal " + tal1 + " - " + tal_subraktion + " = " + differens);

                        Console.WriteLine("\nAlla uträkningar hittills:");
                        for (int i = 0; i < lista.Count; i++)
                        {
                            Console.WriteLine(lista[i]);
                        }

                        break;

                    case "*":
                        Console.WriteLine("Tal 2: ");
                        double tal_multiplikation = double.Parse(Console.ReadLine());


                        double produkt = tal1 * tal_multiplikation;

                        lista.Add(tal1 + "*" + tal_multiplikation + "=" + produkt);

                        Console.WriteLine("Produkten av tal " + tal1 + " * " + tal_multiplikation + " = " + produkt);

                        Console.WriteLine("\nAlla uträkningar hittills:");
                        for (int i = 0; i < lista.Count; i++)
                        {
                            Console.WriteLine(lista[i]);
                        }

                        break;

                        
                    case "/":
                        Console.WriteLine("Tal 2: ");
                        double tal_division = double.Parse(Console.ReadLine());


                        if (!(tal1==0 || tal_division == 0))
                        {
                            double kvot = tal1 / tal_division;

                            lista.Add(tal1 + "/" + tal_division + "=" + kvot);

                            Console.WriteLine("Kvoten  av tal " + tal1 + " / " + tal_division + " = " + kvot);

                            Console.WriteLine("\nAlla uträkningar hittills:");
                            for (int i = 0; i < lista.Count; i++)
                            {
                                Console.WriteLine(lista[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Det går inte att använda 0 i division. Börja gärna om med andra tal."); 
                        }

                        break;

                    case "Marcus": case "MARCUS":
                        Console.WriteLine("Hej!");
                        Environment.Exit(0);
                        break;

                }
            }
            while (menu!="A");

            Console.ReadLine();


        }
    }
}
