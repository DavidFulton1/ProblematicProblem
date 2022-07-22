using System;
using System.Collections.Generic;
using System.Threading;
namespace Debugging {
    internal class Program
    {
        static void Main()
        {

            Random rng=new Random();
            bool cont;
            List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

            Console.WriteLine("Hello, welcome to the random activity generator! Would you like to generate a random activity? yes/no:");
            var conty = Console.ReadLine().ToLower();
            if (conty == "yes")
            {
                cont = true;
            }
            else cont = false;

            Console.WriteLine("");

            Console.Write("We are going to need your information first! What is your name? ");

            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age? ");

            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? please enter Sure/No thanks: ");

            var yn = Console.ReadLine().ToLower();
            if (yn == "sure")
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
            }

            Console.WriteLine();
            Console.Write("Would you like to add any activities before we generate one? yes/no: ");
            var addActivities = Console.ReadLine().ToLower();
            if (addActivities == "yes")
            {
                Console.WriteLine("please enter the activity you wish to add");
              var  newActivity= Console.ReadLine();
                activities.Add(newActivity);
            }

            Console.WriteLine();


            while (cont ==true)
            {
                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                    break;
                }
                Console.WriteLine("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                    break;

                }
                Console.WriteLine();
                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber];
                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do Wine Tasting");
                    Console.WriteLine("Pick something else!");
                    activities.Remove("Wine Tasting");
                     randomNumber = rng.Next(activities.Count-1);
                    randomActivity = activities[randomNumber];
                }
                
                Console.Write($"Ah got it! {randomActivity}, your random activity is: {userName}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                      var kr =Console.ReadLine();
                if (kr == "keep")
                {
                    break;
                }
           
            }
        }
    }
}
            