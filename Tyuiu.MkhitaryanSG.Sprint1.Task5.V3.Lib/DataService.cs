using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.MkhitaryanSG.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            if (k <= 0)
                return -1;

            string s = k.ToString();
            if (s.Length < 3)
                return -1;

            return int.Parse(s[s.Length - 3].ToString());
        }
    }
}
