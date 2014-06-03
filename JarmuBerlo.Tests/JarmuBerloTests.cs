using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using JarmuBerloDAL;

namespace JarmuBerlo.Tests
{
    [TestFixture]
    public class JarmuBerloTests
    {
        [Test]
        public void UserLogin_AdminLogin_True()
        {
            Users users = new Users();
            int ret = users.Login("admin", Encrypter.Encrypt("admin"));
            Assert.AreEqual(ret, 0);
        }

        [Test]
        public void GetMakerList_BuildsList_True()
        {
            StubMakers stubMakers = new StubMakers();
            stubMakers.Dal = new StubDAL();
            var ret = stubMakers.GetMakerList();
            Assert.AreEqual(ret, null);
        }
    }
}
