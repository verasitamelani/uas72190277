using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazorUas_72190277.Models;

namespace blazorUas_72190277.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAll();

        Task<Student> GetById(string id);

        Task <Student> Add(Student obj);

        Task<Student> Update(Student obj);

        Task Delete(string id);
    }
}