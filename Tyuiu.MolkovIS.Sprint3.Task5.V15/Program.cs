using Tyuiu.MolkovIS.Sprint3.Task5.V15.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        DataService dataService = new DataService();
        Console.Write("Введите начало: "); int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите начало: "); int start1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите начало: "); int end1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите конец: "); int start2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите конец: "); int end2 = Convert.ToInt32(Console.ReadLine());
        double res = dataService.GetSumSumSeries(x, start1, end1, start2, end2);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();
    }
}