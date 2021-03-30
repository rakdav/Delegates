using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Account
    {
        int sum;
        public delegate void MessageWarning(string mes);
        MessageWarning del;
        public void Registerhadler(MessageWarning d)
        {
            del = d;
        }
        public Account(int sum)
        {
            this.sum = sum;
        }
        public int Sum
        {
            get { return sum; }
        }
        public void Put(int n)
        {
            sum += n;
        }
        public void OutPut(int n)
        {
            if (n < sum)
            {
                sum -= n;
                if (del != null)
                {
                    del("Сумма " + n + " была снята");
                }
            }
            else
            {
                if (del != null)
                {
                    del("Сумма превысит остаток");
                }
            }
        }
    }
}
