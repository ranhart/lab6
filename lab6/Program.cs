using static lab6.MeowStarter;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kotik1 = new Cat("kotik1");
            kotik1.Meow();
            kotik1.Meow(2);

            var kotik2 = new Cat("kotik2");
            kotik2.Meow();
            kotik2.Meow(4);

            var manyCats = new List<Cat> { kotik1, kotik2 };
            StartMeowing(manyCats);

            var people = new List<IMeowable> { new People("man"), new People("woman"), new Cat("kotik3") };
            StartMeowing(people);

            var kotik1Counted = new MeowCounter(kotik1);
            StartMeowing(new List<IMeowable> { kotik1Counted });
            Console.WriteLine($"вывод: кот мяукал {kotik1Counted.meowCount} раз");

            Fraction f0 = new Fraction(0, 5);
            Fraction f1 = new Fraction(2, 4);
            Fraction f2 = new Fraction(-3, 2);

            Console.WriteLine(f0);

            Console.WriteLine("2/4 + 0/5 = " + (f1 + f0));
            Console.WriteLine("2/4 - -3/2 = " + (f1 - f2));
            Console.WriteLine("-3/2 * 0/5 = " + (f2 * f0));
            Console.WriteLine("-3/2 / 2/4 = " + (f2 / f1));

            Console.WriteLine($"Результат сравнения дробей 1/2 и 1/2: " + Fraction.Equals(new Fraction(1, 2), new Fraction(1, 2)));
            Console.WriteLine($"Результат сравнения дробей 1/2 и 1/3: " + Fraction.Equals(new Fraction(1, 2), new Fraction(1, 3)));

            Fraction f4 = f0.Clone();
            Console.WriteLine("Результат клонирования дроби 0/5"+ f4);

            Console.WriteLine("GetNumerator: " + f4.GetNumerator());
            Console.WriteLine("GetDenominator: " + f4.GetDenominator());
            Console.WriteLine("GetReal: " + f1.GetReal());
        }
    }
}
