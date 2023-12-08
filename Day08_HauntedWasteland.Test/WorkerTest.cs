namespace Day08_HauntedWasteland.Test;

public class WorkerTest
{
    [Fact]
    public void ParseElement()
    {
        var lines = new[]
        {
            "AAA = (BBB, CCC)",
            "BBB = (DDD, EEE)",
            "CCC = (ZZZ, GGG)",
        };
        
        var elements = Worker.ParseElement(lines);
        
        Assert.Equal(3, elements.Count);
        
        Assert.Equal("AAA", elements[0].Name);
        Assert.Equal("BBB", elements[0].Left);
        Assert.Equal("CCC", elements[0].Right);
        
        Assert.Equal("BBB", elements[1].Name);
        Assert.Equal("DDD", elements[1].Left);
        Assert.Equal("EEE", elements[1].Right);
        
        Assert.Equal("CCC", elements[2].Name);
        Assert.Equal("ZZZ", elements[2].Left);
        Assert.Equal("GGG", elements[2].Right);
    }

    [Fact]
    public void FindZZZ_Demo1_2()
    {
        const string path = "RL";
        var lines = new[]
        {
            "AAA = (BBB, CCC)",
            "BBB = (DDD, EEE)",
            "CCC = (ZZZ, GGG)",
            "DDD = (DDD, DDD)",
            "EEE = (EEE, EEE)",
            "GGG = (GGG, GGG)",
            "ZZZ = (ZZZ, ZZZ)",
        };
        
        var result = Worker.FindZZZ(lines, path);
        
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void FindZZZ_Demo2_6()
    {
        const string path = "LLR";
        var lines = new[]
        {
            "AAA = (BBB, BBB)",
            "BBB = (AAA, ZZZ)",
            "ZZZ = (ZZZ, ZZZ)",
        };
        
        var result = Worker.FindZZZ(lines, path);
        
        Assert.Equal(6, result);
    }
}