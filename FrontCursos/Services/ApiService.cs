using System.Net.Http;
using System.Threading.Tasks;

namespace FrontCursos.Services
{
    public class ApiService
    {
        private readonly HttpClient httpClient;

        public ApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> GetCursos()
        {
            // Endpoint para cursos
            var apiResponse = await httpClient.GetStringAsync("http://localhost:5051/api/Curso");
            return apiResponse;
        }

    }
}
