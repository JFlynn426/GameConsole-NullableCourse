using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class IronBonesDefence : ISpecialDefence
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 5;
        }
    }
}
