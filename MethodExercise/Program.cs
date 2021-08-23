using System;

namespace MethodExercise
{
    class Program
    {
        public static void questions()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {name}. I see your favorite color is {color}, your favorite animal is {animal}, and your favorite band is {band}. ");

        }





        static void Main(string[] args)
        {

            questions();


            

        }
    }
}
