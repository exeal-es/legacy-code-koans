using System;

namespace LegacyCodeKoans.Hardwired
{
    public class Dependency
    {
        public void SomeSideEffect()
        {
            throw new Exception("This method should not be called in a unit test!");
        }
    }
}