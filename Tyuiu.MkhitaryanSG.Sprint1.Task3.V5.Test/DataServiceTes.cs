using Tyuiu.MkhitaryanSG.Sprint1.Task3.V5.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint1.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double distanceInCm = 3.5;
            double mapScale = 120.0;
            double expectedDistanceInKm = distanceInCm * mapScale; // 420.0
            var res = ds.DistanceLength(mapScale, distanceInCm);
            Assert.AreEqual(420, res);
        }
    }
}
