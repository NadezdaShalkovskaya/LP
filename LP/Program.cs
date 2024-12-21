class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество учащихся в классе:");
        int n =int.Parse(Console.ReadLine());
        double[] heights = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите рост учащегося {i + 1}(в см)");
            heights[i]=double.Parse(Console.ReadLine());
        }
        double averageHeight = CalculateAverage (heights);
        Console.WriteLine($"Средний рост учащегося в классе:{averageHeight} см ");
    }
    static double CalculateAverage (double[] heights)
    {
        double sum = 0;
        for (int i = 0;i < heights.Length;i++)
        {
            sum += heights[i];
        }
        return sum/heights.Length;
    }
}
