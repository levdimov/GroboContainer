using System;

using GroboContainer.Core;
using GroboContainer.Impl.ClassCreation;
using GroboContainer.Impl.Injection;
using GroboContainer.New;

namespace GroboContainer.Impl.Implementations
{
    public class ContainerImplementationConfiguration : IImplementationConfiguration
    {
        public Type ObjectType => typeof(Container);

        public object GetOrCreateInstance(IInjectionContext context, ICreationContext creationContext, Type requestedType)
        {
            context.Reused(typeof(IContainer));
            return context.Container;
        }

        //NOTE do nothing
        public void DisposeInstance()
        {
        }

        public IClassFactory GetFactory(Type[] parameterTypes, ICreationContext creationContext)
        {
            throw new NotSupportedException();
        }
    }
}