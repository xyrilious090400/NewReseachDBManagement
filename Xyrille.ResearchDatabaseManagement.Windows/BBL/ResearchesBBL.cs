using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xyrille.ResearchDatabaseManagement.Windows.DAL;
using Xyrille.ResearchDatabaseManagement.Windows.DTO;
using Xyrille.ResearchDatabaseManagement.Windows.Helpers;
using Xyrille.ResearchDatabaseManagement.Windows.Models;

namespace Xyrille.ResearchDatabaseManagement.Windows.BBL
{
    public static class ResearchesBBL
    {
        private static RDBManagementDBContext db = new RDBManagementDBContext();

        public static Paged<ResearchDTO> Search(int pageIndex = 1, int pageSize = 1, string sortBy = "lastname", string sortOrder = "asc", string keyword = "")
        {
            IQueryable<Research> allResearches = (IQueryable<Research>)db.Researches;
            Paged<Models.Research> researches = new Paged<Models.Research>();

            allResearches = allResearches.Where(e => e.IsPublish == true);



            if (!string.IsNullOrEmpty(keyword))
            {
                allResearches = allResearches.Where(e => e.Author.Contains(keyword) || e.Title.Contains(keyword));
            }

            var queryCount = allResearches.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "title" && sortOrder.ToLower() == "asc")
            {
                researches.Items = allResearches.OrderBy(e => e.Title).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "lastname" && sortOrder.ToLower() == "desc")
            {
                researches.Items = allResearches.OrderByDescending(e => e.Author).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "salary" && sortOrder.ToLower() == "asc")
            {
                researches.Items = allResearches.OrderBy(e => e.Year).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                researches.Items = allResearches.OrderByDescending(e => e.Year).Skip(skip).Take(pageSize).ToList();
            }

            researches.PageCount = pageCount;
            researches.QueryCount = queryCount;
            researches.PageIndex = pageIndex;
            researches.PageSize = pageSize;

            var result = new Paged<ResearchDTO>();
            result.PageCount = pageCount;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.PageSize = pageSize;
            result.Items = new List<ResearchDTO>();

            foreach (var research in researches.Items)
            {
                
            

                result.Items.Add(new ResearchDTO()
                {
                    ResearchID = research.ResearchID,
             
                    Author = research.Author,
                    Title = research.Title,
                    Abstract = research.Abstract,
                    Leadline = research.Leadline,
                    Year = research.Year,
                });
            }

            return result;
        }




        public static Operation Add(Research research)
        {
            try
            {
                research.IsPublish = true;
                db.Researches.Add(research);
                db.SaveChanges();

                return new Operation()
                {
                    Code = "200",
                    Message = "Ok",
                    ReferenceId = research.ResearchID
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

        public static Operation Update(Research newRecord)
        {
            try
            {
                Research oldRecord = db.Researches.FirstOrDefault(e => e.ResearchID == newRecord.ResearchID);

                if (oldRecord != null)
                {
                    oldRecord.Author = newRecord.Author;
                    oldRecord.Abstract = newRecord.Abstract;
                    oldRecord.Leadline = newRecord.Leadline;
                    oldRecord.Title = newRecord.Title;
                    oldRecord.Year = newRecord.Year;
                    oldRecord.IsPublish = true;

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

        public static Operation Delete(Guid? researchId)
        {
            try
            {
                Research oldRecord = db.Researches.FirstOrDefault(e => e.ResearchID == researchId);

                if (oldRecord != null)
                {
                    db.Researches.Remove(oldRecord);

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

        public static Research GetById(Guid? id)
        {
            return db.Researches.FirstOrDefault(e => e.ResearchID == id);
        }



        public static Operation Deactivate(Guid? researchId)
        {
            try
            {
                Research oldRecord = db.Researches.FirstOrDefault(r => r.ResearchID == researchId);

                if (oldRecord != null)
                {
              

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
