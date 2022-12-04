using System;

namespace YAP
{
    class Money
    {
        private int rub, kop;
        private string _rub, _kop;

        public Money() { }
        public Money(string r, string _r)
        {
            rub = int.Parse(r); ///
            _rub = _r;
            if (rub < 0 || kop < 0)
                Console.WriteLine("Не может быть отрицательным!");
        }
        public Money(string r, string _r, string k, string _k)
        {
            rub = int.Parse(r); _rub = _r; ///
            kop = int.Parse(k); _kop = _k; ///
            if(_r != "р.")
            {
                Console.WriteLine("Рубли и копейки перепутаны местами!");
            }
            if (kop > 99)
            {
                int ost = kop / 100;
                rub = rub + ost;
                kop = kop % 100;
            }
            if (rub < 0 || kop < 0)
                Console.WriteLine("Не может быть отрицательным!");
        }
        public void Print()
        {
            if (kop == 0)
               Console.WriteLine($"{rub} {_rub}");
            else if (rub == 0)
                Console.WriteLine($"{kop} {_kop}");
            else
                Console.WriteLine($"{rub} {_rub} {kop} {_kop}");
        }

        public static Money Sum(Money a, Money b)
        {
            Money sum = new Money("0", "р.", "0", "коп.");

            sum.rub = a.rub + b.rub;
            sum.kop = a.kop + b.kop;
                    
            return sum;
        }

        public static Money Difference(Money a, Money b)
        {
            Money diff = new Money("0", "р.", "0", "коп.");

            diff.rub = a.rub - b.rub;
            diff.kop = a.kop - b.kop;

            return diff;
        }
        public void PrintTransferCost(double pr)
        {
            int koppr, kop1, kop2;

            kop1 = rub * 100;
            kop2 = kop1 + kop; 
            koppr = (int)Math.Round(kop2 * pr);
            kop = kop2 + koppr;

            rub = kop / 100;

            kop = kop % 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money("10", "р.");
            money.Print();
            Money money2 = new Money("10", "р.", "101", "коп.");
            money2.Print();
            Console.WriteLine("Summ");
            Money sum = Money.Sum(money, money2);
            sum.Print();
            Console.WriteLine("Diff");
            Money a = new Money("100", "р.", "25", "коп.");
            Money b = new Money("100", "р.", "5", "коп.");
            Money diff = Money.Difference(a, b);
            diff.Print();
            Console.WriteLine("Transfer");
            Money c = new Money("10", "р.", "50", "коп.");
            c.PrintTransferCost(0.05);
            c.Print();
        }
    }
}
