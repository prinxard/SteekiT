using SteekiT.DataAccess.Data;
using SteekiT.DataAccess.Repository.IRepository;
using SteekiT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteekiT.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

       
    }
}
