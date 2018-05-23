using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("What is your name?: ");
            String name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get last night?: ");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if(hoursOfSleep < 8) {
                Console.WriteLine("You didn't have enough sleep last night!");
            } else {
                Console.WriteLine("You had enough sleep last night!");
            }

            // Console.WriteLine("Hello, " + name);
            // Console.WriteLine("Hello, today is " + DateTime.Now.DayOfWeek);
            // Console.WriteLine("Hello, " + args[0]);
        }
    }
}
