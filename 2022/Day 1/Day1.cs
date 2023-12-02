using System;

namespace Main;

internal class Program
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("input.txt");
        string input = reader.ReadToEnd();
        List<int> calorieElfes=new List<int>();
        int elfeCalories;
        foreach (var item in input.Split(Environment.NewLine + Environment.NewLine))
        {
            elfeCalories = 0;
            foreach (var num in item.Split(Environment.NewLine))
            {
                elfeCalories += int.Parse(num);
            }
            calorieElfes.Add(elfeCalories);
        }
        calorieElfes.Sort();
        calorieElfes.Reverse();
        Console.WriteLine(calorieElfes[0]+calorieElfes[1]+calorieElfes[2]);
    }
}
