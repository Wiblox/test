using test.Localization;
using Volo.Abp.AspNetCore.Components;

namespace test.Blazor;

public abstract class testComponentBase : AbpComponentBase
{
    protected testComponentBase()
    {
        LocalizationResource = typeof(testResource);
    }
}
