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
}