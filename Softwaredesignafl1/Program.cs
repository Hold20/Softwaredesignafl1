using System;

namespace Softwaredesignafl1
{
    class Test
    {
        static void Main(string[] args)
        {
            IChain ChainCalc1 = new AddNumber();
            IChain ChainCalc2 = new SubtractNumber();
            IChain ChainCalc3 = new DivideNumber();
            IChain ChainCalc4 = new MultiplyNumber();
            IChain ChainCalc5 = new PowNumber();
            IChain ChainCalc6 = new RemainderNumber();

            ChainCalc1.setNextChain(ChainCalc2);
            ChainCalc2.setNextChain(ChainCalc3);
            ChainCalc3.setNextChain(ChainCalc4);
            ChainCalc4.setNextChain(ChainCalc5);
            ChainCalc5.setNextChain(ChainCalc6);


            Numbers req = new Numbers(100, 2, "remainder");

            ChainCalc1.calculate(req);
        }
    }
}
