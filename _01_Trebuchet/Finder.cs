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
        
        var firstDigit = output[0];
        var lastDigit = output[^1];
        var twoDigit = $"{firstDigit}{lastDigit}";
        
        return int.Parse(twoDigit);
    }
}