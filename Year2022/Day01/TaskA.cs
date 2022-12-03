namespace Year2022.Day01;

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
        List<int> sumCaloriesList = new List<int>();
        int elfCalories = 0;
        
        foreach (string line in input)
        {
            if (line != "")
            {
                elfCalories += Int32.Parse(line);
            }
            else
            {
                sumCaloriesList.Add(elfCalories);
                elfCalories = 0;
            }
        }

        return sumCaloriesList.Max().ToString();
    }
    
    private static string[] ReadFile()
        => File.ReadAllLines(@"E:\Advent-of-Code\Year2022\Day01\input.txt");

}