using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using blazorUas_72190277.Models;

namespace blazorUas_72190277.Services
{
    public class EnrollService : IEnrollService
    {
        private HttpClient _httpClient;

        public EnrollService(HttpClient httpClient){
            _httpClient = httpClient;    
        }

        public async Task<IEnumerable<Enroll>> GetById(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<Enroll>>($"/enrollment/{id}");
            return result;
        }
    }
}