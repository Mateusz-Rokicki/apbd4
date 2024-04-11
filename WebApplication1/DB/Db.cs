using WebApplication1.Models;

namespace WebApplication1.DB;

public static class Db
{
    public static List<Student> Students = new()
    {
        new Student { Id = 1, Name = "John", Email = "jonh@exmaple.com" },
        new Student { Id = 2, Name = "Jane", Email = "x" }
    };  
}