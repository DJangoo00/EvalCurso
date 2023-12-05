using Domain.Entities;
namespace API.Dtos;
public class UserDto : BaseEntity
{
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Password { get; set; }    
}