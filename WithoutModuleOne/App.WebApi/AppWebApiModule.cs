using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace App
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AppApplicationModule))]
    public class AppWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AppApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
