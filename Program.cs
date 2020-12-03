using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Inlamningsuppgift2
{
    class Members
    {
        private string name;
        private int age;
        private string city;
        private string home;
        private string family;
        private string pets;
        private string profession;
        private string hobby;
        private string favFood;
        private string favMusic;
        private string unicProp;

        public Members()
        {

        }

        public Members(string name, int age, string city, string home, string family, string pets, string profession, string hobby, string favFood, string favMusic, string unicProp)
        {
            this.Name = name;
            this.Age = age;
            this.City = city;
            this.Home = home;
            this.Family = family;
            this.Pets = pets;
            this.Profession = profession;
            this.Hobby = hobby;
            this.FavFood = favFood;
            this.FavMusic = favMusic;
            this.UnicProp = unicProp;
        }

        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Home
        {
            get
            {
                return home;
            }
            set
            {
                home = value;
            }
        }
        public string Family
        {
            get
            {
                return family;
            }
            set
            {
                family = value;
            }
        }
        public string Pets
        {
            get
            {
                return pets;
            }
            set
            {
                pets = value;
            }
        }
        public string Profession
        {
            get
            {
                return profession;
            }
            set
            {
                profession = value;
            }
        }
        public string Hobby
        {
            get
            {
                return hobby;
            }
            set
            {
                hobby = value;
            }
        }
        public string FavFood
        {
            get
            {
                return favFood;
            }
            set
            {
                favFood = value;
            }
        }
        public string FavMusic
        {
            get
            {
                return favMusic;
            }
            set
            {
                favMusic = value;
            }
        }
        public string UnicProp
        {
            get
            {
                return unicProp;
            }
            set
            {
                unicProp = value;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till informationsportalen om basgrupper!");
            Inlogg();
            
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
                
                else if (lösenord == "coffencode")
                {
                    Console.WriteLine("Du är inloggad!");
                    Menu();
                }
                else
                {
                    Console.WriteLine("Fel kod, vänligen försök igen eller ange q + Enter för att avsluta");
                }

            }
        }
        enum menu
        {
            Lista,
            Detaljer,
            Radera
        }

        static void Menu()
        {
            Members Member1 = new Members("Mikael Alexander Larsson", 36, "Vänersborg", "Villa", "Fru, två döttrar och en tredje dotter på väg", "Två kaniner", "Restauranglärare", "Träning och hälsa, surdegsbröd", "Bönchiligryta i tortillabröd", "Elektroniskt. Allt mellan ambient och techno", "Mitt största driv är att det är härligt att få den dagliga hjärngympan man får med programmering, att det är kreativt och att man faktiskt skapar en produkt i slutändan");
            Members Member2 = new Members("Karin Madeleine Karlsson", 35, "Stockholm", "Villa","Smabo och en dotter","Tre katter","ekonomiassistent/testare", "Bakning och spela Stardew Valley ", "Någon form av biff, sötpotatispommes och beanésås", "Just nu, allt som inte är barnvisor", "Har alltid tyckt det är intressant hur system är uppbyggda och hur de skapas, så nu vill jag kunna göra det själv.");
            Members Member3 = new Members("Sammy On Tat Wong", 54, "Åmål", "Villa", "Fru och en son", "3 katter och en hund", "Personlig assistent", "Fotografering, matlagning", "Asiatisk, italiensk, svensk husmanskost", "Soul, RnB, House", " Att kunna skapa någonting själv, problemlösning och tillfredsställelse när man har löst ett problem.");
            Members Member4 = new Members("David Josef Frödin", 25, "Sundbyberg", "Lägenhet", "det vanliga", "inga", "Verksamhetschef på en studentförening", "Leta efter universums hemligheter, målning, lära sig språk", "Bortsch", "Allt! Inne i rockperiod som varvas med rysk folkmusik", "Det är ballt och jag får kombinera kreativitet, problemlösning och människoperspektiv i en trevlig mix");
            Members Member5 = new Members("Rauf Karimli", 36, "Göteborg", "Villa ", "Fru, en son och en dotter", "inga ", "Projektledare ", "Spela piano, laga mat", "Grillat kött", "Gott och blandat", "De gränslösa möjligheterna att utveckla och utvecklas");
            Members Member6 = new Members("Erik Rindlert", 31, "Stockholm", "Lägenhet", "Ogift", "Inga", " IT-support", "Litteratur, datorspel", "Svensk-fransk fisksoppa", "Schubert eller Darkthrone, beroende på dag", "Bygga, bygga, bygga");
            Members Member7 = new Members("Daniel Jacob Arlbrin", 24, "Alingsås", "lägenhet", "Sambo", "Inga", "Väktare", "Motorsport/datorspel", "Italienskt", "House", "Saknas");
            Members Member8 = new Members("Svante Joelsson", 36, "Strömstad", "Lägenhet", "Sambo och en son", "Hund", "Fritidspedagog/Förskolelärare", "Illustrera Animera", "Pasta al fungi", "Gubbrock och allt som är bra", "Kul combo av problemlösning och kreativitet, och att en dag landa ett jobb med mer frihet");
            Members Member9 = new Members("Sarah Winroth", 31, "Vara ", "Lägenhet ", "Gift ", "Inga ", "Reseledare ", "Motionerar", "Älskar mat i alla former", " Lyssnar på det mesta", "Själva problemlösningen och tillfredsställelsen efteråt");
            Members Member10 = new Members("Farzane Zafarzade", 32, "Karlstad", "lägenhet", "Gift ", "Inga ", "IT-support", "Träning och bakning", "Alla typer av pastarätter", "lugna och klassikermusik", "Problemlösning, inom att lösa problem man lär sig att bli mer tålmodig och kreativ.");

                string choise = null;
            do
            {

                Console.WriteLine("Välj vad du vill göra: \n" +
                    "\n1. Lista alla deltagare" +
                    "\n2. Ta fram detaljer" +
                    "\n3. Radera en deltagare" +
                    "\n4. Avsluta programmet");

                choise = Console.ReadLine();

                List<Members> myMembers = new List<Members>() { Member1, Member2, Member3, Member4, Member5, Member6, Member7, Member8, Member9, Member10 };

                switch (choise)
                {
                    case "1":
                        Console.WriteLine("Du har valt meny 1");
                        foreach (var item in myMembers)
                        {
                            Console.Write($"{item.Name}, ");
                        }
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Du har valt meny 2");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Du har valt meny 3");
                        Console.ReadKey();
                        break;

                    default:
                        if (choise != "4") { 
                        Console.WriteLine("Fel val av meny");
                        }
                        break;

                }
            } while (choise != "4");
        }
    }

}
