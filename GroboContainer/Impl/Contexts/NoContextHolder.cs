using GroboContainer.Impl.Injection;

namespace GroboContainer.Impl.Contexts
{
    public class NoContextHolder : IContextHolder
    {
        private NoContextHolder()
        {
        }

        public IInjectionContext GetContext(IInternalContainer worker)
        {
            return new InjectionContext(worker);
        }

        public void KillContext()
        {
        }

        public static readonly NoContextHolder Instance = new NoContextHolder();
    }
}