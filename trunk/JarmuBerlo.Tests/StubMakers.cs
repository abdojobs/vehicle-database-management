using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JarmuBerloDAL;

namespace JarmuBerlo.Tests
{
    public class StubMakers : Makers
    {
        public IDAL Dal;
        
        public override IDAL GetDAL()
        {
            return Dal;
        }
    }
}
