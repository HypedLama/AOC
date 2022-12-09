namespace Day_7;
class Program
{
    static void Main(string[] args)
    {
        string[] input = File.ReadLines("input.txt").ToArray();
        Dictionary<string,int> directorysize = new Dictionary<string, int>();
        List<string> Path = new List<string>();
        foreach(var item in input){

            if(item.Contains("cd ")){
                string folder = item.Split(" ")[2];
                Path.Add(folder);
            }
        }
        foreach(string item in Path.GetRange(0,5)){
        Console.WriteLine(item);
        }
    }
}
