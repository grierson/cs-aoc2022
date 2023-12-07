namespace aoc2022;

public static class Day01
{
    public static int solve(string input)
    {
        if (String.IsNullOrEmpty(input))
            return 0;

        var elfs = input
            .Trim()
            .Split("\n\n", StringSplitOptions.None);

        return elfs.Aggregate(0, (state, elf) =>
        {
            var calories = elf.Split("\n").Select(int.Parse).Sum();
            if (calories > state)
                return calories;
            return state;
        });
    }

    public static int first()
    {
        string path = "src/aoc2022/files/Day01.txt";
        string content = File.ReadAllText(path);

        return solve(content);
    }
}
