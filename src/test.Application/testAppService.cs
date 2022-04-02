using test.Localization;
using Volo.Abp.Application.Services;

namespace test;

/* Inherit your application services from this class.
 */
public abstract class testAppService : ApplicationService
{
    protected testAppService()
    {
        LocalizationResource = typeof(testResource);
    }
}
