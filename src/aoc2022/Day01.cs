namespace aoc2022;

public class Day01
{
    public int process(string input)
    {
        if (String.IsNullOrEmpty(input))
            return 0;

        var elfs = input
            .Split("\n\n", StringSplitOptions.None);

        return elfs.Aggregate(0, (state, elf) =>
        {
            var calories = elf.Split("\n").Select(int.Parse).Sum();
            if (calories > state)
                return calories;
            return state;
        });
    }
}
