using System.Reflection;
using Abp.Modules;

namespace App
{
    public class AppCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
