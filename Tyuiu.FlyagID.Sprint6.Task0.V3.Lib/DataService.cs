using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FlyagID.Sprint6.Task0.V3.Lib
{
    public class DataService : ISprint6Task0V3
    {
        public double Calculate(int x)
        {
            double y = (4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1);
            return Math.Round(y, 3);
        }
    }
}
