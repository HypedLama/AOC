namespace Day_7;
class Program
{

    static void Main(string[] args)
    {

        string[] input = File.ReadLines("example.txt").ToArray();
        Dictionary<string, int> directorysize = new();
        string Path = "";
        foreach (var item in input)
        {

            if (item.Contains("$ cd "))
            {
                string folder = item.Split(" ")[2];
                if (!item.Contains("$ cd .."))
                {
                    Path += "-" + folder;
                }
                else
                {
                    var SubPath = Path.Split("-");
                    Path = Path.Remove(Path.LastIndexOf("-" + SubPath.Last()));
                }
            }
            else if (char.IsDigit(item[0]))
            {
                int size = int.Parse(item.Split(" ")[0]);
                var SubPath = Path;
                foreach (var directory in Path.Split("-"))
                {
                    if (directory != "")
                    {
                        if (!directorysize.ContainsKey(SubPath))
                        {
                            directorysize.Add(SubPath, 0);
                        }
                        directorysize[SubPath] += size;
           
                        SubPath = Path.Remove(Path.LastIndexOf("-" + SubPath.Split("-").Last()));
                    }
                }
            }
        }
        int sum = 0;
        foreach (var item in directorysize)
        {
            Console.WriteLine(item);
            if (item.Value <= 100000)
            {
                sum += item.Value;
            }
        }
        Console.WriteLine(sum);
    }
}
