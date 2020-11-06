using SteekiT.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteekiT.DataAccess.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company company);
    }
}
