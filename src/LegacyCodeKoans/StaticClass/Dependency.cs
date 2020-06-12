using System;

namespace LegacyCodeKoans.StaticClass
{
    public class Dependency
    {
        public static void SomeSideEffect()
        {
            Console.WriteLine("This method should not be called in a unit test!");
        }
    }
}