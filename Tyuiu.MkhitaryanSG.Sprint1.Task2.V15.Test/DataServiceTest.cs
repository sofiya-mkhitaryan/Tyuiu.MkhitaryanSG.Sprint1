using Tyuiu.MkhitaryanSG.Sprint1.Task2.V15.Lib;
//CalculateCubeVolume
namespace Tyuiu.MkhitaryanSG.Sprint1.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateCubeVolume(x);
            Assert.AreEqual(8, res);

        }
    }
}
