using System.Text.RegularExpressions;

namespace Day01_Trebuchet;

public static class Finder
{
    #region BugVersion

    private static readonly Dictionary<string, string> DigitMap = new()
    {
        {"one", "1"}, {"two", "2"}, {"three", "3"}, {"four", "4"},
        {"five", "5"}, {"six", "6"}, {"seven", "7"}, {"eight", "8"}, {"nine", "9"}
    };

    public static int GetSumOfCalibrationValuesBis(IEnumerable<string> input)
    {
        for (var i = 1; i <= 9; i++)
        {
            DigitMap[i.ToString()] = i.ToString();
        }
        
        var result = 0;
        foreach (var line in input)
        {
            result += FindFirstAndLastDigitsBis(line);
        }
        
        return result;
    }
    
    private static int FindFirstAndLastDigitsBis(string input)
    {
        var findings = new Dictionary<int, string>();
        foreach (var pair in DigitMap)
        {
            var idx = input.IndexOf(pair.Key);
            while (idx != -1)
            {
                findings[idx] = pair.Value;
                idx = input.IndexOf(pair.Key, idx + 1);
            }
        }

        if (findings.Count == 0)
        {
            return 0;
        }

        var minIdx = findings.Keys.Min();
        var maxIdx = findings.Keys.Max();
        return int.Parse(findings[minIdx] + findings[maxIdx]);
    }

    #endregion

    #region MyVersion

    public static int GetSumOfCalibrationValues(IEnumerable<string> input)
    {
        return input.Sum(FindFirstAndLastDigits);
    }
    
    public static int FindFirstAndLastDigits(string input)
    {
        int? firstDigit = null;
        int? lastDigit = null;

        var matches = Regex.Matches(input, @"zero|one|two|three|four|five|six|seven|eight|nine|\d");

        foreach (Match match in matches)
        {
            var currentDigit = WordToDigit(match.Value);

            firstDigit ??= currentDigit;
            lastDigit = currentDigit;
        }

        if (!firstDigit.HasValue || !lastDigit.HasValue) 
        {
            return 0;
        }

        return int.Parse($"{firstDigit}{lastDigit}");
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
            _ => int.TryParse(word, out var result) ? result : -1
        };
    }

    #endregion
}