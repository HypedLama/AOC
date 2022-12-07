namespace Day_4;
class Program
{
    static void Main(string[] args)
    {
        List<string> inputLines = File.ReadLines("input.txt").ToList();
        int count=0;

        foreach(var pair in inputLines){
            String[] ranges = pair.Split(",");
            String[] sRange1 = ranges[0].Split("-");
            String[] sRange2 = ranges[1].Split("-");
			int[] range1 = {int.Parse(sRange1[0]), int.Parse(sRange1[1])};
			int[] range2 = {int.Parse(sRange2[0]), int.Parse(sRange2[1])};
			
            if(range2[0]<= range1[0] && range1[0] <= range2[1]){
                count++;
            }else if(range2[0]<= range1[1] && range1[1] <= range2[1]){
                count++;
            }else if(range1[0]<= range2[0] && range2[0] <= range1[1]){
				count++;
			}else if(range1[0]<= range2[1] && range2[1] <= range1[1]){
				count++;
			}
        }
        Console.WriteLine(count);
    }
}
