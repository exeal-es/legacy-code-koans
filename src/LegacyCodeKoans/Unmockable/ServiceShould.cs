using Xunit;

namespace LegacyCodeKoans.Unmockable
{
    public class ServiceShould
    {
        [Fact]
        public void DoSomething()
        {
            Dependency dependency = new Dependency();
            var service = new Service(dependency);
            service.DoSomething();
            
            // TODO: Assert Dependency.SomeSideEffect() method was called
        }
    }
}