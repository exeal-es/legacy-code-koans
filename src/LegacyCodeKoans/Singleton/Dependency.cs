using System;

namespace LegacyCodeKoans.Singleton
{
    public class Dependency
    {
        public static readonly Dependency Instance = new Dependency();

        public void SomeSideEffect()
        {
            throw new Exception("This method should not be called in a unit test!");
        }
    }
}