using System;

namespace SimpleMailCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern patterns = new Pattern();
            Console.WriteLine(patterns.validatePinCode("abc.58@gmail.com.in"));
            Console.ReadKey();
        }
    }
}
