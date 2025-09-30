using Tyuiu.MkhitaryanSG.Sprint1.Task0.V15.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint1.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate();
            Assert.AreEqual(24, res);
        }
    }
}
