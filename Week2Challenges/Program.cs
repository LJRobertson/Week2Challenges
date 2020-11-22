using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{//build a class called Greeter
    public class Greeter
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime.ToString("%hh"));
            Console.ReadLine();
            // int currentTime = int.Parse(DateTime.Now);

            //if (currentTime <= 11)
            //{
            //    Console.WriteLine("Good morning!");
            //}

            //else if (currentTime > 11 && currentTime < 16)
            //{
            //    Console.WriteLine("Good afternoon!");
            //}
            //else if (currentTime >= 16 && currentTime < 20)
            //{
            //    Console.WriteLine("Good evening!");
            //}
            //else if (currentTime >= 20 && currentTime < 24)
            //{
            //    Console.WriteLine("Good night!");
            //}
            //else
            //{
            //    Console.WriteLine("Is your watch broken?");
            //}
            Console.ReadLine();

        }
        //inside out new class, build a method that takes in a name as a parameter and then outputs to console hello to that person.

        public void GetUserName()
        {
            Console.WriteLine("What is your name?\n");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}.");
            Console.ReadLine();

        }
        //public void GetUserName()
        // {
        //Console.WriteLine($"Goodbye {userName}.");
        // Console.ReadLine();

        // }
        //Build another method that outputs (writes to Console) some sort of farewell to the name it is given as a parameter

        //Build a method that outputs (write to the Console) Good Morning/Afternoon/Evening?night depending on the time of day.

        public void TimeofDay()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime.ToString("%h"));
            Console.ReadLine();
           // int currentTime = int.Parse(DateTime.Now);

            //if (currentTime <= 11)
            //{
            //    Console.WriteLine("Good morning!");
            //}

            //else if (currentTime > 11 && currentTime < 16)
            //{
            //    Console.WriteLine("Good afternoon!");
            //}
            //else if (currentTime >= 16 && currentTime < 20)
            //{
            //    Console.WriteLine("Good evening!");
            //}
            //else if (currentTime >= 20 && currentTime < 24)
            //{
            //    Console.WriteLine("Good night!");
            //}
            //else
            //{
            //    Console.WriteLine("Is your watch broken?");
            //}
            Console.ReadLine();
        }

    }

   

    

    //new up (instantiate) an instance of your Greeter class inside your main method. From this instance, call all of the methods you've built out.

}
