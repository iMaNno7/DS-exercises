using System.Globalization;
using System.Text;

namespace DataStructure;

public static class String
{
    public static string CustomReverse(this string source)
    {
        ArgumentNullException.ThrowIfNull(source);
        return string.Join("", source.graphemeEnumerable().Reverse().ToArray());
    }

    public static string[] Frequency(this string source)
        => source.GroupBy(s => s).Select(s => $"{s.Key}-{s.Count()}").ToArray();

    public static string ReverseString(this string source)
    {
        ArgumentNullException.ThrowIfNull(source);
        StringBuilder reverce = new("", source.Length);
        for (int i = source.Count() - 1; i >= 0; i--)
            reverce.Append(source[i]);

        return reverce.ToString();
    }

    private static IEnumerable<string> graphemeEnumerable(this string s)
    {
        var enumerator = StringInfo.GetTextElementEnumerator(s);
        while (enumerator.MoveNext())
            yield return (string)enumerator.Current;
    }
}

