using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RXproject
{
    public class ConsoleColor : IDisposable
    {
        private readonly System.ConsoleColor _previousColor;
        public ConsoleColor(System.ConsoleColor color)
        {
            _previousColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
        }
        public void Dispose()
        {
            Console.ForegroundColor = _previousColor;
        }
    }
    class DisposeColoring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("started");
            ConsoleColor c = new ConsoleColor(System.ConsoleColor.Red);
            Console.WriteLine("end");
            c.Dispose();
            Console.WriteLine("completed");
            Console.ReadKey();
        }
    }
}
