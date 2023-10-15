using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SorokinMA.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((((x * x + y * y) <= 4) && ((x >= -2) && (x <= 2) && (y > 0) && y <= 2)) && !(((x * x + y * y) <= 1) && ((x >= -1) && (x <= 1) && (y > 0) && (y <= 1)))) res = true;
            else res = false;
            return res;
        }
    }
}
