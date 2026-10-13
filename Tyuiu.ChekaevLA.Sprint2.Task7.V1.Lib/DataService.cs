namespace Tyuiu.ChekaevLA.Sprint2.Task7.V1.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((Math.Pow(x,2)+Math.Pow(y,2)<=1) && (y>=-x) && (y>=x)) {  return true; }
            else { return false; }
        }
    }
}
