using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class TimeValue
    {
        public delegate double DToD(double arg);
        public static double EvalTimeDToD(int count,DToD fun,double x)
        {
            long start, finish;
            double res = 0;
            start = DateTime.Now.Millisecond;
            for (int i = 1; i < count; i++) fun(x);
            finish = DateTime.Now.Millisecond;
            res = (finish - start);
            return res;
        }
    }
}
