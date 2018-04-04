using System.Reflection;
using Abp.Modules;

namespace FirstABP
{
    public class FirstABPCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
