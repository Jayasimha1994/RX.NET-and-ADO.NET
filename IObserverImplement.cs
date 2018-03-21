using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXproject
{
    public class MyConsoleObserver<T> : IObserver<T>
    {
        public void OnNext(T value)
        {
            Console.WriteLine("Received value {0}", value);
        }
        public void OnError(Exception error)
        {
            Console.WriteLine("Sequence faulted with {0}", error);
        }
        public void OnCompleted()
        {
            Console.WriteLine("Sequence terminated");
        }
    }
    class IObserverImplement
    {
        static void Main(string[] args)
        {
            MyConsoleObserver<int> m = new MyConsoleObserver<int>();
            m.OnNext(10);
            m.OnError(new Exception());
            m.OnCompleted();
            Console.ReadLine();
        }
    }
}
