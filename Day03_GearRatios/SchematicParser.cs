using System.Text.RegularExpressions;

namespace Day03_GearRatios;

public struct Part
{
    public int Number { get; set; }
    public int Index { get; set; }
    public int Length { get; set; }
}

public static class SchematicParser
{
    public static int CalculatePartNumbersSum(string[] schematic)
    {
        var result = 0;
        for (var i = 0; i < schematic.Length; i++)
        {
            var parts = ExtractNumbersAndIndices(schematic[i]);

            foreach (var part in parts)
            {
                if (LookAround(schematic, i, part))
                {
                    result += part.Number;
                }
            }
        }

        return result;
    }

    private static List<Part> ExtractNumbersAndIndices(string input)
    {
        var regex = new Regex(@"\d+");

        var parts = new List<Part>();
        foreach (Match match in regex.Matches(input))
        {
            parts.Add(new Part
            {
                Number = int.Parse(match.Value),
                Index = match.Index,
                Length = match.Length,
            });
        }

        return parts;
    }

    private static bool LookAround(IReadOnlyList<string> schematic, int row, Part part)
    {
        for (var i = 0; i < part.Length; i++)
        {
            if (IsAdjacentToSymbol(schematic, row, part.Index + i))
            {
                return true;
            }
        }
        return false;
    }

    private static bool IsAdjacentToSymbol(IReadOnlyList<string> schematic, int row, int col)
    {
        for (var i = -1; i <= 1; i++)
        {
            for (var j = -1; j <= 1; j++)
            {
                if (i == 0 && j == 0) continue;

                var newRow = row + i;
                var newCol = col + j;

                if (newRow >= 0 && newRow < schematic.Count && newCol >= 0 && newCol < schematic[newRow].Length)
                {
                    var c = schematic[newRow][newCol];
                    if (c != '.' && !char.IsDigit(c))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}
