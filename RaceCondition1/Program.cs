class Program
{
    private static void Main(string[] args)
    {
        long totalByte = 0;

        var files = Directory.GetFiles(@"C:\Users\hserh\Pictures\deneme");

        Parallel.For(0, files.Length, (index) =>
        {
            var file = new FileInfo(files[index]);

            Interlocked.Add(ref totalByte, file.Length);
        });

        Console.WriteLine("Total byte: " + totalByte.ToString());
    }
}