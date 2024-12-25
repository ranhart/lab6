using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class MeowCounter : IMeowable
    {
        private readonly IMeowable _meowable;
        public int meowCount { get; private set; } = 0;

        public MeowCounter(IMeowable meowable)
        {
            _meowable = meowable;
        }
        public void Meow()
        {
            meowCount++;
            _meowable.Meow();
        }
    }
}
