using SampleArch.Model;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SampleArch.Test
{
    public class TestContext : DbContext
    {
        public TestContext()
            : base("Name=TestContext")
        {
        }

        public TestContext(bool enableLazyLoading, bool enableProxyCreation)
            : base("Name=TestContext")
        {
            Configuration.ProxyCreationEnabled = enableProxyCreation;
            Configuration.LazyLoadingEnabled = enableLazyLoading;
        }

        public TestContext(DbConnection connection)
            : base(connection, true)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Person> Persons { get; set; }

        public void Seed(TestContext Context)
        {
            var listCountry = new List<Country> {
             new Country { Id = 1, Name = "US" },
             new Country { Id = 2, Name = "India" },
             new Country { Id = 3, Name = "Russia" }
            };
            Context.Countries.AddRange(listCountry);
            Context.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Suppress code first model migration check
            Database.SetInitializer<TestContext>(new AlwaysCreateInitializer());

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public class AlwaysCreateInitializer : DropCreateDatabaseAlways<TestContext>
        {
            protected override void Seed(TestContext context)
            {
                context.Seed(context);
                base.Seed(context);
            }
        }

        public class CreateInitializer : CreateDatabaseIfNotExists<TestContext>
        {
            protected override void Seed(TestContext context)
            {
                context.Seed(context);
                base.Seed(context);
            }
        }

        public class DropCreateIfChangeInitializer : DropCreateDatabaseIfModelChanges<TestContext>
        {
            protected override void Seed(TestContext context)
            {
                context.Seed(context);
                base.Seed(context);
            }
        }
    }
}