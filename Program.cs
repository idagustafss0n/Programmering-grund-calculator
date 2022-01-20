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

                //string inmatat1 = Console.ReadLine();
                //double tal1 = double.Parse(inmatat1);


                Console.WriteLine("Välj räknesätt: + | - | * | / ");
                Console.WriteLine("A.  Avsluta");


                /* Frågan om tal2 är inflyttat i varje case. Detta för att kunna få ett snabbare svar om användaren väljer Marcus eller avsluta. Detta medför dock att 
                   koden blir längre och många rader som ser likadana ut. Det hade gått att kontrollera om användaren skrev in Marcus med en if-sats innan switch och om så är 
                   fallet avsluta koden innan switchen.*/

                /* Det går även att göra miniräknaren med flera if-satser. Men jag läste att om det är många if-satser efter varandra som liknar varandra så 
                   rekomenderas en annan metod. */

                /* Då miniräknaren inte har ett visst antal uträkningar innan den tar stopp använder jag lista istället för array  */

                /* Tryparse eller try catch borde ligga med där användaren fyller i information. För att undvika att programmet kraschar*/

                /* De tre case med + - * ser likadana ut i grunden men det skiljer i uträkning och hur den lägger in i listan. Det borde gå 
                   att göra flera case men med samma action. Som med "Marcus" och "MARCUS" där koden gör samma sak oavsett vilken inmatning. 
                   Däremot så hade det krävts if-satser för att sära på räknesätten. Så mitt beslut blev att ha flera olika case även fast mycket 
                   av koden är densamma. Jag tycker att koden blir lättare att läsa och få en överblick på, även fast den är lite längre. */

                menu = Console.ReadLine();

                switch (menu)
                {
                    case "+":
                        Console.WriteLine("Tal 2: ");
                        double tal_addition = double.Parse(Console.ReadLine());

                        double summan = tal1 + tal_addition;

                        /*Skickar in hela uträkningen i listan. Som en string för att få med hela uträkningen. */
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

                        /* I Case med division ligger en if-sats som kontrollerar så inte täljare eller nämnare är 0
                            Här hade det gått att lägga en if-sats i början av case för att direkt plocka om tal1 är 0. Om inte tal1 är 0 så gå vidare och be om tal2*/
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
