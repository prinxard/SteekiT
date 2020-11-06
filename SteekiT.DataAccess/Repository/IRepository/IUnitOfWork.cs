using System;
using System.Collections.Generic;
using System.Text;

namespace SteekiT.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        ICompanyRepository Company { get; }

        ICoverTypeRepository CoverType { get; }
        IProductRepository Product { get; }

        InterfaceStoredProcedureCall StoredProcedureCall { get; }
        void Save();
    }

}
