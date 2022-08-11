using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Web;
using RYTUserManagementService.Domain.TypeRepository;
using RYTUserManagementService.Domain.RepoInterfaces;

namespace RYTUserManagementService.Domain.RepoImplementations
{
    public class UnitOfWork : IUnitOfWork     /*<T> : IDisposable where T : class*/
    {
        private readonly UserManagementDbContext context;


        public UnitOfWork(UserManagementDbContext context)
        {
            this.context = context;
            Student = new StudentRepository(this.context);
            Teacher = new TeacherRepository(this.context);
            School = new SchoolRepository(this.context);
        }
        public IStudentRepository Student
        {
            get;
            private set;
        }
        public ITeacherRepository Teacher
        {
            get;
            private set;
        }
        public ISchoolRepository School
        {
            get;
            private set;
        }


        public void Dispose()
        {
            context.Dispose();
        }
        public int Save()
        {
            return context.SaveChanges();
        }




        //private readonly GeneralRepository<T> generalRepository;
        //public GeneralRepository<T> GeneralRepository
        //{
        //    get
        //    {
        //        return this.generalRepository ?? new GeneralRepository<T>(context);
        //    }
        //}
        //public void Save()
        //{
        //    context.SaveChanges();
        //}
        //private bool disposed = false;
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            context.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}
