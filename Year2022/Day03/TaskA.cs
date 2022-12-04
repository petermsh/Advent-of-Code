namespace Year2022.Day03;

public static class TaskA
{
    public static void Run()
    {
        var input = ReadFile();
        var result = Solve(input);
        Console.WriteLine(result);
    }

    private static string Solve(string[] input)
    {
        int result = 0;
        foreach (var line in input)
        {
            var first = String.Concat(line.Take(line.Length / 2));
            var second = String.Concat(line.TakeLast(line.Length / 2));
            var repetitions = new HashSet<char>();
            foreach (var letter in first)
            {
                if (second.Contains(letter))
                    repetitions.Add(letter);
            }

            foreach (var letter in repetitions)
            {
                if (Char.IsLower(letter))
                    result += letter - 96;
                else
                    result += letter - 38;
            }
        }
        
        return result.ToString();
    }

    private static string[] ReadFile()
        => File.ReadAllLines(@"E:\Advent-of-Code\Year2022\Day03\input.txt");
}