//(x+y^2)/e^2-4y
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MkhitaryanSG.Sprint1.Task4.V15.Lib
{
    public class DataService : ISprint1Task4V15
    {
        public double Calculate(double x, double y)
        {
            double E = Math.E; 
            double one = x + Math.Pow(y, 2);
            double two = Math.Pow(E, (2 - 4 * y));
            return Math.Round(one/two, 3);
        }
    }
}
