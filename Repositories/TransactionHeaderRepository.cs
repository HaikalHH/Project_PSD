using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Factories;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{

    public class TransactionHeaderRepository
    {
        private static DatabaseEntities db = DatabaseSingleton.getInstance();

        public static int GenerateID()
        {
            int newID = db.TransactionHeaders.Select(x => x.TransactionID).ToList().LastOrDefault();
            if (newID == 0)
            {
                newID = 1;
            }
            else
            {
                newID++;
            }

            return newID;
        }

        public static List<TransactionHeader> GetListTransactionHeaders()
        {
            return db.TransactionHeaders.ToList();
        }

        public static void AddTransactionHeader(int userId)
        {
            int transactionId = GenerateID();
            DateTime now = DateTime.Now;
            TransactionHeader createTransactionHeader = TransactionFactory.CreateNewTransaction(transactionId, userId, now);
            db.TransactionHeaders.Add(createTransactionHeader);
            db.SaveChanges();
        }

        public static int GetTransactionId()
        {
            return db.TransactionHeaders.Select(x => x.TransactionID).ToList().LastOrDefault();
        }
    }

}