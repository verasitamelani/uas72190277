using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazorUas_72190277.Models;

namespace blazorUas_72190277.Services
{
    public interface IEnrollService
    {
        Task<IEnumerable<Enroll>> GetById(string id);
    }
}