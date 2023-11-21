namespace aoc2022Tests;
using aoc2022;

public class ProcessTest
{
    [Fact]
    public void Empty_Test()
    {
        var sut = new Day01();
        var data = "";

        Assert.Equal(0, sut.process(data));
    }

    [Fact]
    public void One_Elf_Process_Test()
    {
        var sut = new Day01();
        var data = @"1000";

        Assert.Equal(1000, sut.process(data));
    }

    [Fact]
    public void Two_Elf_Process_Test()
    {
        var sut = new Day01();
        var data = "1000\n\n2000";

        Assert.Equal(2000, sut.process(data));
    }

    [Fact]
    public void First_Elf_Has_More()
    {
        var sut = new Day01();
        var data = "1000\n2000\n\n1000";

        Assert.Equal(3000, sut.process(data));
    }

    [Fact]
    public void Second_Elf_Has_More()
    {
        var sut = new Day01();
        var data = "1000\n\n1000\n3000";

        Assert.Equal(4000, sut.process(data));
    }
}
