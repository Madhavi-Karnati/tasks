using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensions
{
    public static class counting
    {
        public static int count_digits(this int num)        {
            int count = 0;
            while (num != 0)
            {
                count++;
                num = num / 10;
            }
            return count;
        }
    }
}
