# MyFirstABP
第一个 ABP项目，利用abp实现了人员的查询和显示，并使用丝袜哥Swagger生成接口列表。

本代码为《基于DDD的ABP开发框架初探》（https://www.cnblogs.com/Leo_wl/p/5503992.html），其中存在一些问题而无法编译运行。本代码修正了其中的问题，并简单增加了扩展。
从http://www.aspnetboilerplate.com 下载模板后，建议使用vs2017进行nuget包还原和后续开发，使用其他vs版本可能存在这样那样的问题。


界面效果如下：

查看接口

用户数据如下：

姓名	       年龄

xmm  	       25

longhao 	   25

Jerry.Core	 25

Joye.NET	   25






对 原文的改进之处有四：

1、修改映射未初始化的错误- Mapper not initialized。

在ABP官网下载模板时，未勾选“Include module-zero”。在新增实体及相应业务逻辑后运行网站时，可能会出现” Mapper not initialized. Call Initialize with appropriate configuration…”。

【原因】Mapper not initialized 映射未初始化

【解决】在ApplicationModule类中增加依赖typeof(AbpAutoMapperModule)即可。

[DependsOn(typeof(DemoCoreModule), typeof(AbpAutoMapperModule))] 

2、完善FirstABP.Application.DTO 的GetAllPeopleOutput 和  PersonDto；

3、在前台中列表展示人员数据。

4、利用丝袜哥Swagger生成接口列表，nuget引用Swashbuckle，参考文章为http://www.cnblogs.com/wer-ltm/p/5776024.html#autoid-0-4-0，说明：

（1）、 EnableSwaggerUi中InjectJavaScript的是translator.js， 要将translator 属性设置为嵌入式资源，而不是swagger.js。设置swagger.js为嵌入式资源是无法显示中文的。

（2）、注释是加在服务层项目的接口类（如FirstABP.Application项目的IPersonService类）中的每个方法上；
