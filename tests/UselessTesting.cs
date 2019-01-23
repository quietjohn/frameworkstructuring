using System;
using Xunit;
using Interface;
using Framework;
using Framework.Interface;

namespace tests
{
    public class UselessTesting
    {
        [Fact]
        public void UselessTestApi()
        {
            IService srv = new FrameworkService();

            Assert.NotNull(srv);
        }

        [Fact]
        public void UselessTestInternal()
        {
            IInternal intrnl = new InternalComponent();

            Assert.NotNull(intrnl);
        }
    }
}
