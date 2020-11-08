using System;
using System.Collections.Generic;
using System.Text;

namespace Softwaredesignafl1
{
    class SubtractNumber : IChain
    {
        private IChain nextInChain;

        public void setNextChain(IChain nextChain)
        {
            nextInChain = nextChain;
        }

        public void calculate(Numbers request)
        {
            if (request.getCalcWanted() == "subtract")
            {
                Console.WriteLine(request.getNumber1() + " - " + request.getNumber2() + " = " + (request.getNumber1()-request.getNumber2()));
            }
            else
            {
                nextInChain.calculate(request);
            }
        }
    }
}