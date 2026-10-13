using Tyuiu.ChekaevLA.Sprint2.Task6.V8.Lib;

namespace Tyuiu.ChekaevLA.Sprint2.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataservice = new DataService();
            Assert.AreEqual("05.02", dataservice.FindDateOfPreviousDay(6, 2));
        }
    }
}
