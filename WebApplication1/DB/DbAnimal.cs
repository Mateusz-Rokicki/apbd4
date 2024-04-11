using WebApplication1.Models;

namespace WebApplication1.DB;

public static class DbAnimal
{
    public static List<Animal> Animals = new()
    {
        new Animal{ Id = 1, Name = "Fafik", Category = "dog",Weight = 5,Color = "black"},
        new Animal { Id = 2, Name = "Luna", Category = "cat",Weight = 10, Color = "yellow"}
    };  
    


}