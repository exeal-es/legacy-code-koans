namespace LegacyCodeKoans.StaticClass
{
    public static class Service
    {
        public static void DoSomething()
        {
            Dependency.SomeSideEffect();
        }
    }
}