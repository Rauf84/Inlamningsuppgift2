using System;
using System.ComponentModel.Design;

namespace Inlamningsuppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till informationsportalen om basgrupper!");
            Inlogg();
            //Menu();
        }

        static void Inlogg()
        {
            string lösenord = "";

            while (lösenord != "coffencode")
            {
                Console.Write("Vänligen ange kod: ");
                lösenord = Console.ReadLine();
                if (lösenord == "q")
                {
                    Console.WriteLine("Tack och välkommen åter!");
                    break;
                }
                
                if (lösenord == "coffencode")
                {
                    Console.WriteLine("Du är inloggad!");
                }
                else
                {
                    Console.WriteLine("Fel kod, vänligen försök igen eller ange q + Enter för att avsluta");

                }

            }
        }

       /* static void Menu()
        {
            enum menu
             {
                 coffencodeGroup = 1,
                 memberDetails = 2,
             }
        }*/
    }

}
