using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Inlamningsuppgift2
{
    class Members
    {
        // fält -  här listas alla variabler som kommer att användas
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

        //Här skapas en tom mall 
        public Members()
        {

        }

        // Här skapas en standardiserad mall 
        public Members(string name, int age, string city, string home, string family, string pets, string profession, string hobby, string favFood, string favMusic, string unicProp)
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.home = home;
            this.family = family;
            this.pets = pets;
            this.profession = profession;
            this.hobby = hobby;
            this.favFood = favFood;
            this.favMusic = favMusic;
            this.unicProp = unicProp;
        }

        // Här skapas properties
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
            Console.Title = " Inlämningsuppgift 2";
            Console.WriteLine("Välkommen till informationsportalen om basgrupper!");
            Inlogg();
        }
        static void Inlogg() // whille loop cirkulerar så länge man inte angett coffencode eller matar in q för att avsluta programmet
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
        public static void Menu() // Metod som ger 4 val
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
            List<Members> myMembers = new List<Members>() { Member1, Member2, Member3, Member4, Member5, Member6, Member7, Member8, Member9, Member10 };
            do
            {

                Console.WriteLine("Välj vad du vill göra: \n" +
                    "\n1. Lista alla deltagare" +
                    "\n2. Ta fram detaljer" +
                    "\n3. Radera en deltagare" +
                    "\n4. Avsluta programmet");

                choise = Console.ReadLine();

                switch (choise) // hoppar mellan 1-4 i menyn 
                {
                    case "1": // listar alla deltagare bara med namnparametern i listan myMemberes
                        Console.WriteLine("Du har valt meny 1");
                        foreach (var item in myMembers)
                        {
                            Console.Write($"{item.Name}, ");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("_____________________");
                        Console.ReadKey();
                        break;

                    case "2": // Tar fram hela medlemslistan i nummerordning med jälp av foreach och ber användaren välja en medlem för att ta fram detaljer 
                        Console.WriteLine("Du har valt meny 2");

                        Console.WriteLine("Välj en medlem i listan för att ta fram detaljer:");
                        int i = 0;
                        foreach (var member in myMembers)
                        {
                            i++;
                            Console.WriteLine($"{i}. {member.Name}");
                        }
                        int memberChoise = Convert.ToInt32(Console.ReadLine());
                        memberChoise--;
                        // Omvandlar listan myMembers till en mer semantisk text så att det blir lätt bygga meningar istället att ta fram bara data.
                        Console.WriteLine($"{myMembers[memberChoise].Name} är {myMembers[memberChoise].Age} år gammal och bor i en {myMembers[memberChoise].Home} i {myMembers[memberChoise].City}.");
                        Console.WriteLine($"{myMembers[memberChoise].Name}s familj: {myMembers[memberChoise].Family}. Husdjur: {myMembers[memberChoise].Pets}. Hobby: {myMembers[memberChoise].Hobby}");
                        Console.WriteLine($"{myMembers[memberChoise].Name}s favorit mat: {myMembers[memberChoise].FavFood}");
                        Console.WriteLine($"{myMembers[memberChoise].Name}s favorit musik/band: {myMembers[memberChoise].FavMusic}");
                        Console.WriteLine($"{myMembers[memberChoise].Name}s drivkraft i programmering: {myMembers[memberChoise].UnicProp}");

                        Console.WriteLine("_____________________");
                        Console.ReadKey();
                        break;

                    case "3": // listar fram alla medlemmar och sedan ger användaren val i nummerordning vem ska raderas.
                        Console.WriteLine("Du har valt meny 3");
                        Console.WriteLine("Välj en medlem i listan för att radera:");
                        int x = 0;
                        foreach (var member in myMembers)
                        {
                            x++;
                            Console.WriteLine($"{x}. {member.Name}");
                        }

                        int deleteChoise = Convert.ToInt32(Console.ReadLine());
                        deleteChoise--;
                        Console.WriteLine(myMembers[deleteChoise].Name + " har tagits bort från listan!");
                        myMembers.Remove(myMembers[deleteChoise]);

                        Console.ReadKey();
                        break;

                    default: // säkerställer att valet i menyn ska hamna mellan 1-4, ger annars felmeddelande och ber användaren försöka igen eller avsluta programmet
                        if (choise != "4") { 
                        Console.WriteLine("Fel val av meny. Vänligen välj mellan 1-4");
                        }
                        break;
                }
            } while (choise != "4"); // ett val för att avsluta programmet
        }
    }
}
