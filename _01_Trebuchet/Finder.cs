namespace _01_Trebuchet;

public class Finder
{
    public int FindFirstAndLastDigits(string input)
    {
        var output = "";
        foreach (var c in input)
        {
            if (char.IsDigit(c))
            {
                output += c;
            }
        }
        
        switch (output.Length)
        {
            case 0: return 0;
            case 1: return int.Parse(output);
        }

        var firstDigit = output[0];
        var lastDigit = output[^1];
        var twoDigit = $"{firstDigit}{lastDigit}";
        
        return int.Parse(twoDigit);
    }
}