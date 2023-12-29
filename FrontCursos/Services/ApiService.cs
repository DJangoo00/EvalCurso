using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using FrontCursos.Models;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Net.Http.Json;

namespace FrontCursos.Services
{
    public class ApiService
    {
        private readonly HttpClient httpClient;

        public ApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        //metodos de peticiones http para funcionalidades

        //Cursos
        public async Task<List<Curso>> GetCursos()
        {
            try
            {
                var apiResponse = await httpClient.GetStringAsync("http://localhost:5051/api/Curso");
                var cursos = JsonSerializer.Deserialize<List<Curso>>(apiResponse);
                return cursos;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<bool> PostCurso(Curso data)
        {
            try
            {
                Console.WriteLine($"data:{data.nombre}");
                var response = await httpClient.PostAsJsonAsync("http://localhost:5051/api/Curso", data);
                Console.WriteLine("pruebaposterior post");
                return response.IsSuccessStatusCode;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        //Tomar Cursos

        //Calificar Cursos
        public async Task<bool> RateCurso(RateCurso data)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync("http://localhost:5051/api/", data);
                //en desarrollo
                return response.IsSuccessStatusCode;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        //USERS
        public async Task<bool> Register(RegUser data)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync("http://localhost:5051/api/User/register", data);
                return response.IsSuccessStatusCode;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<bool> LogIn(LogIn data)
        {
            //en desarrollo
            try
            {
                var response = await httpClient.PostAsJsonAsync("http://localhost:5051/api/User/token", data);
                return response.IsSuccessStatusCode;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
