using DataStructure;

namespace UnitTest;

public class StringHelperTest
{
    [Theory]
    [InlineData("TestOne")]
    [InlineData("TestTwo")]
    public void ShouldReverseString(string text)
    {
        Assert.Equal(new String(text.Reverse().ToArray()), text.CustomReverse());
    }

    [Theory]
    [InlineData("TesTOne")]
    public void ShouldDisplayTheCharactersAndFrequencyOfEachCharacterFromInputString(string text)
    {
        Assert.Contains("T-2", text.Frequency());
    }
}