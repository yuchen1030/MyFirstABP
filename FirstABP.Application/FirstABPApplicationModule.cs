using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace FirstABP
{
    [DependsOn(typeof(FirstABPCoreModule), typeof(AbpAutoMapperModule))]
    public class FirstABPApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
