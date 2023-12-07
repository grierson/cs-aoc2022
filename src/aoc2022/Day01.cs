namespace aoc2022;

public static class Day01
{
    public static int solve(string input, int amount = 1)
    {
        if (String.IsNullOrEmpty(input))
            return 0;

        var elfs = input
            .Trim()
            .Split("\n\n", StringSplitOptions.None);

        var elf_calories = elfs.Select((elf) =>
        {
            var calories = elf
                .Split("\n")
                .Select(int.Parse)
                .Sum();

            return calories;
        });

        return elf_calories.OrderDescending().Take(amount).Sum();
    }

    public static int first()
    {
        string path = "src/aoc2022/files/Day01.txt";
        string content = File.ReadAllText(path);

        return solve(content);
    }


    public static int second()
    {
        string path = "src/aoc2022/files/Day01.txt";
        string content = File.ReadAllText(path);

        return solve(content, 3);
    }
}
