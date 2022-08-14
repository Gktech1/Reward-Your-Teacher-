using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.Domain.RepoInterfaces
{
    public interface IUnitOfWork : IDisposable
    {
  
        IGenericRepository<Student> Students { get;}
        IGenericRepository<School> Schools { get;}
        IGenericRepository<Teacher> Teachers { get;}

        Task Save();
    }
}
