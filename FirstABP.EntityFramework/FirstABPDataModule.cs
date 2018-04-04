using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using FirstABP.EntityFramework;

namespace FirstABP
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(FirstABPCoreModule))]
    public class FirstABPDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<FirstABPDbContext>(null);
        }
    }
}
