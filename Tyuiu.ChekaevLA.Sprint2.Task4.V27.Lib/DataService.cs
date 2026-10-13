namespace Tyuiu.ChekaevLA.Sprint2.Task4.V27.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task4V27
    {
        public double Calculate(double x, double y)
        {
            double z = x - 10 > y + 2 ? Math.Round(x * Math.Pow((y + 2) / (x - 1), x), 3) : Math.Round(Math.Pow(y, 2) - (2 / x), 3);
            return z;
        }
    }
}
