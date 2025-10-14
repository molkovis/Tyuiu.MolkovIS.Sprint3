using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.MolkovIS.Sprint3.Task4.V12.Lib
{
    public class DataService : ISprint3Task4V12
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int i = startValue; i < stopValue; i++)
            {
                if (i == 0) break;
                res *= i / (i + Math.Sin(i)) + 2.5;
            }
            return Math.Round(res,3);
        }
    }
}
