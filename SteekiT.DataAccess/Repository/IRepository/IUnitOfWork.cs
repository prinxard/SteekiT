using System;
using System.Collections.Generic;
using System.Text;

namespace SteekiT.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        InterfaceStoredProcedureCall StoredProcedureCall { get; }
        void Save();
    }

}
