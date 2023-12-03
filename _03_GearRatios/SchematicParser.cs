using System.Text.RegularExpressions;

namespace _03_GearRatios;

public static class SchematicParser
{
    public static int CalculatePartNumbersSum(string[] schematic)
    {
        for (var i = 0; i < schematic.Length; i++)
        {
            ExtractNumbersAndIndices(schematic[i]);
            
            for (var j = 0; j < schematic.Length; j++)
            {
                
            }
        }

        return 0;
    }

    private static void ExtractNumbersAndIndices(string input)
    {
        var regex = new Regex(@"\d+");

        foreach (Match match in regex.Matches(input))
        {
            Console.WriteLine($"{match.Value} index {match.Index}");
        }
    }
}
