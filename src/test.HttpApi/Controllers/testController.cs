using test.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace test.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class testController : AbpControllerBase
{
    protected testController()
    {
        LocalizationResource = typeof(testResource);
    }
}
