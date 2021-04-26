using System;
using System.Collections.Generic;
using System.Text;

namespace Werknemer
{
    class Werknemer
    {
        //Database db;
        FileLogger logger;
        public Werknemer()
        {
            //db = new Database();
            logger = new FileLogger();
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
                logger.Log(e.ToString());
            }
        }
        void Delete() { }
        void Update() { }
    }
}
