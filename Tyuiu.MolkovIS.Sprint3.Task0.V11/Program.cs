using Tyuiu.MolkovIS.Sprint3.Task0.V11.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        DataService dataService = new DataService();
        Console.Write("Введите начало: "); int start = Convert.ToInt32(Console.ReadLine());
        int n = 5;
        Console.Write("Введите конец: "); int end = Convert.ToInt32(Console.ReadLine());
        double res = dataService.GetSumSeries(n, start, end);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
    }
}