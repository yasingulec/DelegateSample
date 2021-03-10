using System;

namespace DelegateSample
{
    class Program
    {
        public delegate void DrinkingAction();
        static void Main(string[] args)
        {
            Func<int, int, int> add = (int a, int b) => a + b;
            Console.WriteLine(add(10,20));
            Console.ForegroundColor = ConsoleColor.Green;
            static void DrinkWater()
            {
                Console.WriteLine("Drinking water");
            }
            static void Print()
            {
                Console.WriteLine("falan filan");
            }

            Action PrintAction = () =>Console.WriteLine("bir şeyler");


            static void DrinkBeer( )
            {
                Console.WriteLine("Drinking beer");
            }

            static void DrinkLemonade()
            {
                Console.WriteLine("Drinking lemonade");
            }
           static void RelaxingOnBeach(Action PrintAction)
            {
                Console.WriteLine($"Relaxing on the beach while drinking");
                PrintAction();            
            }
            RelaxingOnBeach(PrintAction);
            RelaxingOnBeach(DrinkBeer);
            RelaxingOnBeach(DrinkLemonade);

        }
       
    }
}
