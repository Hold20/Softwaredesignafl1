﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Softwaredesignafl1
{
    public class Numbers
    {
        private int number1;
        private int number2;

        private string calculationWanted;

        public Numbers(int newNumber1, int newNumber2, string calcWanted)
        {
            number1 = newNumber1;
            number2 = newNumber2;
            calculationWanted = calcWanted;
        }

        public int getNumber1()
        {
            return number1;
        }

        public int getNumber2()
        {
            return number2;
        }

        public string getCalcWanted()
        {
            return calculationWanted;
        }

    }
}
