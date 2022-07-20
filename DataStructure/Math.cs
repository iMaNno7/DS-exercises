namespace DataStructure;

public static class Math
{

    public static Dictionary<int, int> Square(int[] numbers)
        => numbers.GroupBy(x=>x).ToDictionary(x => x.Key, s => s.Key * s.Key);

    public static long Factorial(this int number)
    {
        if (number == 0)
            return 1;
        else
            return (number * Factorial(number - 1));
    }

    public static long Power(this int integer, int power)
    {
        if (power != 0)
            return (integer * Power(integer, power - 1));
        else
            return 1;
    }
}

