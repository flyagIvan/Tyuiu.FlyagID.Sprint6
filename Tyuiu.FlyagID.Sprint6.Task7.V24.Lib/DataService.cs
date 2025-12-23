using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FlyagID.Sprint6.Task7.V24.Lib
{
    public class DataService : ISprint6Task7V24
    {
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = int.Parse(parts[j]);
            }

            int rowIndex = 1;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[rowIndex, j] % 2 == 0)
                    matrix[rowIndex, j] = 1;
            }

            return matrix;
        }
    }
}
