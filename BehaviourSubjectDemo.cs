using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RXproject
{
    class BehaviourSubjectDemo
    {
        public static void BehaviorSubjectExample()
        {
            var subject = new BehaviorSubject<string>("a");
            subject.Subscribe(Console.WriteLine);
        }
        public static void BehaviorSubjectExample2()
        {
            var subject = new BehaviorSubject<string>("a");
            subject.OnNext("b");
            subject.Subscribe(Console.WriteLine);
        }
        public static void BehaviorSubjectCompletedExample()
        {
            var subject = new BehaviorSubject<string>("a");
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnCompleted();
            subject.Subscribe(Console.WriteLine);
        }
        public static void BehaviorSubjectExample3()
        {
            var subject = new BehaviorSubject<string>("a");
            subject.OnNext("b");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("c");
            subject.OnNext("d");
        }
        static void Main(string[] args)
        {
            BehaviorSubjectExample();
            BehaviorSubjectExample2();
            BehaviorSubjectCompletedExample();
            BehaviorSubjectExample3();
            Console.ReadKey();
        }
    }
}
