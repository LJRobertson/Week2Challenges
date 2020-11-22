using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2ChallengeRepo;

namespace Week2ChallengeConsole
{
    class Program
    {
        static void Main(string[] args)
        {//New up (instantiate) an instance of your Greeter class inside your Main method. From this instance call all of the methods you've built out.
            Greeter callClassGreeter = new Greeter();//new instance of Greeter class
            callClassGreeter.GetUserName("Lindsey");//used new object of Greeter class to call GetUserName method with "." to link to Week2ChallengeRepo.

            string value = callClassGreeter.GetUserName2("Erick");
            Console.WriteLine(value);
            Console.ReadLine();

            callClassGreeter.GoodbyeUserName("Lindsey");

            callClassGreeter.TimeofDay();
            
        }
    }
}
