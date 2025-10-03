using Tyuiu.MkhitaryanSG.Sprint1.Task7.V14.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint1.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpession()
        {
           DataService ds = new DataService();
        double x = 1;
        double y = 2;
        double w = 0.870;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(w, res, 0.001);


        }
    }
}
