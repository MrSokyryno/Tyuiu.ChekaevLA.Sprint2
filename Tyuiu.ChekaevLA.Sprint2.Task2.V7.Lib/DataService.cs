namespace Tyuiu.ChekaevLA.Sprint2.Task2.V7.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task2V7
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((2 < y && y > 2) && ((2 < x && x < 6) || (8 < x && x < 13))) return true;
            if (y == 4 && (2 < x && x < 13)) return true;
            if ((5<y && y<8) && (2<x && x<14)) return true;
            if (y == 8 && (3 < x && x < 14)) return true;
            if ((8 < y && y > 11) && ((3 < x && x < 6) || (9 < x && x < 13))) return true;
            if (y==11 && ((2 < x && x < 6) || (9 < x && x < 13))) return true;
            if (y == 12 && ((3 < x && x < 7) || x==10)) return true;
            if (y==13 && 3<x && x<7) return true;
            return false;

        }
    }
}
