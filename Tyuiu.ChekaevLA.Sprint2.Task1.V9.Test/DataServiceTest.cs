using Tyuiu.ChekaevLA.Sprint2.Task1.V9.Lib;

namespace Tyuiu.ChekaevLA.Sprint2.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            CollectionAssert.AreEqual(new bool[] { false, false, true, false, true, false }, dataService.GetLogicOperations(15, 335, 174, 478));
        }
    }
}
