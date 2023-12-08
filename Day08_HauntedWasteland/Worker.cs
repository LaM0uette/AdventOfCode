using System.Text.RegularExpressions;

namespace Day08_HauntedWasteland;

public static class Worker
{
    public static int FindZZZ(IEnumerable<string> lines, string path)
    {
        var elements = ParseElement(lines);
        var elementDictionary = new Dictionary<string, Element>();

        foreach (var element in elements)
        {
            elementDictionary[element.Name] = element;
        }

        var currentElement = elementDictionary["AAA"];
        var result = 0;
        var pathIndex = 0;

        while (currentElement.Name != "ZZZ")
        {
            var direction = path[pathIndex];
            var searchName = direction == 'L' ? currentElement.Left : currentElement.Right;
            currentElement = elementDictionary[searchName];
            result++;
            
            Console.WriteLine($"{direction} {currentElement.Name} {currentElement.Left} {currentElement.Right}");

            pathIndex = (pathIndex + 1) % path.Length;
            if (currentElement.Name == "ZZZ")
                break;
        }
        
        return result;
    }
    
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
