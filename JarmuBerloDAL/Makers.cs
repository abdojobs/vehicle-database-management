using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace JarmuBerloDAL
{
    public class Maker
    {
        private int makerID;
        private int countryID;
        private string makerName;
        private int makerFoundYear;

        public int MakerID
        {
            get { return makerID; }
            set { makerID = value; }
        }

        public int CountryID
        {
            get { return countryID; }
            set { countryID = value; }
        }

        public string MakerName
        {
            get { return makerName; }
            set { makerName = value; }
        }

        public int MakerFoundYear
        {
            get { return makerFoundYear; }
            set { makerFoundYear = value; }
        }

        public Maker() {}

        public Maker(int makerID, int countryID, string makerName, int makerFoundYear)
        {
            this.makerID = makerID;
            this.countryID = countryID;
            this.makerName = makerName;
            this.makerFoundYear = makerFoundYear;
        }
    }

    //fuggoseg feloldasa abstract method hasznalataval
    public class Makers
    {
        public List<Maker> GetMakerList()
        {
            IDAL dal = GetDAL();
            string query = "SELECT * FROM Gyartok", error = string.Empty;
            SqlDataReader rdr = dal.ExecuteReader(query, ref error);

            List<Maker> makerList = null;
            if (error == "OK")
            {
                makerList = new List<Maker>();
                while (rdr.Read())
                {
                    Maker m = new Maker();
                    m.MakerID = Convert.ToInt32(rdr[0]);
                    m.CountryID = Convert.ToInt32(rdr[1]);
                    m.MakerName = rdr[2].ToString();
                    m.MakerFoundYear = Convert.ToInt32(rdr[3]);
                    makerList.Add(m);
                }
            }
            dal.CloseDataReader(rdr);

            return makerList;
        }

        public virtual IDAL GetDAL()
        {
            return new DAL();
        }
    }
}