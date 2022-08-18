﻿using System;
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
            else if (number % 3 == 0)
                return ("Fizz!");
            else if (number % 5 == 0)
                return ("Buzz!");
            else
                return ($"Wpisałeś {number}.");
        }

    }
}
