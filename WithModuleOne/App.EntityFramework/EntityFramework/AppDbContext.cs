using System.Data.Common;
using Abp.Zero.EntityFramework;
using App.Authorization.Roles;
using App.Authorization.Users;
using App.MultiTenancy;

namespace App.EntityFramework
{
    public class AppDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AppDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AppDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AppDbContext since ABP automatically handles it.
         */
        public AppDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AppDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public AppDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
