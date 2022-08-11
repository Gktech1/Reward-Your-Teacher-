using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYTUserManagementService.Domain.RepoInterfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ISchoolRepository School { get; }
        ITeacherRepository Teacher { get; }
        IStudentRepository Student { get; }

        int Save();
    }
}
