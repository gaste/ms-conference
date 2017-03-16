namespace Conference.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Conference.Data.DbContext.Concrete.ConferenceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Conference.Data.DbContext.Concrete.ConferenceDbContext context)
        {
            context.Locations.AddOrUpdate(
                new Entities.Location(
                    Guid.NewGuid(),
                    "Walter-Gropius-Straße",
                    "5",
                    "80807",
                    "München",
                    "Deutschland",
                    48.177645m,
                    11.593448m,
                    "Orion",
                    5,
                    25.12m,
                    12,
                    1024.12m,
                    5.10m)
                );
        }
    }
}
