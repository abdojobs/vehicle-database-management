using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.IO;

namespace JarmuBerloDAL
{
    //egy adatbazisbeli berlest reprezentalo osztaly
    public class Loan
    {
        private int loanID;
        private int vehicleID;
        private int loanerID;
        private string loanStart;
        private string loanEnd;
        private int cost;

        public int LoanID
        {
            get { return loanID; }
            set { loanID = value; }
        }

        public int VehicleID
        {
            get { return vehicleID; }
            set { vehicleID = value; }
        }

        public int LoanerID
        {
            get { return loanerID; }
            set { loanerID = value; }
        }

        public string LoanStart
        {
            get { return loanStart; }
            set { loanStart = value; }
        }

        public string LoanEnd
        {
            get { return loanEnd; }
            set { loanEnd = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }

    public class Loans
    {
        private IDAL dal;

        public Loans(IDAL dal)
        {
            this.dal = dal;
        }

        //visszateriti a berlesek listajat
        public List<Loan> GetLoanList(string makerFilter, string categoryFilter)
        {
            string query = "SELECT * FROM Berlesek";
            string error = string.Empty;
            SqlDataReader rdr = dal.ExecuteReader(query, ref error);

            List<Loan> loanList = new List<Loan>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    Loan v = new Loan();
                    v.LoanID = Convert.ToInt32(rdr[0]);
                    v.VehicleID = Convert.ToInt32(rdr[1]);
                    v.LoanerID = Convert.ToInt32(rdr[2]);
                    v.LoanStart = rdr[3].ToString();
                    v.LoanEnd = rdr[4].ToString();
                    v.Cost = Convert.ToInt32(rdr[5]);

                    loanList.Add(v);
                }
            }
            dal.CloseDataReader(rdr);

            return loanList;
        }


        //vegrehajt egy berles beszurast a tranzakcios tarolt eljaras meghivasaval
        public int Loan(int vehicleID, int loanerID, string startDate, string endDate)
        {
            string[] parameterNames = new string[4];
            string[] parameters = new string[4];
            parameterNames[0] = "@vehicleID"; 
            parameterNames[1] = "@loanerID"; 
            parameterNames[2] = "@startDate"; 
            parameterNames[3] = "@endDate";
            parameters[0] = vehicleID.ToString();
            parameters[1] = loanerID.ToString();
            parameters[2] = startDate;
            parameters[3] = endDate;

            return dal.ExecuteStoredProcedureNonQuery("Berles", parameterNames, parameters);
        }

        //visszateriti egy jarmure a datumokat, amelyeken foglalt
        public string GetOccupiedDates(int vehicleID)
        {
            string query = "SELECT BerlesKezdete, BerlesVege FROM Berlesek " +
                "WHERE BerlesKezdete >= (GetDate() - 1) AND JarmuID = " + vehicleID.ToString();
            string error = string.Empty;
            SqlDataReader rdr = dal.ExecuteReader(query, ref error);

            string ret = "";
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    ret += "\n" + rdr[0].ToString().Split(' ')[0] + " - " + rdr[1].ToString().Split(' ')[0];
                }
            }
            dal.CloseDataReader(rdr);

            return ret.Equals("") ? "A járművet még nem foglalták le." : "A jármű a következő dátumokkon foglalt:\n" + ret;
        }

        //megadja, hogy egy jarmu foglalt-e ket datum kozott
        public int IsFree(int vehicleID, string startDate, string endDate)
        {
            string[] parameterNames = new string[3];
            string[] parameters = new string[3];
            parameterNames[0] = "@vehicleID";
            parameterNames[1] = "@startDate";
            parameterNames[2] = "@endDate";
            parameters[0] = vehicleID.ToString();
            parameters[1] = startDate;
            parameters[2] = endDate;

            return dal.ExecuteStoredProcedureNonQuery("Szabad", parameterNames, parameters);
        }

        public void RemoveLoans(int vehicleID)
        {
            string query = "DELETE FROM Berlesek WHERE JarmuID = " + vehicleID.ToString();
            dal.ExecuteNonQuery(query);
        }

        //XML-t exportal a berlesekkel
        public void ExportLoansXML(string file)
        {
            string query = "SELECT BerloNev, Telefonszam, Jogositvanyszam, (SELECT GyartoNev, Modell Jarmu, BerlesKezdete, BerlesVege, Szamla FROM Jarmuvek j, Berlesek b, Gyartok g" + 
                " WHERE j.JarmuID = b.JarmuID AND j.GyartoID = g.GyartoID AND b.BerloID = Berlo.BerloID FOR XML PATH('Berles'), TYPE) " +
                " FROM Berlok Berlo WHERE EXISTS(SELECT * FROM Berlesek b WHERE b.BerloID = Berlo.BerloID) FOR XML AUTO, ROOT('OsszesBerlo')";
            string error = string.Empty;
            SqlDataReader rdr = dal.ExecuteReader(query, ref error);
            string result = "";
            while (rdr.Read())
            {
                result += rdr[0].ToString();
            }
            File.WriteAllText(file, result.Replace("><", ">\n<"));
            dal.CloseDataReader(rdr);
            XslCompiledTransform xslTrans = new XslCompiledTransform();
            xslTrans.Load("LoanTransform.xslt");
            xslTrans.Transform(new XPathDocument(file), null, new XmlTextWriter(file.Replace(".xml", ".html"), null));
        }
    }
}