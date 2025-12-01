using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Contracts
{
    public interface IUnitOfWork
    {
        public IGenericRepository<TEnitiy,Tkey> GetRepository<TEnitiy,Tkey>()
                                                where TEnitiy : BaseEntity<Tkey>;
        Task<int> SavaChangesAsync();
    }
}
