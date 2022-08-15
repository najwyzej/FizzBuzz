using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        public void StartGame()
        {
            Console.WriteLine($"Witaj w grze FizzBuzz!{Environment.NewLine}Wpisz liczbę podzielną przez 3, 5 lub 3 i 5. " +
                                $"Jeśli twoja liczba bedzie podzielna przez 3 wyswietli sie napis Fizz, jesli przez 5 wyswietli sie 'Buzz'. " +
                                $"Jesli bedzie podzielna przez 3 i 5 wyswietli sie 'FizzBuzz!'.");
            int number;
            do
            {
                number = ParseNumber();
                if (number % 3 == 0 && number % 5 == 0)
                    Console.WriteLine("FizzBuzz!");
                else if (number % 3 == 0)
                    Console.WriteLine("Fizz!");
                else if (number % 5 == 0)
                    Console.WriteLine("Buzz!");
                else
                    Console.WriteLine($"Wpisałeś {number}. Spróbuj wpisać inną liczbę.");
            } while (!(number % 3 ==0 && number % 5 == 0));
            Console.ReadLine();
        }
        private static int ParseNumber()
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
