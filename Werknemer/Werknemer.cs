using System;
using System.Collections.Generic;
using System.Text;

namespace Werknemer
{
    class Werknemer
    {
        //Database db;
        public Werknemer()
        {
            //db = new Database();
        }
        void Insert()
        {
            try
            {
                string sql = "insert into werkemers(voornaam,achternaam,stad) values('Jesse','Viskens','Antwerpen')";
                //db.Query(sql);
            }
            catch (Exception e)
            {
                //Log error
                System.IO.File.WriteAllText(@"C:\Error.txt", e.ToString());
            }
        }
        void Delete() { }
        void Update() { }
    }
}
