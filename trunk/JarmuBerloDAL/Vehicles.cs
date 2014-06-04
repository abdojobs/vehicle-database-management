using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.IO;

namespace JarmuBerloDAL
{
    //egy adatbazisbeli jarmuvet reprezentalo osztaly
    public class Vehicle
    {
        private int vehicleID;
        private string makerName;
        private string vehicleModel;
        private int vehicleYear;
        private string categoryName;
        private int vehiclePrice;
        private int vehicleConsumption;

        public int VehicleID
        {
            get { return vehicleID; }
            set { vehicleID = value; }
        }

        public string MakerName
        {
            get { return makerName; }
            set { makerName = value; }
        }

        public string VehicleModel
        {
            get { return vehicleModel; }
            set { vehicleModel = value; }
        }

        public int VehicleYear
        {
            get { return vehicleYear; }
            set { vehicleYear = value; }
        }

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public int VehiclePrice
        {
            get { return vehiclePrice; }
            set { vehiclePrice = value; }
        }
        
        public int VehicleConsumption
        {
            get { return vehicleConsumption; }
            set { vehicleConsumption = value; }
        }
    }

    public class Vehicles
    {
        private IDAL dal;

        public Vehicles(IDAL dal)
        {
            this.dal = dal;
        }

        //megadja a jarmuvek listajat
        public List<Vehicle> GetVehicleList(string makerFilter, string categoryFilter)
        {
            string query = "SELECT JarmuID, Gyartok.Gyartonev, Modell, KiadasEve, Kategoriak.KategoriaNev, Napidij, Fogyasztas " +
                "FROM Jarmuvek, Gyartok, Kategoriak " +
                "WHERE Jarmuvek.GyartoID = Gyartok.GyartoID AND Jarmuvek.KategoriaID = Kategoriak.KategoriaID " +
                "AND Gyartok.GyartoNev LIKE @makerFilter AND Kategoriak.KategoriaNev LIKE @categoryFilter";
            string error = string.Empty;
            string[] parameterNames = { "@makerfilter", "@categoryfilter" };
            string[] parameters = { "%" + makerFilter + "%", "%" + categoryFilter + "%" };
            SqlDataReader rdr = dal.ExecuteReader(query, parameterNames, parameters, ref error);
            
            List<Vehicle> vehicleList = new List<Vehicle>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    Vehicle v = new Vehicle();
                    v.VehicleID = Convert.ToInt32(rdr[0]);
                    v.MakerName = rdr[1].ToString();
                    v.VehicleModel = rdr[2].ToString();
                    v.VehicleYear = Convert.ToInt32(rdr[3]);
                    v.CategoryName = rdr[4].ToString();
                    v.VehiclePrice = Convert.ToInt32(rdr[5]);
                    v.VehicleConsumption = Convert.ToInt32(rdr[6]);

                    vehicleList.Add(v);
                }
            }
            dal.CloseDataReader(rdr);

            return vehicleList;
        }

        //uj jarmu beszurasa
        public int AddVehicle(string makerID, string ownerID, string categoryID, string price, string consumption, string year, string model)
        {
            string[] parameterNames = new string[7];
            string[] parameters = new string[7];
            parameterNames[0] = "@makerID";
            parameterNames[1] = "@ownerID";
            parameterNames[2] = "@categoryID";
            parameterNames[3] = "@price";
            parameterNames[4] = "@consumption";
            parameterNames[5] = "@year";
            parameterNames[6] = "@model";
            parameters[0] = makerID;
            parameters[1] = ownerID;
            parameters[2] = categoryID;
            parameters[3] = price;
            parameters[4] = consumption;
            parameters[5] = year;
            parameters[6] = model;

            return dal.ExecuteStoredProcedureNonQuery("JarmuHozzaadas", parameterNames, parameters);
        }

        //jarmu torlese
        public string RemoveVehicle(int vehicleId)
        {
            string query = "DELETE FROM Jarmuvek WHERE JarmuId = " + vehicleId;
            return dal.ExecuteNonQuery(query);
        }

        //jarmuvek exportalasa XML fileba
        public void ExportVehiclesXML(string file)
        {
            string query = "SELECT KategoriaNev, Ferohelyek, (SELECT GyartoNev, Modell, KiadasEve, Napidij, Fogyasztas, KategoriaID FROM Jarmuvek j, Gyartok g" +
                " WHERE j.GyartoID = g.GyartoID AND j.KategoriaID = Kategoria.KategoriaID FOR XML PATH('Jarmu'), TYPE)" +
                " FROM Kategoriak Kategoria WHERE EXISTS(SELECT * FROM Jarmuvek j WHERE j.KategoriaID = Kategoria.KategoriaID) FOR XML AUTO, ROOT('OsszesJarmu')";
            string error = string.Empty;
            SqlDataReader rdr = dal.ExecuteReader(query, ref error);
            string result = "";
            while (rdr.Read())
            {
                result += rdr[0].ToString();
            }
            File.WriteAllText(file,result.Replace("><", ">\n<"));
            dal.CloseDataReader(rdr);
            XslCompiledTransform xslTrans = new XslCompiledTransform();
            xslTrans.Load("VehicleTransform.xslt");
            xslTrans.Transform(new XPathDocument(file), null, new XmlTextWriter(file.Replace(".xml", ".html"), null));
        }
    }
}