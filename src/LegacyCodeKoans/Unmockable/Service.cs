namespace LegacyCodeKoans.Unmockable
{
    public class Service
    {
        private readonly Dependency dependency;

        public Service(Dependency dependency)
        {
            this.dependency = dependency;
        }

        public void DoSomething()
        {
            dependency.SomeSideEffect();
        }
    }
}