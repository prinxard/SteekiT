﻿using SteekiT.DataAccess.Data;
using SteekiT.DataAccess.Repository.IRepository;
using SteekiT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteekiT.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company company)
        {
            _db.Update(company);
            
        }
    }
}
