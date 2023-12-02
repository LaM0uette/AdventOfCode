namespace _01_Trebuchet.Test;

public class FinderTest
{
    [Fact]
    public void FindFirstAndLastDigits_11_11()
    {
        var finder = new Finder();
        const string input = "11";
        
        var result = finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(11, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_55_55()
    {
        var finder = new Finder();
        const string input = "55";
        
        var result = finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(55, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_101_11()
    {
        var finder = new Finder();
        const string input = "101";
        
        var result = finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(11, result);
    }
}