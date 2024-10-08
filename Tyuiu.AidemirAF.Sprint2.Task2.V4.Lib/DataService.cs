using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AidemirAF.Sprint2.Task2.V4.Lib
{
    public class DataService : ISprint2Task2V4
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x >= 3 && x <= 5) && (y >= 3 && y <= 4)) || ((x >= 5 && x <= 9) && (y >= 5 && y <= 7)) || 
                ((x >= 3 && x <= 4) && y == 7) || (x == 4 && (y >= 8 && y <= 13)) || (x == 3 && y == 11) || 
                ((x >= 5 && x <= 6) && y == 14) || (x == 9 && (y >= 3 && y <= 12)) || ((x >= 8 && x <= 13) && y == 8) || 
                ((x >= 8 && x <= 10) && (y >= 9 && y <= 12)) || ((x >= 11 && x <= 12) && y == 11) || 
                ((x >= 12 && x <= 13) && y == 6) || (x == 12 && (y >= 3 && y <= 5)))
                res = true;
            else
                res = false;
            return res;
        }
    }
}
