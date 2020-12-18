using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xyrille.ResearchDatabaseManagement.Windows.DAL;
using Xyrille.ResearchDatabaseManagement.Windows.Enums;
using Xyrille.ResearchDatabaseManagement.Windows.Helpers;
using Xyrille.ResearchDatabaseManagement.Windows.Models;

namespace Xyrille.ResearchDatabaseManagement.Windows.BBL
{
    class UsersBBL
    {
        private static RDBManagementDBContext db = new RDBManagementDBContext();


        public static Operation Add(User user)
        {
            try
            {
                user.IsActive = true;
                db.Users.Add(user);
                db.SaveChanges();

                return new Operation()
                {
                    Code = "200",
                    Message = "Ok",
                    ReferenceId = user.UserID
                };
            }
            catch (Exception e)
            {
                return new Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }

        public static User GetById(Guid? id)
        {
            return db.Users.FirstOrDefault(u => u.UserID == id);
        }


        public static List<Role> GetRoles(Guid? id)
        {
            return db.UserRoles.Where(ur => ur.UserId == id).Select(ur => ur.Role).ToList();
        }


        public static Operation Deactivate(Guid? userId)
        {
            try
            {
                User oldRecord = db.Users.FirstOrDefault(u =>  u.UserID == userId);

                if (oldRecord != null)
                {
                    oldRecord.IsActive = false;

                    db.SaveChanges();

                    return new Operation()
                    {
                        Code = "200",
                        Message = "OK"
                    };
                }

                return new Operation()
                {
                    Code = "500",
                    Message = "Not found"
                };
            }
            catch (Exception e)
            {
                return new Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }

        public static Operation Login(string emailAddress = "", string password = "")
        {
            if (string.IsNullOrEmpty(emailAddress))
            {
                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
                };
            }

            if (string.IsNullOrEmpty(password))
            {
                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
                };
            }

            try
            {
                User user = db.Users.FirstOrDefault(u => u.UserEmail.ToLower() == emailAddress.ToLower());

                if (user == null)
                {
                    return new Operation()
                    {
                        Code = "500",
                        Message = "Invalid Login"
                    };
                }

                if (password == user.Password)
                {
                    return new Operation()
                    {
                        Code = "200",
                        Message = "Successful Login",
                        ReferenceId = user.UserID
                    };
                }

                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
                };
            }
            catch (Exception e)
            {
                return new Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }
    }
}
