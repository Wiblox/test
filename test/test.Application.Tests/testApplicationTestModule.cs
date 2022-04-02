using Volo.Abp.Modularity;

namespace test;

[DependsOn(
    typeof(testApplicationModule),
    typeof(testDomainTestModule)
    )]
public class testApplicationTestModule : AbpModule
{

}
