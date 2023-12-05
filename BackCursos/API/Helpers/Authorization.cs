namespace API.Helpers;

public class Authorization
{
    public enum Roles
    {
        Administrator,
        Estudiante,
        Instructor

    }
    public const Roles role_default = Roles.Estudiante;
}