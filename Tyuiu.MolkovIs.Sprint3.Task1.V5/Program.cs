using Tyuiu.MolkovIs.Sprint3.Task1.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        DS dataService = new DS();
        Console.Write("Введите начало: "); int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите конец: "); int end = Convert.ToInt32(Console.ReadLine());
        double res = dataService.GetMultiplySeries(start, end);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();
    }
}