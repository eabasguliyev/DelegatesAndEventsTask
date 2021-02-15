using System;
namespace DelegatesAndEventsTask
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");

            var str = Console.ReadLine();

            var cls = new MyClass();

            MyFunc funcDell = cls.Space;
            funcDell += cls.Reverse;

            var run = new Run();

            run.RunFunc(funcDell, str);
        }
    }
}
