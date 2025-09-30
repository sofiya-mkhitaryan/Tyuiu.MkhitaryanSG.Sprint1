using Tyuiu.MkhitaryanSG.Sprint1.Task1.V29.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint1.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double z = 3.0;
            var res = ds.Calculate(x, y, z);
            Assert.AreEqual(1, res);
        }
    }
}
