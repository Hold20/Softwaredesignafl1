using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Softwaredesignafl1
{
    public interface IChain
    {
        void setNextChain(IChain nextChain);

        void calculate(Numbers request);
    }
}
