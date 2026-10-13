using Tyuiu.ChekaevLA.Sprint2.Task5.V7.Lib;

namespace Tyuiu.ChekaevLA.Sprint2.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual("февраль", dataService.FindMonthName(1990, 13));
        }
    }
}
