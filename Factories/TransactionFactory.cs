using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Factories
{
    public class TransactionFactory
    {

        public static TransactionHeader CreateNewTransaction(int TransactionID, int UserID, DateTime TransactionDate)
        {
            return new TransactionHeader()
            {
                TransactionID = TransactionID,
                UserID = UserID,
                TransactionDate = TransactionDate
            };
        }

    }
}