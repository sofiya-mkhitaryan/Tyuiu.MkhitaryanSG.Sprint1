using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MkhitaryanSG.Sprint1.Task5.V3.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint1.Task5.V3.Test;

    [TestClass]
public class DataServiceTest
{
    private DataService _dataService;

    [TestInitialize]
    public void Setup()
    {
        _dataService = new DataService();
    }

    [TestMethod]
    public void Calculate_NumberWithMoreThan3Digits_ReturnsThirdDigitFromEnd()
    {
        int k = 130985;
        int expected = 9;
        int actual = _dataService.Calculate(k);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Calculate_NumberWithExactly3Digits_ReturnsThirdDigitFromEnd()
    {
        int k = 123;
        int expected = 1;
        int actual = _dataService.Calculate(k);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Calculate_NumberWithLessThan3Digits_ReturnsMinusOne()
    {
        int k = 45;
        int expected = -1;
        int actual = _dataService.Calculate(k);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Calculate_NonPositiveNumber_ReturnsMinusOne()
    {
        int k0 = 0;
        int kNegative = -123;
        Assert.AreEqual(-1, _dataService.Calculate(k0));
        Assert.AreEqual(-1, _dataService.Calculate(kNegative));
    }
}

