using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carins
{
    class Randomidclass
    {
       public int genrandid()
        {
            int j;
            System.Random aa = new Random();
            j = aa.Next(100000000, 999999999);
            return j;
        }
    }
}
