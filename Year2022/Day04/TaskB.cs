namespace Year2022.Day04;

public static class TaskB
{
    public static void Run()
    {
        var input = ReadFile();
        var result = Solve(input);
        Console.WriteLine(result);
    }

    private static string Solve(string[] input)
    {
        int counter = 0;
        bool ifContains;
        foreach (var line in input)
        {
            var ranges = line.Split(new char[] { ',' });
            var firstElfRange = ranges.First().Split(new char[] { '-' }).Select(x=>Int32.Parse(x)).ToList();
            var secondElfRange = ranges.Last().Split(new char[] { '-' }).Select(x=>Int32.Parse(x)).ToList();

            var firstElf = Enumerable.Range(firstElfRange[0], firstElfRange[1] - firstElfRange[0] + 1).ToList();
            var secondElf = Enumerable.Range(secondElfRange[0], secondElfRange[1] - secondElfRange[0] + 1).ToList();

            ifContains = CheckIfOverlap(firstElf, secondElf);
            
            if (ifContains)
                counter++;
        }
        return counter.ToString();
    }

    private static bool CheckIfOverlap(List<int> first, List<int> second)
    {
        return first.Intersect(second).Any();
    }
    private static string[] ReadFile()
        => File.ReadAllLines(@"E:\Advent-of-Code\Year2022\Day04\input.txt");
}