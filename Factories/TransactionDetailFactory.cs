using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Factories
{
    public class TransactionDetailFactory
    {

        public static TransactionDetail CreateTDetail(int TransactionID, int StationeryID, int Quantity)
        {
            return new TransactionDetail()
            {
                TransactionID = TransactionID,
                StationeryID = StationeryID,
                Quantity = Quantity
            };
        }

    }
}