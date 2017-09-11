using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using App.EntityFramework;

namespace App
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(AppCoreModule))]
    public class AppDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<AppDbContext>(null);
        }
    }
}
