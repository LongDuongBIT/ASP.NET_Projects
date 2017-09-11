using System.Reflection;
using Abp.Modules;

namespace App
{
    [DependsOn(typeof(AppCoreModule))]
    public class AppApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
