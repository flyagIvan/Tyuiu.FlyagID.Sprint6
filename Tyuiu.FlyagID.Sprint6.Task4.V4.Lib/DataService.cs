using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FlyagID.Sprint6.Task4.V4.Lib
{
    public class DataService : ISprint6Task4V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;
                double denominator = Math.Cos(x) + x;

                double fx;
                if (Math.Abs(denominator) < 1e-10)
                {
                    fx = 0;
                }
                else
                {
                    fx = ((2 * x + 6) / denominator) - 3;
                }

                result[i] = Math.Round(fx, 2);
            }

            return result;
        }

        public void SaveToFile(double[] values, string path)
        {
            using StreamWriter sw = new StreamWriter(path);
            foreach (double v in values)
            {
                sw.WriteLine(v);
            }
        }
    }
}
