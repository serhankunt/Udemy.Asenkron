using System.Collections.Concurrent;

class Program
{
    private static void Main(string[] args)
    {
        ConcurrentBag<int> sonuçlar = new ConcurrentBag<int>();

        Parallel.ForEach(Enumerable.Range(1, 100).ToList(), (x) =>
        {
            sonuçlar.Add(x);
        });

        Console.WriteLine("Son değer: " + sonuçlar.Last());

        //-------------------------1.KISIM---------------------------------
        //long FilesByte = 0;
        //Stopwatch sw = new Stopwatch();
        //sw.Start();
        //string picturesPath = @"C:\Users\hserh\Pictures\deneme";

        //var files = Directory.GetFiles(picturesPath);

        //Parallel.ForEach(files, (item) =>
        //{

        //    Console.WriteLine("thread No: " + Thread.CurrentThread.ManagedThreadId);
        //    FileInfo f = new FileInfo(item);

        //    //1.dosya 100 byte olsun
        //    //2.dosya 200 byte olsun
        //    //3.dosya 300 byte olsun
        //    //4.dosya 400 byte olsun
        //    //5.dosya 500 byte olsun

        //    Interlocked.Add(ref FilesByte, f.Length);

        //    Interlocked.Exchange(ref FilesByte, 300);
        //});

        //Console.WriteLine("Toplam boyut: " + FilesByte.ToString());

        //--------------------------------2.KISIM-----------------------------------

        //try
        //{
        //    string picturePath = "C:\\Users\\hserh\\Pictures\\deneme\\";

        //    var files = Directory.GetFiles(picturePath);

        //    Parallel.ForEach(files, (item) =>
        //    {
        //        Console.WriteLine("thread no: " + Thread.CurrentThread.ManagedThreadId);
        //        Image img = new Bitmap(item);
        //        var thumbnail = img.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);

        //        thumbnail.Save(Path.Combine(picturePath, "thumbnail", Path.GetFileName(item)));


        //    });
        //    Console.WriteLine("İşlem bitti");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    throw;
        //}

    }
}