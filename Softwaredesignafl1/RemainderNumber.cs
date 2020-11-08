using System;
using System.Collections.Generic;
using System.Text;

namespace Softwaredesignafl1
{
    class RemainderNumber : IChain
    {
        private IChain nextInChain;

        public void setNextChain(IChain nextChain)
        {
            nextInChain = nextChain;
        }

        public void calculate(Numbers request)
        {
            if (request.getCalcWanted() == "remainder")
            {
                Console.WriteLine(request.getNumber1() + " % " + request.getNumber2() + " = " + (request.getNumber1() % request.getNumber2()));
            }
            else
            {
                Console.WriteLine("Dette virker kun for plus, minus, division, gange, pow og remainder");
            }
        }
    }
}