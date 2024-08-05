using System.Threading.Tasks;

namespace TaskConsoleApp
{
    //public class Content
    //{
    //    public string Site { get; set; }
    //    public int Len { get; set; }
    //}
    public class Program
    {
        public string CacheData { get; set; }
        public static async Task Main(string[] args)
        {

        }


        //{
        //    Console.WriteLine("Main thread: " + Thread.CurrentThread.ManagedThreadId);
        //    List<string> urlsList = new List<string>()
        //    {
        //        "https://www.google.com",
        //        "https://www.microsoft.com",
        //        "https://www.amazon.com",
        //        //"https://www.n11.com",
        //        "https://www.haberturk.com"
        //    };

        //    List<Task<Content>> taskList = new List<Task<Content>>();

        //    urlsList.ToList().ForEach(x =>
        //    {
        //        taskList.Add(GetContentAsync(x));
        //    });

        //    Console.WriteLine("WaitAll metodundan önce ");

        //    bool result = Task.WaitAll(taskList.ToArray(), 3000);
        //    var firstTaskIndex = Task.WaitAny(taskList.ToArray());

        //    Console.WriteLine("3 saniyede geldi mi ?: " + result);
        //    Console.WriteLine("WaitAll metodundan sonra ");


        //    var contents = await Task.WhenAll(taskList.ToArray());

        //    contents.ToList().ForEach(x =>
        //    {
        //        Console.WriteLine(x.Site);
        //    });

        //    //var firstData = await Task.WhenAny(taskList);//İlk tamamlanan gelecek.
        //    //Console.WriteLine($"{firstData.Result.Site} - {firstData.Result.Len}");

        //    //Console.WriteLine($"{taskList[firstTaskIndex].Result.Site} - {taskList[firstTaskIndex].Result.Len}");

        //    Console.ReadLine();

    }

    //public static async Task<Content> GetContentAsync(string url)
    //{
    //    Content c = new Content();
    //    var data = await new HttpClient().GetStringAsync(url);

    //    await Task.Delay(5000);

    //    c.Site = url;
    //    c.Len = data.Length;
    //    Console.WriteLine("GetContentAsync thread: " + Thread.CurrentThread.ManagedThreadId);

    //    return c;
    //}
}



