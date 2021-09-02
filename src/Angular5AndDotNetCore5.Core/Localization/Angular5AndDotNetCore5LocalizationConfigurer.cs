using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Angular5AndDotNetCore5.Localization
{
    public static class Angular5AndDotNetCore5LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Angular5AndDotNetCore5Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Angular5AndDotNetCore5LocalizationConfigurer).GetAssembly(),
                        "Angular5AndDotNetCore5.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
