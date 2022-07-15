namespace DataStructure;

public class Math
{

    public Dictionary<int, int> Square(int[] numbers)
        => numbers.ToDictionary(x => x, s => s * s);

    public long Factorial(int number)
    {
        if (number == 0)
            return 1;
        else
            return (number * Factorial(number - 1));
    }

    public long Power(int integer, int power)
    {
        if (power != 0)
            return (integer * Power(integer, power - 1));
        else
            return 1;
    }
}

