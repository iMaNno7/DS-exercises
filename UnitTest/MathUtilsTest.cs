using Math = DataStructure.Math;

namespace UnitTest;

public class MathUtilsTest
{
    private Math math;
    
    public MathUtilsTest()
    {
        math = new Math();
    }

    [Theory]
    [InlineData(new int[] { 5, 6, 7 })]
    [InlineData(new int[] { 10, 20, 30 })]
    public void ShouldCalculateSquare(int[] numbers)
    {
        var square = math.Square(numbers);

        foreach (var item in square)
            Assert.Equal(item.Key * item.Key, item.Value);
    }

    [Fact]
    public void ShouldCalculateFactorial()
    {
        Assert.Equal((long)120, math.Factorial(5));
    }

    [Fact]
    public void ShouldCalculatePower()
    {
        Assert.Equal(1024, math.Power(2, 10));
    }
}