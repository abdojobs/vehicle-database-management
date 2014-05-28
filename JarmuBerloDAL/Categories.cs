using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace JarmuBerloDAL
{
    //egy adatbazisbeli kategoriat reprezentalo osztaly
    public class Category
    {
        private int categoryID;
        private string categoryName;
        private int categoryRoom;

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public int CategoryRoom
        {
            get { return categoryRoom; }
            set { categoryRoom = value; }
        }
        
        public Category() {}

        public Category(int categoryID, string categoryName, int categoryRoom)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
            this.categoryRoom = categoryRoom;
        }
    }

    public class Categories : DAL
    {
        //visszateriti a jarmu kategoriak listajat
        public List<Category> GetCategoryList()
        {
            string query = "SELECT * FROM Kategoriak", error = string.Empty;
            SqlDataReader rdr = ExecuteReader(query, ref error);

            List<Category> categoryList = new List<Category>();
            if (error == "OK")
            {
                while (rdr.Read())
                {
                    Category c = new Category();
                    c.CategoryID = Convert.ToInt32(rdr[0]);
                    c.CategoryName = rdr[1].ToString();
                    c.CategoryRoom = Convert.ToInt32(rdr[2]);
                    categoryList.Add(c);
                }
            }
            CloseDataReader(rdr);

            return categoryList;
        }
    }
}