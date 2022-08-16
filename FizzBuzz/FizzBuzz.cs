using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        public string StartGame()
        {
            Console.WriteLine($"Gra FizzBuzz! Wpisz liczbę podzielną przez 3, 5 lub 3 i 5.");
         
            int number = ParseNumber();

            if (number % 3 == 0 && number % 5 == 0)
                return ("FizzBuzz!");
            else if (number % 3 == 0)
                return ("Fizz!");
            else if (number % 5 == 0)
                return ("Buzz!");
            else
                return ($"Wpisałeś {number}.");
        }
        public static int ParseNumber()
        {
            var number = 0;
            var correct = false;
            while (!correct)
            {
                correct = int.TryParse(Console.ReadLine(), out number);
                if (!correct)
                {
                    Console.WriteLine("Nieobsługiwany znak. Wpisz poprawną wartość.");
                }
            }
            return number;
        }
    }
}
