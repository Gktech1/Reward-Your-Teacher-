using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace RYTUserManagementService.Domain.RepoImplementations
{
    public class UnitOfWork<T> : IDisposable
    {
        private readonly UserManagementDbContext context = UserManagementDbContext.
        private readonly GeneralRepository<T> generalRepository;
        public GeneralRepository<T> GeneralRepository
        {
            get
            {
                return this.GeneralRepository ?? new GeneralRepository<T>(context);
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
