using DataStructure;
using FluentAssertions;

namespace UnitTest;

public class StringTest
{
    [Theory]
    [InlineData("TestOne")]
    [InlineData("TestTwo")]
    public void ShouldReverseString(string text)
    {
        Assert.Equal(new System.String(text.Reverse().ToArray()), text.CustomReverse());
    }

    [Fact]
    public void ShouldDisplayTheCharactersAndFrequencyOfEachCharacterFromInputString()
    {
        var inputString = "test";
        var result = inputString.Frequency();
        result.Should().Contain(new KeyValuePair<char, int>('t',2));
    }
}