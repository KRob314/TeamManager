namespace TeamManager.Data
{
    public class SeedData
    {
        public static void SeedDatabase(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            //context.Database.Migrate();

            if (!context.Ballparks.Any())
            {
                context.Ballparks.Add(new Models.Ballpark()
                {
                    Name = "Washington High School",
                    Street = "123 Washington Lane",
                    City = "Washington",
                    State = "MO",
                    Zip = "63031"
                });

                context.Ballparks.Add(new Models.Ballpark()
                {
                    Name = "Pacific High School",
                    Street = "123 Pacific Lane",
                    City = "Pacific",
                    State = "MO",
                    Zip = "63031"
                });

                context.Ballparks.Add(new Models.Ballpark()
                {
                    Name = "Union High School",
                    Street = "123 Union Lane",
                    City = "Union",
                    State = "MO",
                    Zip = "63031"
                });

                context.Ballparks.Add(new Models.Ballpark()
                {
                    Name = "Fenton High School",
                    Street = "123 Fenton Lane",
                    City = "Fenton",
                    State = "MO",
                    Zip = "63031"
                });

                context.SaveChanges();
            }
        }
    }
}
