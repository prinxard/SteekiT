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
            StoredProcedureCall = new StoredProcedureCall(_db);
        }
        public ICategoryRepository Category { get; private set; }
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
