using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Delirium.Shared.Services;

namespace Delirium.Shared.Tests
{
    [TestClass]
    public class LoginServiceTests
    {
        [TestMethod]
        public void LoginServiceGetUsersTest()
        {
            var service = new LoginService(@"http://ninjaquartz.noip.me:8080/");
            var data = service.GetUsers().Result;
            Assert.IsNotNull(data);
        }
    }
}
