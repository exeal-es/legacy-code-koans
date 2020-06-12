using System;

namespace LegacyCodeKoans.Singleton
{
    public class Dependency
    {
        public static readonly Dependency Instance = new Dependency();

        public void SomeSideEffect()
        {
            Console.WriteLine("This method should not be called in a unit test!");
        }
    }
}