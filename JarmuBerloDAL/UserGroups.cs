using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace JarmuBerloDAL
{
    //egy adatbazisbeli felhasznalocsoportot reprezentalo osztaly
    public class UserGroup
    {
        private int groupID;
        private string groupName;

        public int GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        public UserGroup() {}

        public UserGroup(int groupID, string groupName)
        {
            this.groupID = groupID;
            this.groupName = groupName;
        }
    }

    public class UserGroups : DAL
    {
        //megadja a felhasznalocspoportok listajat
        public List<UserGroup> GetUserGroupList()
        {
            string query = "SELECT * FROM FelhasznaloCsoportok", error = string.Empty;
            SqlDataReader rdr = ExecuteReader(query, ref error);

            List<UserGroup> userGroupList = new List<UserGroup>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    UserGroup ug = new UserGroup();
                    ug.GroupID = Convert.ToInt32(rdr[0]);
                    ug.GroupName = rdr[1].ToString();
                    userGroupList.Add(ug);
                }
            }
            CloseDataReader(rdr);

            return userGroupList;
        }
    }
}
