public static class StatisticsHelper
{
    public static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0) return 0.0;
        return (double)CalculateSum(numbers) / numbers.Length;
    }
    
    public static int CalculateMax(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
}