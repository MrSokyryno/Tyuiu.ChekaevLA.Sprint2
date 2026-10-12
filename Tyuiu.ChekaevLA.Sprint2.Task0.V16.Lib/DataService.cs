namespace Tyuiu.ChekaevLA.Sprint2.Task0.V16.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task0V16
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] list = [x==x, y!=y, y<x, y>x, x<=x, y>=x];
            return list;
        }
    }
}
