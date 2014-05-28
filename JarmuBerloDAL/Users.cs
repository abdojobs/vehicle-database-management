using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.IO;

namespace JarmuBerloDAL
{
    //egy adatbazisbeli felhasznalot reprezentalo osztaly
    public class User
    {
        private int userID;
        private int groupID;
        private string username;
        private string hashedPassword;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public int GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string HashedPassword
        {
            get { return hashedPassword; }
            set { hashedPassword = value; }
        }

        public User() {}

        public User(int userID, int groupID, string username, string hashedPassword)
        {
            this.userID = userID;
            this.groupID = groupID;
            this.username = username;
            this.hashedPassword = hashedPassword;
        }
    }

    public class Users : DAL
    {
        //megadja a felhasznalok listajat
        public List<User> GetUserList()
        {
            string query = "SELECT * FROM Felhasznalok", error = string.Empty;
            SqlDataReader rdr = ExecuteReader(query, ref error);

            List<User> userList = new List<User>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    User u = new User();
                    u.UserID = Convert.ToInt32(rdr[0]);
                    u.GroupID = Convert.ToInt32(rdr[1]);
                    u.Username = rdr[2].ToString();
                    u.HashedPassword = rdr[3].ToString();
                    userList.Add(u);
                }
            }
            CloseDataReader(rdr);

            return userList;
        }

        //uj felhasznalo hozzaadasa tarolt eljara segitsegevel
        public int AddUser(int groupID, string username, string password)
        {
            string[] parameterNames = new string[3];
            string[] parameters = new string[3];
            parameterNames[0] = "@groupID";
            parameterNames[1] = "@username";
            parameterNames[2] = "@password";
            parameters[0] = groupID.ToString();
            parameters[1] = username;
            parameters[2] = password;

            return ExecuteStoredProcedureNonQuery("UjFelhasznalo", parameterNames, parameters);
        }

        //felhasznalo torlese tarolt eljara segitsegevel
        public int RemoveUser(int userID)
        {
            string[] parameterNames = new string[1];
            string[] parameters = new string[1];
            parameterNames[0] = "@userID";
            parameters[0] = userID.ToString();

            return ExecuteStoredProcedureNonQuery("FelhasznaloTorles", parameterNames, parameters);
        }
        
        //berlo hozzaadasa
        public int AddLoaner(int groupID, string username, string password, string fullName, string phoneNumber, string licenseNumber)
        {
            string[] parameterNames = new string[6];
            string[] parameters = new string[6];
            parameterNames[0] = "@groupID";
            parameterNames[1] = "@username";
            parameterNames[2] = "@password";
            parameterNames[3] = "@fullName";
            parameterNames[4] = "@phoneNumber";
            parameterNames[5] = "@licenseNumber";
            parameters[0] = groupID.ToString();
            parameters[1] = username;
            parameters[2] = password;
            parameters[3] = fullName;
            parameters[4] = phoneNumber;
            parameters[5] = licenseNumber;

            return ExecuteStoredProcedureNonQuery("UjBerlo", parameterNames, parameters);
        }

        //bejelentkezes tarolt eljarassal
        public int Login(string username, string password)
        {
            string[] parameterNames = new string[2];
            string[] parameters = new string[2];
            parameterNames[0] = "@username";
            parameterNames[1] = "@password";
            parameters[0] = username;
            parameters[1] = password;
            return ExecuteStoredProcedureNonQuery("Belepes", parameterNames, parameters);
        }

        //felhasznalok exportalasa XML fileba
        public void ExportUsersXML(string file)
        {
            string query = "SELECT CsoportNev, (SELECT FelhasznaloID, FelhasznaloNev, Jelszo FROM Felhasznalok f" +
                " WHERE Csoport.CsoportID = f.CsoportID FOR XML PATH('Felhasznalo'), TYPE)" +
                " FROM FelhasznaloCsoportok Csoport FOR XML AUTO, ROOT('OsszesFelhasznalo')";
            string error = string.Empty;
            SqlDataReader rdr = ExecuteReader(query, ref error);
            string result = "";
            while (rdr.Read())
            {
                result += rdr[0].ToString();
            }
            File.WriteAllText(file, result.Replace("><", ">\n<"));
            CloseDataReader(rdr);
            XslCompiledTransform xslTrans = new XslCompiledTransform();
            xslTrans.Load("UserTransform.xslt");
            xslTrans.Transform(new XPathDocument(file), null, new XmlTextWriter(file.Replace(".xml", ".html"), null));
        }
    }
}