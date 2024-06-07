using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class DatabaseSingleton
    {

        private static DatabaseEntities db;

        public static DatabaseEntities getInstance()
        {
            if (db == null)
            {
                db = new DatabaseEntities();
            }
            return db;
        }

    }
}