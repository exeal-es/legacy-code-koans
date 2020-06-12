namespace LegacyCodeKoans.Singleton
{
    public class Service
    {
        public void DoSomething()
        {
            Dependency.Instance.SomeSideEffect();
        }
    }
}