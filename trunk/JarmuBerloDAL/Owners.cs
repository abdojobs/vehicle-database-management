using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace JarmuBerloDAL
{
    //egy adatbazisbeli tulajdonost reprezentalo osztaly
    public class Owner
    {
        private int ownerID;
        private string ownerName;
        private string ownerEmail;
        private string ownerPhone;
        private string ownerAddress;

        public int OwnerID
        {
            get { return ownerID; }
            set { ownerID = value; }
        }

        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        public string OwnerEmail
        {
            get { return ownerEmail; }
            set { ownerEmail = value; }
        }

        public string OwnerPhone
        {
            get { return ownerPhone; }
            set { ownerPhone = value; }
        }

        public string OwnerAddress
        {
            get { return ownerAddress; }
            set { ownerAddress = value; }
        }

        public Owner() {}

        public Owner(int ownerID, string ownerName, string ownerPhone, string ownerEmail, string ownerAddress)
        {
            this.ownerID = ownerID;
            this.ownerName = ownerName;
            this.ownerPhone = ownerPhone;
            this.ownerEmail = ownerEmail;
            this.ownerAddress = ownerAddress;
        }
    }

    public class Owners
    {
        private IDAL dal;

        public void SetDal(IDAL dal)
        {
            this.dal = dal;
        }

        //visszateriti a tulajdonosok listajat
        public List<Owner> GetOwnerList()
        {
            string query = "SELECT * FROM Tulajdonosok", error = string.Empty;
            SqlDataReader rdr = dal.ExecuteReader(query, ref error);
            dal.CreateConnection();

            List<Owner> ownerList = null;
            if (error == "OK")
            {
                ownerList = new List<Owner>();
                while (rdr.Read())
                {
                    Owner o = new Owner();
                    o.OwnerID = Convert.ToInt32(rdr[0]);
                    o.OwnerName = rdr[1].ToString();
                    o.OwnerPhone = rdr[2].ToString();
                    o.OwnerEmail = rdr[3].ToString();
                    o.OwnerAddress = rdr[4].ToString();
                    ownerList.Add(o);
                }
            }
            dal.CloseDataReader(rdr);

            return ownerList;
        }
    }
}