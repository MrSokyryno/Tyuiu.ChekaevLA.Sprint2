namespace Tyuiu.ChekaevLA.Sprint2.Task3.V18.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task3V18
    {
        public double Calculate(double x)
        {
            if (x > 1) return Math.Round(Math.Pow(x, 2) * Math.Pow(((x + 1) / (x - 1)), x),3);
            else if (x == 0) return 0.75;
            else if (-22 < x && x < 2) return Math.Round(Math.Pow((1 + 1 / Math.Pow(x, 2)), x),3);
            else if (x < -22) return Math.Round(x + 10 * x - 1 / x, 3);
            return 0;
        }
    }
}
