using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AbpCoreStudy.Localization
{
    public static class AbpCoreStudyLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AbpCoreStudyConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpCoreStudyLocalizationConfigurer).GetAssembly(),
                        "AbpCoreStudy.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
