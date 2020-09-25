using SteekiT.DataAccess.Data;
using SteekiT.DataAccess.Repository.IRepository;
using SteekiT.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteekiT.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
