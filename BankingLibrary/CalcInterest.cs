using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class CalcInterest:ICalcInterest
    {
        public int Calculate(int Principle, int RateOfInt, int years)
        {
            int SI=(Principle*years*RateOfInt)/ 100;
            return SI;
        }
    }
}
