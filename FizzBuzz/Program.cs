using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Gra FizzBuzz! Wpisz liczbę podzielną przez 3 i 5.");            

            FizzBuzz fizzBuzz = new FizzBuzz();

            while (true)
            {
                int number = ParseNumber();

                var dividend = fizzBuzz.StartGame(number);

                if (dividend != "FizzBuzz!")
                {                    
                    Console.WriteLine(dividend);
                    continue;
                }
                Console.WriteLine(dividend);
                break;
            }

            Console.ReadLine();
        }
        public static int ParseNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Nieobsługiwany znak. Wpisz poprawną wartość.");
                    continue;
                }
                return number;
            }
        }
    }
}
