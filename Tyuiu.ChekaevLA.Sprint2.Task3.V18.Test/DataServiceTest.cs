using Tyuiu.ChekaevLA.Sprint2.Task3.V18.Lib;

namespace Tyuiu.ChekaevLA.Sprint2.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(0.75, dataService.Calculate(0));
        }
    }
}
