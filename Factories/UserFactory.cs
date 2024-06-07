using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Factories
{
    public class UserFactory
    {

        public static MsUser CreateUser(int UserID, string UserName, string UserGender, DateTime UserDOB, string UserPhone, string UserAddress, string UserPassword, string UserRole)
        {
            return new MsUser()
            {
                UserID = UserID,
                UserName = UserName,
                UserGender = UserGender,
                UserDOB = UserDOB,
                UserPhone = UserPhone,
                UserAddress = UserAddress,
                UserPassword = UserPassword,
                UserRole = UserRole
            };
        }

    }
}