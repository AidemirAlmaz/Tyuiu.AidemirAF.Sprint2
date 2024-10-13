using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AidemirAF.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res;
            switch (value1, value2)
            {
                case (1, 6):
                    res = "Шестерка пик";
                    break;
                case (1, 7):
                    res = "Семерка пик";
                    break;
                case (1, 8):
                    res = "Восьмерка пик";
                    break;
                case (1, 9):
                    res = "Девятка пик";
                    break;
                case (1, 10):
                    res = "Десятка пик";
                    break;
                case (1, 11):
                    res = "Валет пик";
                    break;
                case (1, 12):
                    res = "Дама пик";
                    break;
                case (1, 13):
                    res = "Король пик";
                    break;
                case (1, 14):
                    res = "Туз пик";
                    break;
                case (2, 6):
                    res = "Шестерка трефы";
                    break;
                case (2, 7):
                    res = "Семерка трефы";
                    break;
                case (2, 8):
                    res = "Восьмерка трефы";
                    break;
                case (2, 9):
                    res = "Девятка трефы";
                    break;
                case (2, 10):
                    res = "Десятка трефы";
                    break;
                case (2, 11):
                    res = "Валет трефы";
                    break;
                case (2, 12):
                    res = "Дама трефы";
                    break;
                case (2, 13):
                    res = "Король трефы";
                    break;
                case (2, 14):
                    res = "Туз трефы";
                    break;
                case (3, 6):
                    res = "Шестерка бубны";
                    break;
                case (3, 7):
                    res = "Семерка бубны";
                    break;
                case (3, 8):
                    res = "Восьмерка бубны";
                    break;
                case (3, 9):
                    res = "Девятка бубны";
                    break;
                case (3, 10):
                    res = "Десятка бубны";
                    break;
                case (3, 11):
                    res = "Валет бубны";
                    break;
                case (3, 12):
                    res = "Дама бубны";
                    break;
                case (3, 13):
                    res = "Король бубны";
                    break;
                case (3, 14):
                    res = "Туз бубны";
                    break;
                case (4, 6):
                    res = "Шестерка червы";
                    break;
                case (4, 7):
                    res = "Семерка червы";
                    break;
                case (4, 8):
                    res = "Восьмерка червы";
                    break;
                case (4, 9):
                    res = "Девятка червы";
                    break;
                case (4, 10):
                    res = "Десятка червы";
                    break;
                case (4, 11):
                    res = "Валет червы";
                    break;
                case (4, 12):
                    res = "Дама червы";
                    break;
                case (4, 13):
                    res = "Король червы";
                    break;
                case (4, 14):
                    res = "Туз червы";
                    break;
                default:
                    throw new ArgumentException($"Масть должны быть от 1 до 4. Значение {value1}");
            }
            return res;
        }
    }
}
