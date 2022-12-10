namespace Day_7;
class Program
{

    static void Main(string[] args)
    {

        string[] input = File.ReadLines("example.txt").ToArray();
        Dictionary<string, int> directorysize = new();
        string Path ="";
        foreach (var item in input[1..])
        {

            if (item.Contains("$ cd "))
            {
				string folder = item.Split(" ")[2];

				if(!item.Contains("$ cd ..")){
                Path += "-" + folder;
				Console.WriteLine(Path.LastIndexOf(folder));
				}else{
					var SubPath = Path.Split("-");
					Path = Path.Remove(Path.LastIndexOf("-" + SubPath.Last()));
				}
            }
            else if (StartsNum(item))
            {
                int size = int.Parse(item.Split(" ")[0]);
				foreach (var directory in Path.Split("-"))
                {
					if(directory != ""){
                    var SubPath = Path.Remove(Path.LastIndexOf(directory)+1);
					Console.WriteLine(SubPath);
                    if (!directorysize.ContainsKey(SubPath))
                    {
                        directorysize.Add(SubPath, 0);
                    }
                    directorysize[SubPath] += size;
                    }
                }
            }
        }
		int sum=0;
		foreach(var item in directorysize){
			if(item.Value <= 100000){
				sum += item.Value;
			}
		}
		Console.WriteLine(sum);
    }
	static bool StartsNum(string input)
        {
            return char.IsDigit(input[0]);
        }
}
