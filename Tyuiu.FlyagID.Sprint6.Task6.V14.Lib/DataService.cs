using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FlyagID.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
                return string.Empty;

            string text = File.ReadAllText(path);

            string[] words = text.Split(
                new char[] { ' ', '\n', '\r', '\t', ',', '.', '!', '?' },
                System.StringSplitOptions.RemoveEmptyEntries);

            var result = words
                .Where(w => w.Contains('z')); 

            return string.Join(" ", result);
        }
    }
}
