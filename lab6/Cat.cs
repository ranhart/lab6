using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab6
{
    internal class Cat : IMeowable
    {
        private string _name { get; set; }

        public Cat(string name)
        {
            _name  = name;
        }

        public override string ToString()
        {
            return $"кот: {_name}";
        }

        public void Meow()
        {
            Console.WriteLine($"{_name}: мяу!");
        }

        public void Meow(int n)
        {
            Console.Write($"{_name}: ");
            for (int i = 1; i <= n; i++)
            {
                if(i == n)
                {
                    Console.WriteLine("мяу!");
                }
                else { Console.Write("мяу-"); }
            }
        }
    }
}
