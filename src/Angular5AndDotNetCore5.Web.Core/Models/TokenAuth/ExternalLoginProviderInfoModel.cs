using Abp.AutoMapper;
using Angular5AndDotNetCore5.Authentication.External;

namespace Angular5AndDotNetCore5.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
