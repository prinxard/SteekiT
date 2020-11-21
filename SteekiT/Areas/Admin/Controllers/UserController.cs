using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using SteekiT.DataAccess.Data;
using SteekiT.DataAccess.Repository;
using SteekiT.DataAccess.Repository.IRepository;
using SteekiT.Models;
using Microsoft.EntityFrameworkCore;


namespace SteekiT.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        //using applicationdbcontext will change later to repository pattern
        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }


        #region API CALLs
        [HttpGet]
        public IActionResult GetAll()
        {
            var userList = _db.ApplicationUsers.Include(u => u.Company).ToList();
            var userRole = _db.UserRoles.ToList();
            var roles = _db.Roles.ToList();
            foreach (var user in userList)
            {
                var roleId = userRole.FirstOrDefault(u => u.UserId == user.Id).RoleId;
                user.Role = roles.FirstOrDefault(u => u.Id == roleId).Name;

                if (user.Company == null)
                {
                    user.Company = new Company()
                    {
                        Name = ""
                    };
                }
            }
                return Json(new { data = userList });
            }

            #endregion
        }
    }


