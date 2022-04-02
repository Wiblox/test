using System.Threading.Tasks;

namespace test.Data;

public interface ItestDbSchemaMigrator
{
    Task MigrateAsync();
}
