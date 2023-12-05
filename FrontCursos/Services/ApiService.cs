using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using FrontCursos.Models;

namespace FrontCursos.Services
{
    public class ApiService
    {
        private readonly HttpClient httpClient;

        public ApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Curso>> GetCursos()
        {
            var apiResponse = await httpClient.GetStringAsync("http://localhost:5051/api/Curso");
            var cursos = JsonSerializer.Deserialize<List<Curso>>(apiResponse);
            return cursos;
        }
    }
}
