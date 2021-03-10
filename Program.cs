using System;

namespace DelegateSample
{
    class Program
    {
        //delegateler fonksiyonlar için bir pointerdir, lamda expression ile anonymous functionları contain edebilirler
        public delegate void DrinkingAction();
        static void Main(string[] args)
        {
            //func geriye değer döndürür
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

            //action geriye değer döndürmeyen delegate
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
