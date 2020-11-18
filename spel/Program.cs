using System;

namespace spel
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dmg = new Random();


            string restart = "";

            while (restart == "") //en loop för att kunna starta om spelet
            {
                int hpyou = 100;
                int hpopponent = 100; //sätter bådas hp till 100

                Console.WriteLine("Welcome to the non-graphic, annual, SWORDS AND SANDALS FIGHT!");

                Console.WriteLine("What is your name, champion");

                string name = Console.ReadLine(); //låter dig bestämma namn

                Console.WriteLine("Fighter one is " + name + ". Figher two is none less than MINNIEEEEEE");

                Console.WriteLine("Commence BATTLEEEEE!");

                while (hpyou > 0 && hpopponent > 0) //i denna loop händer allt slagsmål
                {
                    Console.WriteLine(name + " will you use a heavy or light attack?");

                    int MHIT = dmg.Next(4, 26);

                    int light = dmg.Next(9, 16);

                    int heavy = dmg.Next(4, 26); //allt detta bestämmer hur hårt ditt slag kommer

                    string punch = Console.ReadLine().ToLower(); //låter dig bestämma mellan hårt eller löst slag

                    Console.Clear(); //rensar consolen efter varje attack så den inte blir full med text

                    if (punch == "light") //bestämmer vad som händer om du slår löst
                    {
                        hpopponent -= light;
                        Console.WriteLine("You hit Minnie for " + light + " damage!");
                    }

                    if (punch == "heavy") //om du slår hårt
                    {
                        hpopponent -= heavy;
                        Console.WriteLine("You hit Minnie for " + heavy + " damage!");
                    }

                    if (punch == "instakill") //för att jag inte orkar gå genom hela spelet
                    {
                        hpopponent = 0;
                    }

                    hpyou -= MHIT;

                    Console.WriteLine("Minnie hit you for " + MHIT + " damage!");

                    Console.WriteLine(name + ", you have " + hpyou + " HP left.");

                    Console.WriteLine("Minnie has " + hpopponent + " HP left."); //visar hur mycket skada du gjorde samt hur mycket du tog

                    if (hpyou <= 0)
                    {
                        Console.WriteLine("You've lost the battle champion, be better and don't give up!");
                    }

                    if (hpopponent <= 0)
                    {
                        Console.WriteLine("You won champion, but do you really think you can do it again?");
                    }

                    if (hpopponent <= 0 && hpyou <= 0)
                    {
                        Console.WriteLine("There has been a tie, both of tou have been slain"); //säger till dig om du vann eller förlorade
                    }

                }
                Console.WriteLine("Tryck enter om du vill spela igen, annars skriv NEJ.");

                restart = Console.ReadLine().ToLower(); //låter dig spela igen eller stänga av spelet
            }

        }
    }
}
