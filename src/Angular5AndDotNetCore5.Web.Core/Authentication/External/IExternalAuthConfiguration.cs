using System.Collections.Generic;

namespace Angular5AndDotNetCore5.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
