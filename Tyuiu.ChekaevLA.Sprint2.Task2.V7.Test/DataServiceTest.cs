using Tyuiu.ChekaevLA.Sprint2.Task2.V7.Lib;

namespace Tyuiu.ChekaevLA.Sprint2.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(true, dataService.CheckDotInShadedArea(4, 3));
        }
    }
}
