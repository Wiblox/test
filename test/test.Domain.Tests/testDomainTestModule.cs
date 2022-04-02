using test.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace test;

[DependsOn(
    typeof(testEntityFrameworkCoreTestModule)
    )]
public class testDomainTestModule : AbpModule
{

}
