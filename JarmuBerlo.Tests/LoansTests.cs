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
    public class LoansTests
    {
        //fuggoseg megszuntetese konstruktorbol
        [Test]
        public void ExecuteNonQuery_DynamicFrameworkMock_MethodCalled()
        {
            MockRepository repo = new MockRepository();
            IDAL dal = repo.StrictMock<IDAL>();
            using (repo.Record())
            {
                Expect.Call(dal.ExecuteNonQuery("DELETE FROM Berlesek WHERE JarmuID = 10")).Return("OK");
            }
            Loans loans = new Loans(dal);
            loans.RemoveLoans(10);
            repo.VerifyAll();
        }

        //fuggoseg megszuntetese konstruktorbol
        [Test]
        public void IsFree_ManualStub()
        {
            Loans loans = new Loans(new StubDAL());
            var ret = loans.IsFree(44, "1999", "2012");
            Assert.AreEqual(ret, -10);
        }
    }
}
