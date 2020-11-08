using System;
using System.Collections.Generic;
using System.Text;

namespace Softwaredesignafl1
{
    class PowNumber : IChain
    {
        private IChain nextInChain;

        public void setNextChain(IChain nextChain)
        {
            nextInChain = nextChain;
        }

        public void calculate(Numbers request)
        {
            if (request.getCalcWanted() == "pow")
            {
                Console.WriteLine(request.getNumber1() + "^" + request.getNumber2() + " = " + Math.Pow(request.getNumber1(),request.getNumber2()));
            }
            else
            {
                nextInChain.calculate(request);
            }
        }
    }
}