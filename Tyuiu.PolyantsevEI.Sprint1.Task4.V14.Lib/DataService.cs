using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PolyantsevEI.Sprint1.Task4.V14.Lib
{
    public class DataService : ISprint1Task4V14
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Sqrt(7+Math.Abs(x-y))/3/x/Math.Pow(y, 2), 3);
        }
    }
}
