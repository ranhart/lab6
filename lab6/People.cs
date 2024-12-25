using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class People : IMeowable
    {
        private string _name {  get; set; }
        public People(string name) { _name = name; }
        public void Meow()
        {
            Console.WriteLine($"{_name}: МЯУ!");
        }
    }
}
