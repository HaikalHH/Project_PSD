using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Handlers
{
    public class TransactionHeaderHandler
    {
        public static string AddTransactionHeader(int userId)
        {
            TransactionHeaderRepository.AddTransactionHeader(userId);
            return "Success";
        }

        public static List<TransactionHeader> GetListTransactionHeaders()
        {
            List<TransactionHeader> transactionHeaders = TransactionHeaderRepository.GetListTransactionHeaders();
            if (transactionHeaders != null)
            {
                return transactionHeaders;
            }

            return new List<TransactionHeader>();
        }

        public static int GetTransactionId()
        {
            return TransactionHeaderRepository.GetTransactionId();
        }
    }
}