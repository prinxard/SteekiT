using SteekiT.DataAccess.Data;
using SteekiT.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteekiT.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Company = new CompanyRepository(_db);
            Product = new ProductRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);



            StoredProcedureCall = new StoredProcedureCall(_db);
        }
        public ICategoryRepository Category { get; private set; }

        public ICompanyRepository Company { get; private set; }

        public ICoverTypeRepository CoverType { get; private set; }

        public IApplicationUserRepository ApplicationUser { get; private set; }


        public IProductRepository Product { get; private set; }
        public InterfaceStoredProcedureCall StoredProcedureCall { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
