using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Swashbuckle.Application;

namespace FirstABP
{
    [DependsOn(typeof(AbpWebApiModule), typeof(FirstABPApplicationModule))]
    public class FirstABPWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(FirstABPApplicationModule).Assembly, "app")
                .Build();

            ConfigureSwaggerUi();
        }


        private void ConfigureSwaggerUi()
        {
            Configuration.Modules.AbpWebApi().HttpConfiguration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1.00", "FirstABP API文档");
                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

                    //将application层中的注释添加到SwaggerUI中
                    var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    var commentsFileName = @"bin\FirstABP.Application.xml";
                    var commentsFile = Path.Combine(baseDirectory, commentsFileName);
                    //将注释的XML文档添加到SwaggerUI中
                    c.IncludeXmlComments(commentsFile);


                    
                })
                .EnableSwaggerUi("apis/{*assetPath}", b =>
                {
                    //对js进行了拓展
                    b.InjectJavaScript(Assembly.GetExecutingAssembly(),
                        "FirstABP.SwaggerUi.scripts.translator.js");
                });
        }


        public override void PreInitialize()
        {
            ////关闭跨站脚本攻击
            Configuration.Modules.AbpWeb().AntiForgery.IsEnabled = false;
        }
    }
}
