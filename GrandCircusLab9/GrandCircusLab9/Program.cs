using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about?");
            while (true)
            {
                ReturnInfo();
                Console.WriteLine($"Would you like to learn about another student? (y/n)");
                string answer = Convert.ToString(Console.ReadLine().ToLower());
                if (answer == "yes" || answer == "y")
                {
                    Console.WriteLine("Which student would you like to learn more about?");
                    continue;
                }
                else if (answer == "no" || answer == "n")
                {
                    break;
                }
            }


        }
                
        static void ReturnInfo()
        {
            List<string> studentName = new List<string>() {"Abby Wessels", "Blake Shaw", "Bob Valentic", "Jay Stiles", "Jon Shaw", "Jordan Owiesny", "Joshua Zimmerman", "Lin-Z Chang", "Madelyn Hilty", "Michael Hern", "Nana Banahene", "Rochelle Toles", "Shah Shahid", "Taylor Everts", "Tim Broughton"};
            List<string> studentHometown = new List<string>() { "Traverse City, MI", "Los Angeles, CA", "St. Clair Shores, MI", "Macomb, MI", "Huntington Woods, MI", "Warren, MI", "Taylor, MI", "Toledo, OH", "Oxford, MI", "Canton, MI", "Guana", "Mars", "The Brick City", "Caro, MI", "Detroit, MI" };
            List<string> studentFood = new List<string>() { "Soup", "Cannolis", "Pizza", "Pickles", "Ribs", "Burgers", "Turkey", "Ice Cream", "Croissant", "Chicken Wings", "Empanadas", "Space Cheese", "Chicken Wings", "Cordon Bleu", "Chicken Parm" };
            List<string> studentMusic = new List<string>() { "Vaporwave", "Indie", "Shoegaze", "Classic Rock", "Classic Rock", "Hip-Hop", "Orchestral", "Folk/Indie", "Celtic", "90's Alternative", "Jazz", "Techno", "Rap/Hip-Hop", "Pop", "Tibetan Throat Singing" };
            Console.WriteLine($"(enter a number between 1-{studentName.Count()} or type '1212' to see all your options. To add a student type '313')");
            int input;
            while (true)
            {

                bool isNum = int.TryParse((Console.ReadLine()), out input);
                if (input == 1212)
                {
                    for (int i = 0; i < studentName.Count(); i++)
                    {
                        Console.WriteLine($"Student {i + 1}: {studentName[i]}");
                    }
                    Console.WriteLine($"Which student would you like to learn more about? \n(enter a number between 1-{studentName.Count()} or enter 1212 to see all your options. To add a student type '313')");
                    continue;
                }
                else if (input == 313)
                {
                    AddStudent(studentName, studentHometown, studentFood, studentMusic);
                    Console.WriteLine("Thanks for filling out the answers! \nYour student has been added!");
                    Console.WriteLine($"(enter a number between 1-{studentName.Count()} or enter 1212 to see the updated student list. To add another student type '313')");
                    continue;
                }
                else if (input < 1 || input > 15)
                {
                    Console.WriteLine($"That student does not exist. Please try again. (enter a number between 1-{studentName.Count()} or enter 1212 to see all your options. To add a student type '313')");
                    continue;
                }
                else if (isNum == false)
                {
                    Console.WriteLine("That is not a valid response. Please try again.");
                    continue;
                }
                break;
            }
            int studentNumber = --input;
            

            while (true)
            {
                StudentInfo(studentName, studentHometown, studentFood, studentMusic, studentNumber);
                Console.WriteLine($"Would you like to know more about {studentName[studentNumber]}? (y/n)");
                string answer2 = Convert.ToString(Console.ReadLine().ToLower());
                if (answer2 == "yes" || answer2 == "y")
                {
                    continue;
                }
                else if (answer2 == "no" || answer2 == "n")
                {
                    break;
                }
            }

        }

        static void StudentInfo(List<string> name, List<string> hometown, List<string> food, List<string> music, int value)
        {
            List<string> studentName = name;
            List<string> studentHometown = hometown;
            List<string> studentFood = food;
            List<string> studentMusic = music;
            int studentNumber = value;

            Console.WriteLine($"What would you like to know about {studentName[studentNumber]}?\nYour options are:\nHometown (type: hometown)\nFavorite Food (type: food)\nFavorite Music Genre (type: music)");

            while (true)
            {
                string answer = Convert.ToString(Console.ReadLine().ToLower());
                if (answer == "hometown")
                {
                    Console.WriteLine($"{studentName[studentNumber]}'s hometown is {studentHometown[studentNumber]}.");
                }
                else if (answer == "food")
                {
                    Console.WriteLine($"{studentName[studentNumber]}'s favorite food is {studentFood[studentNumber]}.");
                }
                else if (answer == "music")
                {
                    Console.WriteLine($"{studentName[studentNumber]}'s favorite genre of music is {studentMusic[studentNumber]}.");
                }
                else
                {
                    Console.WriteLine("That is not a valid response. Please try again");
                    continue;
                }
                break;

            }


        }

        static void AddStudent(List<string> name, List<string> hometown, List<string> food, List<string> music)
        {
            Console.WriteLine("What is the name of the student you want to add?");
            while (true)
            {
                string nameResponse = Console.ReadLine();
                bool isString = string.IsNullOrWhiteSpace(nameResponse);
                if (isString)
                {
                    Console.WriteLine("You need to enter a name!");
                    continue;
                }
                else if(!isString)
                {
                    name.Add(nameResponse);
                    break;
                }
            }

            Console.WriteLine("What is the hometown and state of the student you want to add?");
            while (true)
            {
                string hometownResponse = Console.ReadLine();
                bool isString = string.IsNullOrWhiteSpace(hometownResponse);
                if (isString)
                {
                    Console.WriteLine("You need to enter a town!");
                    continue;
                }
                else if (!isString)
                {
                    hometown.Add(hometownResponse);
                    break;
                }
            }

            Console.WriteLine("What is the favorite food of the student you want to add?");
            while (true)
            {
                string foodResponse = Console.ReadLine();
                bool isString = string.IsNullOrWhiteSpace(foodResponse);
                if (isString)
                {
                    Console.WriteLine("You need to enter a favorite food!");
                    continue;
                }
                else if (!isString)
                {
                    food.Add(foodResponse);
                    break;
                }
            }

            Console.WriteLine("What is the favorite music genre of the student you want to add?");
            while (true)
            {
                string musicResponse = Console.ReadLine();
                bool isString = string.IsNullOrWhiteSpace(musicResponse);
                if (isString)
                {
                    Console.WriteLine("You need to enter a name!");
                    continue;
                }
                else if (!isString)
                {
                    music.Add(musicResponse);
                    break;
                }
            }
            
        }
    }
}
