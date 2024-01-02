using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInheritanceInterfaces.Calculator
{
    public class PositiveNumbersSumCalculator : NumbersSumCalculator
    {
        protected override bool ShallBeAdded(int number)
        {
            return number > 0;
        }
    }
}
