using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using JarmuBerloDAL;
using Rhino.Mocks;

namespace JarmuBerlo.Tests
{
    [TestFixture]
    public class UsersTests
    {
        [Test]
        public void UserLogin_AdminLogin_ManualStub_True()
        {
            Users users = new Users();
            int ret = users.Login("admin", Encrypter.Encrypt("admin"));
            Assert.AreEqual(ret, 0);
        }

        [Test]
        public void UserLogin_AdminLogin_FrameworkStub_True()
        {
            MockRepository repo = new MockRepository();
            Users users = repo.Stub<Users>();
            using (repo.Record())
            {
                users.Login("user", "pass");
            }
            repo.VerifyAll();
        }
    }
}
