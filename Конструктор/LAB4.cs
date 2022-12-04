using System;

public class Program
{
    class Money
    {
        public string _rub = "р.", _kop = "коп.";
        public int rub, kop;
        public Money() {  }
        public Money(int r)
        {
            rub = r;
            kop = 0;
            if(kop > 99)
            {
                int ost = kop / 100;
                rub = rub + ost;
                kop = kop % 100;
            }
        }
        public Money(int r, int k)
        {
            rub = r;
            kop = k;
            if (rub < 0 || kop < 0)
                Console.WriteLine("Не может быть отрицательным!");
            else if (kop >99)
            {
                int ost = kop / 100;
                rub = rub + ost;
                kop = kop % 100;
            }
        }
        public void Print()
        {
            if (kop == 0)
                Console.WriteLine($"Сумма: {rub} {_rub}");
            else if (rub == 0)
                Console.WriteLine($"Сумма: {kop} {_kop}");
            else
                Console.WriteLine($"Сумма: {rub} {_rub} {kop} {_kop}");
        }
        //public static Money:Sum(Money a, Money b)
        //{

        //    return Money sum;
        //}
    }
    static void Main()
    {
        int rub = 0, kop = 0;
        string _money = Console.ReadLine();
        string[] kol = _money.Split(' ');
        for(int i = 0; i < 4; ++i)
        {
            rub = int.Parse(kol[0]);
            kop = int.Parse(kol[2]);
        }

        Money money = new Money(rub, kop);
        Money money1 = new Money(rub);
        money.Print();
        money1.Print();
    }
}
