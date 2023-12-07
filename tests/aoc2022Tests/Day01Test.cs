namespace aoc2022Tests.Day01Test;
using aoc2022;

public class ProcessTest
{
    [Fact]
    public void Empty_Test()
    {
        var data = "";

        Assert.Equal(0, Day01.solve(data));
    }

    [Fact]
    public void One_Elf_Process_Test()
    {
        var data = @"1000";

        Assert.Equal(1000, Day01.solve(data));
    }

    [Fact]
    public void Two_Elf_Process_Test()
    {
        var data = @"1000

            2000";

        Assert.Equal(2000, Day01.solve(data));
    }

    [Fact]
    public void First_Elf_Has_More()
    {
        var data =
            @"1000
            2000

            1000";

        Assert.Equal(3000, Day01.solve(data));
    }

    [Fact]
    public void Second_Elf_Has_More()
    {
        var data =
            @"1000

            1000
            3000";

        Assert.Equal(4000, Day01.solve(data));
    }

    [Fact]
    public void Example_test()
    {
        var data =
            @"1000
            2000
            3000

            4000

            5000
            6000

            7000
            8000
            9000

            10000";

        Assert.Equal(24000, Day01.solve(data));
    }



    [Fact]
    public void Top_Three_Elves()
    {
        var data =
            @"1000
            2000
            3000

            4000

            5000
            6000

            7000
            8000
            9000

            10000";

        Assert.Equal(45000, Day01.solve(data, 3));
    }
}
