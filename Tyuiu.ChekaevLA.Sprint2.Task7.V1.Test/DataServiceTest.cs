using Tyuiu.ChekaevLA.Sprint2.Task7.V1.Lib;

namespace Tyuiu.ChekaevLA.Sprint2.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataservice = new DataService();
            Assert.AreEqual(true, dataservice.CheckDotInShadedArea(0,1));
        }
    }
}
