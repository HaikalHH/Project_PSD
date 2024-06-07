using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Factories
{
    public class CartFactory
    {

        public static Cart CreateCart(int UserID, int StationeryID, int Quantity)
        {
            return new Cart()
            {
                UserID = UserID,
                StationeryID = StationeryID,
                Quantity = Quantity
            };
        }

    }
}