namespace Year2022.Day03;

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
        int result = 0;
        for (int i = 0; i < input.Length; i+=3)
        {
            var first = input[i];
            var second = input[i + 1];
            var third = input[i + 2];
            var repetitions = new HashSet<char>();
            foreach (var letter in first)
            {
                if (second.Contains(letter) && third.Contains(letter))
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