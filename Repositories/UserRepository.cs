using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Factories;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class UserRepository
    {

        public static DatabaseEntities db = DatabaseSingleton.getInstance();
        public static MsUser getUserById(String id)
        {

            return db.MsUsers.Where(u => u.UserID.ToString() == id).FirstOrDefault();
        }


        public static int GenerateID()
        {
            if (db == null)
            {
                return 1;
            }
            else
            {
                int maxUserID = db.MsUsers.Max(u => (int?)u.UserID) ?? 0;
                return maxUserID + 1;
            }
        }

        public static MsUser getUserByUsername(String username)
        {

            return db.MsUsers.Where(u => u.UserName == username).FirstOrDefault();
        }

        /*public void CreateUser(string UserName, string Gender, DateTime UserDOB, string UserPhone, string UserAddress, string UserPassword)
        {
            MsUser user = UserFactory.CreateUser(GenerateID(), UserName, Gender, UserDOB, UserPhone, UserAddress, UserPassword, "Customer");
            db.MsUsers.Add(user);
            db.SaveChanges();
        }*/

        public static void Register(MsUser newUser)
        {
            db.MsUsers.Add(newUser);
            db.SaveChanges();

        }

        public static MsUser checkLogin(String UserName, String Password)
        {
            return db.MsUsers.Where(u => u.UserName == UserName
            && u.UserPassword == Password).FirstOrDefault();
        }


    }
}