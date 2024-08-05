using System;
using System.Threading;
using System.Threading.Tasks;

namespace StartNewDeneme
{
    public class Content
    {
        public string Site { get; set; }
        public string Len { get; set; }
    }

    public class Status
    {
        public int ThreadId { get; set; }
        public DateTime Date { get; set; }
    }
    internal class Program
    {
        private async static Task Main(string[] args)
        {
            var myTask = Task.Factory.StartNew((Obj) =>
            {

                Console.WriteLine("myTask çalıştı.");
                var status = Obj as Status;

                status.ThreadId = Thread.CurrentThread.ManagedThreadId;

            }, new Status() { Date = DateTime.Now });

            await myTask;

            Status s = myTask.AsyncState as Status;

            Console.WriteLine(s.Date);
            Console.WriteLine(s.ThreadId);

            Console.ReadLine();
        }
    }
}
