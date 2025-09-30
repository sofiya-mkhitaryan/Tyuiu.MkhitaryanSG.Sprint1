using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MkhitaryanSG.Sprint1.Task3.V5.Lib
{
    public class DataService : ISprint1Task3V5
    {
        public double DistanceLength(double mapScale, double distanceBetweenPoints)
        {
            double distanceInKm = distanceBetweenPoints * mapScale;//реальное расстояние в км
            return Math.Round(distanceInKm, 3);//округление до трех знаков после запятой
        }
    }
}
