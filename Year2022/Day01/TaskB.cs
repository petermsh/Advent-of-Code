namespace Year2022.Day01;

public class TaskB
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

        return sumCaloriesList.OrderByDescending(i => i).Take(3).Sum().ToString();
    }
    
    private static string[] ReadFile()
        => File.ReadAllLines("D:/NaukaC#/AoC2022/AoC2022/Year2022/Day01/input.txt");
}