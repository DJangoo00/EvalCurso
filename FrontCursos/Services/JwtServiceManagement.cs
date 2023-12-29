using FrontCursos.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FrontCursos.Services
{
    public class JwtManagementService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public JwtManagementService()
        {
            _httpContextAccessor = new HttpContextAccessor();
        }

        public TokenModel GetJwtToken()
        {
            TokenModel tokenModel = JsonConvert.DeserializeObject<TokenModel>(_httpContextAccessor.HttpContext?.Request.Cookies["jwtToken"]);
            return tokenModel;
        }

        public void SetJwtToken(TokenModel tokenModel)
        {
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(1), // Puedes ajustar la expiración
                HttpOnly = false, // Marcar la cookie como accesible solo por HTTP
                Secure = false, // Si tu aplicación usa HTTPS, establece esto en true
                SameSite = SameSiteMode.None // Controla la restricción de envío de cookies en solicitudes cross-site
            };
            if (_httpContextAccessor == null)
            {
            }
            _httpContextAccessor.HttpContext?.Response.Cookies.Append("jwtToken", JsonConvert.SerializeObject(tokenModel), cookieOptions);
        }

        public void RemoveJwtToken()
        {
            _httpContextAccessor.HttpContext?.Response.Cookies.Delete("jwtToken");
        }
    }
}
