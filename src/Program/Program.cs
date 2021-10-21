using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person joaquin = new Person("Joaquin", "5.285.723-3");
            Person jane = new Person("Jane Doe", "8.765.432-1");
            joaquin.IntroduceYourself();
            jane.IntroduceYourself();
        }
    }
}
