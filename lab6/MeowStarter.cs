using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal static class MeowStarter 
    {
        public static void StartMeowing(IEnumerable<IMeowable> cats)
        {
            foreach (var c in cats)
            {
                c.Meow();
            }
        }
    }
}
