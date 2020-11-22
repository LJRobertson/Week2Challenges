using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2ChallengeRepo
{
    public class Greeter
    {
        //build a method that takes in a name as a parameter and then outputs to the Console hello to that person.
        public void GetUserName(string userName)
        {
            Console.WriteLine($"Hello {userName}.");
            Console.ReadLine();
        }

        public string GetUserName2(string userName)//this uses a return type of string instead of void
        {
            string Greeting = $"Hello {userName}.";
            return Greeting;
        }

        //build another method that outputs (to Console) some sort of farewell to the name it is given as a parameter.
        public void GoodbyeUserName(string userName)
        {
            Console.WriteLine($"Goodbye {userName}.");
            Console.ReadLine();
        }

        //build a method that outputs (write to Conole) Good Morning/afternoon/Evening/Night depending on the time of day.
        public void TimeofDay()
        {
            DateTime whatTime = DateTime.Now;
            int hour = whatTime.Hour;

            if (hour <= 11)
            {
                Console.WriteLine("Good morning!");
            }
            else if (hour >= 12 && hour < 16)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (hour >= 16 && hour < 20)
            {
                Console.WriteLine("Good evening!");
            }
            else if (hour >= 20 && hour < 24)
            {
                Console.WriteLine("Good night!");
            }
            else
            {
                Console.WriteLine("Is your watch broken?");
            }
            Console.ReadLine();
        }
    }
}
