using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FlyagID.Sprint6.Task5.V20.Lib
{
    public class DataService : ISprint6Task5V20
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            string text = File.ReadAllText(path);

            string[] parts = text.Split(
                new char[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            List<double> result = new List<double>();

            foreach (string p in parts)
            {
                if (double.TryParse(
                        p.Replace(',', '.'),
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out double value))
                {
                    if (Math.Abs(value % 2) < 1e-9)
                        result.Add(Math.Round(value, 3));
                }
            }

            return result.ToArray();
        }
    }
}
