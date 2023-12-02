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
    
    [Fact]
    public void FindFirstAndLastDigits_a101_11()
    {
        var finder = new Finder();
        const string input = "a101";
        
        var result = finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(11, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_a154821a_11()
    {
        var finder = new Finder();
        const string input = "a154821a";
        
        var result = finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(11, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_1abc2_12()
    {
        var finder = new Finder();
        const string input = "1abc2";
        
        var result = finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(12, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_pqr3stu8vwx_12()
    {
        var finder = new Finder();
        const string input = "pqr3stu8vwx";
        
        var result = finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(38, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_a1b2c3d4e5f_15()
    {
        var finder = new Finder();
        const string input = "a1b2c3d4e5f";
        
        var result = finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(15, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_treb7uchet_12()
    {
        var finder = new Finder();
        const string input = "treb7uchet";
        
        var result = finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(7, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_treb0uchet_12()
    {
        var finder = new Finder();
        const string input = "treb0uchet";
        
        var result = finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_trebuchet_12()
    {
        var finder = new Finder();
        const string input = "trebuchet";
        
        var result = finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(0, result);
    }
}