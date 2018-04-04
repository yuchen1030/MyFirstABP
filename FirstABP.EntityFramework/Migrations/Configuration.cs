using FirstABP.People;
using System.Data.Entity.Migrations;

namespace FirstABP.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<FirstABP.EntityFramework.FirstABPDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FirstABP";
        }

        protected override void Seed(FirstABP.EntityFramework.FirstABPDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...

            context.Person.AddOrUpdate(p => p.Name,
                new Person { Name = "Joye.NET", Age = 25 },
                new Person { Name = "Jerry.Core", Age = 25 },
                new Person { Name = "longhao", Age = 25 },
                new Person { Name = "xmm", Age = 25 });

        }
    }
}
