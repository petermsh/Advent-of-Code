namespace Year2022.Day02;

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
        foreach (var line in input)
        {
            result += line switch
            { 
                "A X" => 3, // Rock lose => lose (0) + scissors (3) = 3
                "A Y" => 4, // Rock draw => draw (3) + rock (1) = 4
                "A Z" => 8, // Rock win => win (6) + paper (2) = 8
                "B X" => 1, // Paper lose => lose (0) + rock (1) = 1
                "B Y" => 5, // Paper draw => draw (3) + paper (2) = 5
                "B Z" => 9, // Paper win => win (6) + scissors (3) = 9
                "C X" => 2, // Scissors lose => lose (0) + paper (2) = 2
                "C Y" => 6, // Scissors draw => draw (3) + scissors (3) = 6
                "C Z" => 7, // Scissors win => win (6) + rock (1) = 7
            };
        }

        return result.ToString();
    }

    private static string[] ReadFile()
        => File.ReadAllLines(@"E:\Advent-of-Code\Year2022\Day02\input.txt");
}