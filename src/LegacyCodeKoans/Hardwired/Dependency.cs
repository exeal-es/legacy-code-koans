using System;

namespace LegacyCodeKoans.Hardwired
{
    public class Dependency
    {
        public void SomeSideEffect()
        {
            Console.WriteLine("This method should not be called in a unit test!");
        }
    }
}