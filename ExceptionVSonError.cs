using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RXproject
{
    class ExceptionVSonError
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    values.Subscribe(value => Console.WriteLine("1st subscription received {0}", value));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Won't catch anything here!");
            //}
            //values.OnNext(0);
            //values.OnError(new Exception("Dummy exception"));
            //----------------------------------------------------------------
            var values = new Subject<int>();
            values.Subscribe(
            value => Console.WriteLine("1st subscription received {0}", value),
            ex => Console.WriteLine("Caught an exception : {0}", ex));
            values.OnNext(0);
            values.OnError(new Exception("Dummy exception"));
            Console.ReadKey();
        }
    }
}
