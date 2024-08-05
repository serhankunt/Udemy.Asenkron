using System.Text;

public class Program
{
    public static string CacheData { get; set; } = default!;
    public static async Task Main(string[] args)
    {
        CacheData = await GetDataAsync();
    }

    public static async Task<string> GetDataAsync()
    {

        await Task.Run<string>(() =>
        {
            return "fatih";
        });

        if (String.IsNullOrEmpty(CacheData))
        {
            var result = await File.ReadAllTextAsync("dosya.txt", Encoding.UTF8);
            Console.WriteLine(result);
            return result;

        }
        else
        {
            var result = await Task.FromResult<string>(CacheData);
            Console.WriteLine(result);
            return result;
        }
    }
}