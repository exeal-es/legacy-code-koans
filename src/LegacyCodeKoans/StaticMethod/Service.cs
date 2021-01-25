namespace LegacyCodeKoans.StaticMethod
{
    public class Service
    {
        public void DoSomething()
        {
            Dependency.SomeSideEffect();
        }
    }
}