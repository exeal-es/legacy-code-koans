namespace LegacyCodeKoans.Hardwired
{
    public class Service
    {
        private readonly Dependency dependency;

        public Service()
        {
            dependency = new Dependency();
        }

        public void DoSomething()
        {
            dependency.SomeSideEffect();
        }
    }
}