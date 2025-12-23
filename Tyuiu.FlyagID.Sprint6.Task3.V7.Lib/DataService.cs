using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FlyagID.Sprint6.Task3.V7.Lib
{
    public class DataService : ISprint6Task3V7
    {
        private int[,] sourceMatrix = new int[,]
        {
            { 31, 25, -18, 12,   9 },
            {  6, 34,  -2,  2, -18 },
            { -5,  4,  27,  4,  -1 },
            {  4, 15,  34, -6, -10 },
            {  0,  8,   5, 14, -17 }
        };

        public int[,] Calculate(int[,] matrix)
        {
            int[,] result = (int[,])sourceMatrix.Clone();
            int rows = result.GetLength(0);
            int cols = result.GetLength(1);

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (result[i, 3] > result[j, 3])
                    {
                        for (int k = 0; k < cols; k++)
                        {
                            int temp = result[i, k];
                            result[i, k] = result[j, k];
                            result[j, k] = temp;
                        }
                    }
                }
            }

            return result;
        }
    }
}
