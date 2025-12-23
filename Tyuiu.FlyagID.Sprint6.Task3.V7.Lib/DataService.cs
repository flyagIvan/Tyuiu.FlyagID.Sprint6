using tyuiu.cources.programming.interfaces.Sprint6;
using System;

namespace Tyuiu.FlyagID.Sprint6.Task3.V7.Lib
{
    public class DataService : ISprint6Task3V7
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = (int[,])matrix.Clone();

            int[] column = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                column[i] = result[i, 3];
            }

            Array.Sort(column);

            for (int i = 0; i < rows; i++)
            {
                result[i, 3] = column[i];
            }

            return result;
        }
    }
}
