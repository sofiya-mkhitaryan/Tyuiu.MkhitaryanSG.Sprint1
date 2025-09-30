//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.
//Расчеты:
//Написать программу вычисления расстояния между населенными пунктами, изображенными на карте. Ответ округлите до 3 знаков после запятой.
//Масштаб карты (количество км. в одном см.) -> 120
//Расстояние между точками, изображающими населенные пункты (см) -> 3.5
//Расстояние между населенными пунктами 420 км.
using Tyuiu.MkhitaryanSG.Sprint1.Task3.V5.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint1.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Write("Введите масштаб карты (км в 1 см): ");
            double mapScale = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите расстояние между населенными пунктами (в см): ");
            double distanceInCm = Convert.ToDouble(Console.ReadLine());

            double result = ds.DistanceLength(mapScale, distanceInCm);//км

            Console.WriteLine($"Расстояние между населенными пунктами: {result} км");//округ и вывод
        }
    }
}