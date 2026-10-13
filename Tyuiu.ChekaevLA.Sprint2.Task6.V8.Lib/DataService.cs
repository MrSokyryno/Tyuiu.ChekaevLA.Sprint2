namespace Tyuiu.ChekaevLA.Sprint2.Task6.V8.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint2.ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            if (m > 1) 
            {
                if (m > 1 && m < 11)
                {
                    switch (n > 9)
                    {
                        case true: return $"0{m - 1}.{n}";
                        default: return $"0{m - 1}.0{n}";
                    }
                }
                else 
                {
                    switch (n > 9)
                    {
                        case true: return $"{m - 1}.{n}";
                        default: return $"{m - 1}.0{n}";
                    }
                }
            }
            else 
            {
                switch(n)
                {
                    case 2: return $"31.0{n}";
                    case 3: return $"28.0{n}";
                    case 4: return $"31.0{n}";
                    case 5: return $"30.0{n}";
                    case 6: return $"31.0{n}";
                    case 7: return $"30.0{n}";
                    case 8: return $"31.0{n}";
                    case 9: return $"31.0{n}";
                    case 10: return $"30.{n}";
                    case 11: return $"31.{n}";
                    case 12: return $"30.{n}";
                }
            }
            return "n и m не характеризуют 1 января";
                    
        }
    }
}
