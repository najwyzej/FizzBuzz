using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        public string StartGame(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return ("FizzBuzz!");
            if (number % 3 == 0)
                return ("Fizz! Liczba podzielna przez 3. Graj dalej:");
            if (number % 5 == 0)
                return ("Buzz! Liczba podzielna przez 5. Graj dalej:");

                return ($"Wpisałeś {number}. Spróbuj wpisać inną liczbę:");
        }

    }
}
