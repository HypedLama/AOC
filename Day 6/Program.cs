namespace Day_6;
class Program
{
    static void Main(string[] args)
    {
        char[] charText = File.ReadAllText("input.txt").ToCharArray();
        int count = 0;
        foreach (var item in charText)
        {
            count++;
            char[] subchar = new char[14];
            for(int i=0;i<14;i++){
                subchar[i]=charText[count+i];
            }
            if (subchar.Length == subchar.Distinct().ToArray().Length)
            {
                Console.WriteLine(count + 14);
                break;
            }
        }
    }
}
