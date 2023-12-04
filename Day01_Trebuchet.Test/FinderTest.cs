namespace Day01_Trebuchet.Test;

public class FinderTest
{
    [Fact]
    public void FindFirstAndLastDigits_11_11()
    {
        const string input = "11";
        
        var result = Finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(11, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_55_55()
    {
        const string input = "55";
        
        var result = Finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(55, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_101_11()
    {
        const string input = "101";
        
        var result = Finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(11, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_a101_11()
    {
        const string input = "a101";
        
        var result = Finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(11, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_a154821a_11()
    {
        const string input = "a154821a";
        
        var result = Finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(11, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_1abc2_12()
    {
        const string input = "1abc2";
        
        var result = Finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(12, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_pqr3stu8vwx_12()
    {
        const string input = "pqr3stu8vwx";
        
        var result = Finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(38, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_a1b2c3d4e5f_15()
    {
        const string input = "a1b2c3d4e5f";
        
        var result = Finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(15, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_treb7uchet_12()
    {
        const string input = "treb7uchet";
        
        var result = Finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(77, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_treb0uchet_12()
    {
        const string input = "treb0uchet";
        
        var result = Finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_trebuchet_12()
    {
        const string input = "trebuchet";
        
        var result = Finder.FindFirstAndLastDigits(input);
        
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void GetSumOfCalibrationValues_4lines_142()
    {
        var input = new[]
        {
            "1abc2",
            "pqr3stu8vwx",
            "a1b2c3d4e5f",
            "treb7uchet"
        };
        
        var result = Finder.GetSumOfCalibrationValues(input);
        
        Assert.Equal(142, result);
    }
    
    [Fact]
    public void GetSumOfCalibrationValues_4lines_185()
    {
        var input = new[]
        {
            "twovgtprdzcjjzkq3ffsbcblnpq",
            "two8sixbmrmqzrrb1seven",
            "9964pfxmmr474",
            "46one"
        };
        
        var result = Finder.GetSumOfCalibrationValues(input);
        
        Assert.Equal(185, result);
    }
    
    [Fact]
    public void GetSumOfCalibrationValues_1lines_23()
    {
        var input = new[]
        {
            "twovgtprdzcjjzkq3ffsbcblnpq",
        };
        
        var result = Finder.GetSumOfCalibrationValues(input);
        
        Assert.Equal(23, result);
    }
    
    [Fact]
    public void GetSumOfCalibrationValues_1lines_0()
    {
        var input = new[]
        {
            "vgtprdzcjjzkqffsbcblnpq",
        };
        
        var result = Finder.GetSumOfCalibrationValues(input);
        
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void FindFirstAndLastDigits_part2_281()
    {
        var input = new[]
        {
            "two1nine",
            "eightwothree",
            "abcone2threexyz",
            "xtwone3four",
            "4nineeightseven2",
            "zoneight234",
            "7pqrstsixteen",
        };
        
        var inputResult = new[]
        {
            29,
            83,
            13,
            24,
            42,
            14,
            76,
        };

        for(var i = 0; i < input.Length; i++)
        {
            var result = Finder.FindFirstAndLastDigits(input[i]);
            Assert.Equal(inputResult[i], result);
        }
        
        var finalResult = Finder.GetSumOfCalibrationValues(input);
        Assert.Equal(281, finalResult);
    }
}