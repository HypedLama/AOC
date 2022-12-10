namespace Day_7;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Part one: " + PartOne());
        Console.WriteLine("Part two: " + PartTwo());

    }

    public static int PartOne()
    {
        string[] input = File.ReadLines("input.txt").ToArray();
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
                string SubPath = Path;
                foreach (var directory in Path.Split("-"))
                {
                    if (directory != "")
                    {
                        if (!directorysize.ContainsKey(SubPath))
                        {
                            directorysize.Add(SubPath, 0);
                        }
                        directorysize[SubPath] += size;
                        string Splitpath = SubPath.Split("-").Last();
                        SubPath = SubPath.Remove(SubPath.Length - Splitpath.Length - 1, Splitpath.Length + 1);
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
        return sum;
    }


    public static int PartTwo()
    {
        string[] input = File.ReadLines("input.txt").ToArray();
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
                string SubPath = Path;
                foreach (var directory in Path.Split("-"))
                {
                    if (directory != "")
                    {
                        if (!directorysize.ContainsKey(SubPath))
                        {
                            directorysize.Add(SubPath, 0);
                        }
                        directorysize[SubPath] += size;
                        string Splitpath = SubPath.Split("-").Last();
                        SubPath = SubPath.Remove(SubPath.Length - Splitpath.Length - 1, Splitpath.Length + 1);
                    }
                }
            }
        }
        List<int> deletesizes = new();
        foreach (var item in directorysize)
        {
            Console.WriteLine(directorysize["-/"]);
            if (directorysize["-/"] - item.Value <= 40000000)
            {
                deletesizes.Add(item.Value);
            }
        }
        return deletesizes.Min();
    }
}