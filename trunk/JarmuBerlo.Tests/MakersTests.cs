using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using JarmuBerloDAL;

namespace JarmuBerlo.Tests
{
    [TestFixture]
    public class MakersTests
    {
        //fuggoseg feloldasa absztrakt metodussal
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
