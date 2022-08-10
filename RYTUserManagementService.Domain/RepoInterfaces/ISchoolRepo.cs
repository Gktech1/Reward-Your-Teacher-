using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RYTUserManagementService.Models

namespace RYTUserManagementService.Domain.RepoInterfaces
{
    public interface ISchoolRepo
    {
        Task<School> GetSchool(int id);
        Task<School> Save(School input);
        Task<School> DeleteSchool(int id);
        Task<ICollection<School>> GetAll();
        Task<School> UpdateSchool(int id);
       
    }
}
