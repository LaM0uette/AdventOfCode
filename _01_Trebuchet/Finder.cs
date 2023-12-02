using System.Text.RegularExpressions;

namespace _01_Trebuchet;

public static class Finder
{
    public static int GetSumOfCalibrationValues(IEnumerable<string> input)
    {
        return input.Sum(FindFirstAndLastDigits);
    }
    
    public static int FindFirstAndLastDigits(string input)
    {
        int? firstDigit = null;
        int? lastDigit = null;

        var matches = Regex.Matches(input, @"one|two|three|four|five|six|seven|eight|nine|\d");

        foreach (Match match in matches)
        {
            var currentDigit = WordToDigit(match.Value);

            firstDigit ??= currentDigit;
            lastDigit = currentDigit;
        }

        return firstDigit == null ? 0 : int.Parse($"{firstDigit}{lastDigit}");
    }
    
    private static int WordToDigit(string word)
    {
        return word switch
        {
            "one" => 1,
            "two" => 2,
            "three" => 3,
            "four" => 4,
            "five" => 5,
            "six" => 6,
            "seven" => 7,
            "eight" => 8,
            "nine" => 9,
            _ => int.Parse(word)
        };
    }
}