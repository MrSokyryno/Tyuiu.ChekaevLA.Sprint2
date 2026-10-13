using Tyuiu.ChekaevLA.Sprint2.Task4.V27.Lib;

namespace Tyuiu.ChekaevLA.Sprint2.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(0, dataService.Calculate(0, -14));
        }
    }
}
