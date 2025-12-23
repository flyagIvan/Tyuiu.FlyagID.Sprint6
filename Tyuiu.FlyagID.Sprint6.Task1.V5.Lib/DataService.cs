using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FlyagID.Sprint6.Task1.V5.Lib
{
    public class DataService : ISprint6Task1V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            for (int i = 0; i < len; i++)
            {
                double x = startValue + i;

                double denominator = 2;

                if (Math.Abs(denominator) < 1e-10)
                {
                    result[i] = 0;
                }
                else
                {
                    double y =
                        Math.Sin(x) +
                        (Math.Cos(2 * x) / denominator) -
                        1.5 * x;

                    result[i] = Math.Round(y, 2);
                }
            }

            return result;
        }
    }
}
