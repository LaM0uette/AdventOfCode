using System.Text.RegularExpressions;

namespace Day08_HauntedWasteland;

public static class Worker
{
    public static List<Element> ParseElement(IEnumerable<string> lines)
    {
        const string pattern = @"(\w{3})";
        
        var elements = new List<Element>();

        foreach (var line in lines)
        {
            var matches = Regex.Matches(line, pattern);

            var name = matches[0].Value;
            var left = matches[1].Value;
            var right = matches[2].Value;

            elements.Add(new Element(name, left, right));
        }

        return elements;
    }
}
