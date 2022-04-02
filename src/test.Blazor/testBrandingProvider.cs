using Volo.Abp.Ui.Branding;

namespace test.Blazor;

public class testBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "test";
}
