using System;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // var data = new DateTime(2025, 10, 10, 19, 03, 45);
            // var formatada = String.Format("{0:dd/MM/yyyy}",data);
            // // var data = DateTime.Now;
            // Console.WriteLine(formatada);
            // var utcDate = DateTime.UtcNow;
            // Console.WriteLine(DateTime.Now);
            // Console.WriteLine(utcDate);
            // Console.WriteLine(utcDate.ToLocalTime());
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);    
            var timeSpansec = new TimeSpan(1222);
            Console.WriteLine(timeSpansec);    
            var timeSpans = new TimeSpan(13,24,23,1222,12323);
            Console.WriteLine(timeSpans);    
            
            
        }
    }
}
