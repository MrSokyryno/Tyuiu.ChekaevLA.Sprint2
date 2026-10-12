using Tyuiu.ChekaevLA.Sprint2.Task0.V16.Lib;

namespace Tyuiu.ChekaevLA.Sprint2.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataservice = new DataService();
            CollectionAssert.AreEqual(new[] { true, false, true, false, true, false }, dataservice.GetCompareOperations(1025,250));
        }
    }
}
