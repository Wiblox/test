using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace test.Data;

/* This is used if database provider does't define
 * ItestDbSchemaMigrator implementation.
 */
public class NulltestDbSchemaMigrator : ItestDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
