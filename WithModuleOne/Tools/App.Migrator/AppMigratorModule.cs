using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using App.EntityFramework;

namespace App.Migrator
{
    [DependsOn(typeof(AppDataModule))]
    public class AppMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AppDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}