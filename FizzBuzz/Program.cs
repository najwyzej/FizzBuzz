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
                if (fizzBuzz.StartGame(number) != "\nFizzBuzz!")
                {                    
                    Console.WriteLine(fizzBuzz.StartGame(number));
                    continue;
                }
                Console.WriteLine(fizzBuzz.StartGame(number));
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
