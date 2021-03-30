using System;

namespace Delegates
{
    class Program
    {
        delegate int Operation(int x, int y);
        delegate void Message();
        delegate T Oper<T, K>(K val);
        delegate T Factor<T, K>(K val);
        static void Main(string[] args)
        {
            Console.WriteLine(TimeValue.EvalTimeDToD(500000, Math.Sin, 0.5));
            Console.WriteLine(TimeValue.EvalTimeDToD(500000, Math.Cos, 0.5));
            Console.WriteLine(TimeValue.EvalTimeDToD(500000, Math.Tan, 0.5));
            Console.WriteLine(TimeValue.EvalTimeDToD(500000, Math.Atan, 0.5));
            Operation add = Add;
            Console.WriteLine(add(6, 9));
            Operation sub = Sub;
            Console.WriteLine(sub(6, 9));
            Operation mult = Mult;
            Console.WriteLine(mult(6, 9));
            Message mes = null;
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning;
            }
            else if (DateTime.Now.Hour > 12)
            {
                mes = GoodAftenoon;
            }
            else if (DateTime.Now.Hour > 18)
            {
                mes = GoodEvening;
            }
            mes();
            Oper<decimal, int> oper = Square;
            Console.WriteLine(oper(6));
            Factor<long, int> f = Fact;
            Console.WriteLine(f(5));
            Account account = new Account(200);
            account.Registerhadler(new Account.MessageWarning(Show));
            account.OutPut(150);
            account.OutPut(80);
        }
        public static void Show(string st)
        {
            Console.WriteLine(st);
        }
        public static int Add(int x,int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Mult(int x, int y)
        {
            return x * y;
        }
        public static void GoodMorning()
        {
            Console.WriteLine("Доброе утро");
        }
        public static void GoodEvening()
        {
            Console.WriteLine("Добрый вечер");
        }
        public static void GoodAftenoon()
        {
            Console.WriteLine("Добрый день");
        }
        public static decimal Square(int n)
        {
            return n * n;
        }
        public static long Fact(int n)
        {
            long F = 1;
            for (int i = 1; i <= n; i++) F *= i;
            return F;
        }
    }
}
