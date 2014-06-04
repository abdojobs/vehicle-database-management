using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using JarmuBerloDAL;

namespace JarmuBerlo.Tests
{
    [TestFixture]
    public class VehiclesTests
    {
        //fuggoseg feloldassa absztrakt osztallyal
        [Test]
        public void RemoveVehicle_ExecutesNonQuery_True()
        {
            AbstractDALFactory.SetDal(new StubDAL());
            Vehicles vehicles = new Vehicles(AbstractDALFactory.GetInstance());
            var ret = vehicles.RemoveVehicle(10);
            Assert.AreEqual(ret, "nonquery");
        }
    }
}
