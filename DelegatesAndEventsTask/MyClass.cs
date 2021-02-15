using System;

namespace DelegatesAndEventsTask
{
    public class MyClass
    {
        public void Space(string str)
        {
            Console.WriteLine(StringMethods.Space(str));
        }

        public void Reverse(string str)
        {
            Console.WriteLine(StringMethods.Reverse(str));
        }
    }
}