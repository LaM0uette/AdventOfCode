namespace _01_Trebuchet;

public static class Finder
{
    public static int GetSumOfCalibrationValues(IEnumerable<string> input)
    {
        return input.Sum(FindFirstAndLastDigits);
    }
    
    public static int FindFirstAndLastDigits(string input)
    {
        char? firstDigit = null;
        char? lastDigit = null;

        foreach (var c in input.Where(char.IsDigit))
        {
            if (firstDigit == null)
            {
                firstDigit = c;
                continue;
            }
            
            lastDigit = c;
        }

        if (firstDigit == null)
            return 0;

        return int.Parse(lastDigit == null ? $"{firstDigit}{firstDigit}" : $"{firstDigit}{lastDigit}");
    }
}