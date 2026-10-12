namespace Tyuiu.ChekaevLA.Sprint2.Task1.V9.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] list = new bool[] { a == b | false, d != c & false, a < b || true, c > d && true, !(b <= a), false ^ (a >= b )};
            return list;
        }
    }
}
