using System;

using GroboContainer.Tests.ImplTests;

using NUnit.Framework;

namespace GroboContainer.Tests.FunctionalTests
{
    public class ContainerExceptionsTest : ContainerTestBase
    {
        [Test]
        public void TestExceptionInConstructor()
        {
            var c1 = container.Create<string, C1>("s");
            RunMethodWithException<MockException>(() => c1.createC2());
            RunFail<MockException>(() => container.Create<int, C1>(1));
        }

        private class C2
        {
            public C2()
            {
                throw new MockException();
            }
        }

        private class C1
        {
            public C1(Func<C2> createC2, string s)
            {
                this.createC2 = createC2;
            }

            public C1(Func<C2> createC2, int i)
            {
                createC2();
            }

            public readonly Func<C2> createC2;
        }
    }
}