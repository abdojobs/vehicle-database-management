using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using JarmuBerloDAL;

namespace JarmuBerlo.Tests
{
    public class OwnersTests
    {
        //fuggoseg megszuntetese setter metodussal
        [Test]
        public void GetOwnerList_ManualMock_MethodCalled()
        {
            Owners owners = new Owners();
            MockDAL mock = new MockDAL();
            owners.SetDal(mock);
            var ret = owners.GetOwnerList();
            Assert.AreEqual(true, mock.ExecuteReaderCalled);
        }
    }
}
