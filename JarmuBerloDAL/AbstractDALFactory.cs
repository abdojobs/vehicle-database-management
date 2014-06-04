using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JarmuBerloDAL
{
    public abstract class AbstractDALFactory
    {
        private static IDAL dal = null;

        public static IDAL GetInstance()
        {
            if (dal == null)
            {
                return new DAL();
            }
            return dal;
        }

        public static void SetDal(IDAL newDal)
        {
            dal = newDal;
        }
    }
}