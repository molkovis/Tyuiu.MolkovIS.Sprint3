using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolkovIS.Sprint3.Task6.V21.Lib
{
    public class DataService : ISprint3Task6V21
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int start = startValue; start <= stopValue; start++)
            {
                for (int del = 1; del <= start; del++)
                {
                    if (start % del == 0) sum+= del;
                }
            }
            return sum;
        }
    }
}
