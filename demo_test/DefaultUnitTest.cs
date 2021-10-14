using demo;
using System;
using Xunit;

namespace demo_test
{
    public class DefaultUnitTest
    {
        
        [Fact]
        public void GetNameSuccess()
        {
            DefaultService defaultService = new DefaultService();
            string name = defaultService.GetName();
            Assert.Equal("demouser", name);
        }

        [Fact]
        public void GetNameFailed()
        {
            DefaultService defaultService = new DefaultService();
            string name = defaultService.GetName();
            Assert.Equal("demo", name);
        }
    }
}
