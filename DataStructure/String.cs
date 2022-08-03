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

    public static string[] FrequencyLink(this string source)
        => source.GroupBy(s => s).Select(s => $"{s.Key}-{s.Count()}").ToArray();

    public static Dictionary<char,int> Frequency(this string source)
    {
        var result = new Dictionary<char, int>();
        for (int i = 0; i < source.Length; i++)
        {
            if (result.ContainsKey(source[i]) is false)            
            result.Add(source[i], 1);
            else
                result[source[i]]+=1;
        }        
        return result;
    }

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

