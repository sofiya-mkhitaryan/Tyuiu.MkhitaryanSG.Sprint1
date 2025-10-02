using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.MkhitaryanSG.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                    words[i] = words[i].Substring(1) + words[i][0];
            }
            return string.Join(' ', words);
        }
    }
}
