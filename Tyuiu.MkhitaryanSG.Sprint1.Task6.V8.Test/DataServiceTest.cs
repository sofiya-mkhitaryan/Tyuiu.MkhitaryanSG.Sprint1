using Tyuiu.MkhitaryanSG.Sprint1.Task6.V8.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMoveLetterToEnd()
        {
            var service = new DataService();

            Assert.AreEqual("риветП", service.MoveLetterToEnd("Привет"));
            Assert.AreEqual("ирм", service.MoveLetterToEnd("мир"));
            Assert.AreEqual("a", service.MoveLetterToEnd("a"));
            Assert.AreEqual("", service.MoveLetterToEnd(""));
            Assert.AreEqual(null, service.MoveLetterToEnd(null));
        }
    }
}
