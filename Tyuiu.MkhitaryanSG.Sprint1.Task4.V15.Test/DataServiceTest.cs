using Tyuiu.MkhitaryanSG.Sprint1.Task4.V15.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint1.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            double otvet = Math.Round((6 * Math.Exp(6)), 3);
            Assert.AreEqual(otvet, res);
        }
    }
}
