using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace factorial
{

    [Table(Name = "Client")]
    public class Client
    {
                private string _clientID;
                [Column(IsPrimaryKey = true, Storage = "_ClientID")]
                public string clientID
                {
                    get
                    {
                        return this._clientID;
                    }
                    set
                    {
                        this._clientID = value;
                    }

                }

                private string _Name;
                [Column(Storage = "_Name")]
                public string clientName
                {
                    get
                    {
                        return this._Name;
                    }
                    set
                    {
                        this._Name = value;
                    }
                }


    }

    class StripString
    {
        private string dbString;


        //set dbString to empt string value
        public StripString()
            {
                dbString = "";
            }

        //remove all extra space from string
        public string stripSpaces(string dbVal)
        {
            dbVal = dbVal.Replace(" ", "");
            dbVal = dbVal.Trim();
            return dbVal;
        }

        public string searchDB(string dbSearchVal)
        {
            dbSearchVal = stripSpaces(dbSearchVal);
            
            return dbSearchVal;
        }

        public void db_bind()
        {
            
        }

        public void getData()
        {

            // Use a connection string.
            DataContext db2 = new DataContext
                (@"conection path");

            
            Table<Client> Client = db2.GetTable<Client>();
            
            // Query for clients with specific usernames 
            IQueryable<Client> custQuery2 =
                from clienTT in Client
                where clienTT.clientName.Contains(txtSearch.value)
                select clienTT;


            foreach (Client clienTT in custQuery2)
            {

                Console.WriteLine("Client={1}", clienTT.clientName);
            }


        }

    }


   
}
