namespace Year2022.Day02;

public class TaskA
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
                    "A X" => 4, // Rock Rock = draw (3) + rock (1) = 4
                    "A Y" => 8, // Rock Paper = win (6) + paper (2) = 8
                    "A Z" => 3, // Rock Scissors = lose (0) + scissors (3) = 3
                    "B X" => 1, // Paper Rock = lose (0) + rock (1) = 1
                    "B Y" => 5, // Paper Paper = draw (3) + paper (2) = 5
                    "B Z" => 9, // Paper Scissors = win (6) + scissors (3) = 9
                    "C X" => 7, // Scissors Rock = win (6) + rock (1) = 7
                    "C Y" => 2, // Scissors Paper = lose (0) + paper (2) = 2
                    "C Z" => 6, // Scissors Scissors = draw (3) + scissors (3) = 6
            };
        }

        return result.ToString();
    }

    private static string[] ReadFile()
        => File.ReadAllLines(@"E:\Advent-of-Code\Year2022\Day02\input.txt");
}