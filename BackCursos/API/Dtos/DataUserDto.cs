using System.Text.Json.Serialization;

namespace API.Dtos;
public class DataUserDto
{
    public int Id { get; set; }
    public string Message { get; set; }
    public bool IsAuthenticated { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public List<string> Roles { get; set; }
    public string Token { get; set; }

    [JsonIgnore] // ->this attribute restricts the property to be shown in the result
    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiration { get; set; }        
}