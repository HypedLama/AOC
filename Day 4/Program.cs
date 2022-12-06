namespace Day_4;
class Program
{
    static void Main(string[] args)
    {
        List<string> inputLines = File.ReadLines("input.txt").ToList();
        string s;
        int count=0;
        foreach(var pair in inputLines){
            Console.WriteLine(pair);
        }
        foreach(var pair in inputLines){
            String[] ranges = pair.Split(",");
            String[] sRange1 = ranges[0].Split("-");
            String[] sRange2 = ranges[1].Split("-");
            Console.WriteLine(sRange2.Length);
            if(int.Parse(sRange1[0])<= int.Parse(sRange2[0]) && int.Parse(sRange1[1]) >= int.Parse(sRange2[1])){
                count++;
            }else if(int.Parse(sRange1[0]) >= int.Parse(sRange2[0]) && int.Parse(sRange1[1]) <= int.Parse(sRange2[1])){
                count++;
            }else{}
        }
        Console.WriteLine(count);
    }
}
