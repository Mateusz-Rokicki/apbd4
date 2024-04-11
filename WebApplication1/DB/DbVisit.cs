using WebApplication1.Models;

namespace WebApplication1.DB;

    public static class DbVisit
    {
        public static List<Visit> Visits = new()
        {
            new Visit()
            {
                Amount = 200, AnimalId = 1, Date = "2009", Description = "aaaaaaaaaaaaaaa"
            },
            new Visit()
            {
            Amount = 300, AnimalId = 2, Date = "2010", Description = "bbbbbbbbbb"
        }
        };
    }
