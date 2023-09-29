using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PolyantsevEI.Sprint1.Task7.V25.Lib
{
    public class DataService : ISprint1Task7V25
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Exp(x) - (Math.Pow(y,2) + 6 + Math.Cos(Math.Pow(x,3)) + x * y - 2 * x * x)/(Math.Sin(Math.Pow(x,4)+13) + 9 * y - 2), 3) ;
        }
    }
}
