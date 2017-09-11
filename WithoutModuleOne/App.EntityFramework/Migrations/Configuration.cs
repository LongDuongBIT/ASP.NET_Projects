using System.Data.Entity.Migrations;

namespace App.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<App.EntityFramework.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "App";
        }

        protected override void Seed(App.EntityFramework.AppDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
