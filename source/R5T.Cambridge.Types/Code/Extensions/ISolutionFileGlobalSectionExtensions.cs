using System;
using System.Collections.Generic;
using System.Linq;


namespace R5T.Cambridge.Types
{
    public static class ISolutionFileGlobalSectionExtensions
    {
        #region Common

        public static bool HasGlobalSectionByName<T>(this IEnumerable<ISolutionFileGlobalSection> globalSections, string globalSectionName, out T globalSection)
            where T : class, ISolutionFileGlobalSection
        {
            // Intermediate reference required.
            globalSection = globalSections.Where(x => x.Name == globalSectionName).ToList().SingleOrDefault() as T;

            var output = globalSection != default;
            return output;
        }

        public static bool HasGlobalSectionByName<T>(this IEnumerable<ISolutionFileGlobalSection> globalSections, string globalSectionName)
            where T : class, ISolutionFileGlobalSection
        {
            var output = globalSections.HasGlobalSectionByName<T>(globalSectionName, out var _);
            return output;
        }

        public static T GetGlobalSectionByName<T>(this IEnumerable<ISolutionFileGlobalSection> globalSections, string globalSectionName)
            where T : class, ISolutionFileGlobalSection
        {
            var hasGlobalSection = globalSections.HasGlobalSectionByName<T>(globalSectionName, out var globalSection);
            if (!hasGlobalSection)
            {
                throw new InvalidOperationException($"No '{globalSectionName}' global section found.");
            }

            return globalSection;
        }

        public static T AddGlobalSection<T>(this List<ISolutionFileGlobalSection> globalSections, Func<T> constructor)
            where T : ISolutionFileGlobalSection
        {
            var globalSection = constructor();

            globalSections.Add(globalSection);

            return globalSection;
        }

        public static T AcquireGlobalSectionByName<T>(this List<ISolutionFileGlobalSection> globalSections, string globalSectionName, Func<T> constructor)
            where T : class, ISolutionFileGlobalSection
        {
            var hasGlobalSection = globalSections.HasGlobalSectionByName<T>(globalSectionName, out var globalSection);
            if (!hasGlobalSection)
            {
                globalSection = globalSections.AddGlobalSection(constructor);
            }

            return globalSection;
        }

        #endregion

        #region Generic

        public static bool HasGenericGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections, string globalSectionName, out GenericSolutionFileGlobalSection globalSection)
        {
            var output = globalSections.HasGlobalSectionByName(globalSectionName, out globalSection);
            return output;
        }

        public static bool HasGenericGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections, string globalSectionName)
        {
            var output = globalSections.HasGlobalSectionByName<GenericSolutionFileGlobalSection>(globalSectionName);
            return output;
        }

        public static GenericSolutionFileGlobalSection GetGenericGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections, string globalSectionName)
        {
            var globalSection = globalSections.GetGlobalSectionByName<GenericSolutionFileGlobalSection>(globalSectionName);
            return globalSection;
        }

        public static GenericSolutionFileGlobalSection AddGenericGlobalSection(this List<ISolutionFileGlobalSection> globalSections, string globalSectionName, PreOrPostSolution preOrPostSolution)
        {
            var globalSection = globalSections.AddGlobalSection(() => GenericSolutionFileGlobalSection.New(globalSectionName, preOrPostSolution));
            return globalSection;
        }

        public static GenericSolutionFileGlobalSection AcquireGenericGlobalSection(this List<ISolutionFileGlobalSection> globalSections, string globalSectionName, PreOrPostSolution preOrPostSolution)
        {
            var globalSection = globalSections.AcquireGlobalSectionByName(globalSectionName, () => GenericSolutionFileGlobalSection.New(globalSectionName, preOrPostSolution));
            return globalSection;
        }

        #endregion

        #region Nested Projects

        public static bool HasNestedProjectsGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections, out NestedProjectsSolutionFileGlobalSection nestedProjectsSolutionFileGlobalSection)
        {
            var output = globalSections.HasGlobalSectionByName(NestedProjectsSolutionFileGlobalSection.GlobalSectionName, out nestedProjectsSolutionFileGlobalSection);
            return output;
        }

        public static bool HasNestedProjectsGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections)
        {
            var output = globalSections.HasGlobalSectionByName<NestedProjectsSolutionFileGlobalSection>(NestedProjectsSolutionFileGlobalSection.GlobalSectionName);
            return output;
        }

        public static NestedProjectsSolutionFileGlobalSection GetNestedProjectsGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections)
        {
            var nestedProjectsGlobalSection = globalSections.GetGlobalSectionByName<NestedProjectsSolutionFileGlobalSection>(NestedProjectsSolutionFileGlobalSection.GlobalSectionName);
            return nestedProjectsGlobalSection;
        }

        public static NestedProjectsSolutionFileGlobalSection AddNestedProjectsGlobalSection(this List<ISolutionFileGlobalSection> globalSections)
        {
            var nestedProjectsGlobalSection = globalSections.AddGlobalSection(NestedProjectsSolutionFileGlobalSection.New);
            return nestedProjectsGlobalSection;
        }

        public static NestedProjectsSolutionFileGlobalSection AcquireNestedProjectsGlobalSection(this List<ISolutionFileGlobalSection> globalSections)
        {
            var nestedProjectsGlobalSection = globalSections.AcquireGlobalSectionByName(NestedProjectsSolutionFileGlobalSection.GlobalSectionName, NestedProjectsSolutionFileGlobalSection.New);
            return nestedProjectsGlobalSection;
        }

        #endregion

        #region Project Configuration Platforms

        public static bool HasProjectConfigurationPlatformsGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections, out ProjectConfigurationPlatformsGlobalSection projectConfigurationPlatformsGlobalSection)
        {
            var output = globalSections.HasGlobalSectionByName(ProjectConfigurationPlatformsGlobalSection.GlobalSectionName, out projectConfigurationPlatformsGlobalSection);
            return output;
        }

        public static bool HasProjectConfigurationPlatformsGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections)
        {
            var output = globalSections.HasGlobalSectionByName<ProjectConfigurationPlatformsGlobalSection>(ProjectConfigurationPlatformsGlobalSection.GlobalSectionName);
            return output;
        }

        public static ProjectConfigurationPlatformsGlobalSection GetProjectConfigurationPlatformsGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections)
        {
            var projectConfigurationPlatformsGlobalSection = globalSections.GetGlobalSectionByName<ProjectConfigurationPlatformsGlobalSection>(ProjectConfigurationPlatformsGlobalSection.GlobalSectionName);
            return projectConfigurationPlatformsGlobalSection;
        }

        public static ProjectConfigurationPlatformsGlobalSection AddProjectConfigurationPlatformsGlobalSection(this List<ISolutionFileGlobalSection> globalSections)
        {
            var projectConfigurationPlatformsGlobalSection = globalSections.AddGlobalSection(ProjectConfigurationPlatformsGlobalSection.New);
            return projectConfigurationPlatformsGlobalSection;
        }

        public static ProjectConfigurationPlatformsGlobalSection AcquireProjectConfigurationPlatformsGlobalSection(this List<ISolutionFileGlobalSection> globalSections)
        {
            var projectConfigurationPlatformsGlobalSection = globalSections.AcquireGlobalSectionByName(ProjectConfigurationPlatformsGlobalSection.GlobalSectionName, ProjectConfigurationPlatformsGlobalSection.New);
            return projectConfigurationPlatformsGlobalSection;
        }

        #endregion

        #region Solution Configuration Platforms

        public static bool HasSolutionConfigurationPlatformsGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections, out SolutionConfigurationPlatformsGlobalSection solutionConfigurationPlatformsGlobalSection)
        {
            var output = globalSections.HasGlobalSectionByName(SolutionConfigurationPlatformsGlobalSection.GlobalSectionName, out solutionConfigurationPlatformsGlobalSection);
            return output;
        }

        public static bool HasSolutionConfigurationPlatformsGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections)
        {
            var output = globalSections.HasGlobalSectionByName<SolutionConfigurationPlatformsGlobalSection>(SolutionConfigurationPlatformsGlobalSection.GlobalSectionName);
            return output;
        }

        public static SolutionConfigurationPlatformsGlobalSection GetSolutionConfigurationPlatformsGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections)
        {
            var solutionConfigurationPlatformsGlobalSection = globalSections.GetGlobalSectionByName<SolutionConfigurationPlatformsGlobalSection>(SolutionConfigurationPlatformsGlobalSection.GlobalSectionName);
            return solutionConfigurationPlatformsGlobalSection;
        }

        public static SolutionConfigurationPlatformsGlobalSection AddSolutionConfigurationPlatformsGlobalSection(this List<ISolutionFileGlobalSection> globalSections)
        {
            var solutionConfigurationPlatformsGlobalSection = globalSections.AddGlobalSection(SolutionConfigurationPlatformsGlobalSection.New);
            return solutionConfigurationPlatformsGlobalSection;
        }

        public static SolutionConfigurationPlatformsGlobalSection AcquireSolutionConfigurationPlatformsGlobalSection(this List<ISolutionFileGlobalSection> globalSections)
        {
            var solutionConfigurationPlatformsGlobalSection = globalSections.AcquireGlobalSectionByName(SolutionConfigurationPlatformsGlobalSection.GlobalSectionName, SolutionConfigurationPlatformsGlobalSection.New);
            return solutionConfigurationPlatformsGlobalSection;
        }

        #endregion

        #region Solution Properties

        public static bool HasSolutionPropertiesGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections, out SolutionPropertiesGlobalSection solutionPropertiesGlobalSection)
        {
            var output = globalSections.HasGlobalSectionByName(SolutionPropertiesGlobalSection.GlobalSectionName, out solutionPropertiesGlobalSection);
            return output;
        }

        public static bool HasSolutionPropertiesGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections)
        {
            var output = globalSections.HasGlobalSectionByName<SolutionPropertiesGlobalSection>(SolutionPropertiesGlobalSection.GlobalSectionName);
            return output;
        }

        public static SolutionPropertiesGlobalSection GetSolutionPropertiesGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections)
        {
            var solutionPropertiesGlobalSection = globalSections.GetGlobalSectionByName<SolutionPropertiesGlobalSection>(SolutionPropertiesGlobalSection.GlobalSectionName);
            return solutionPropertiesGlobalSection;
        }

        public static SolutionPropertiesGlobalSection AddSolutionPropertiesGlobalSection(this List<ISolutionFileGlobalSection> globalSections)
        {
            var solutionPropertiesGlobalSection = globalSections.AddGlobalSection(SolutionPropertiesGlobalSection.New);
            return solutionPropertiesGlobalSection;
        }

        public static SolutionPropertiesGlobalSection AcquireSolutionPropertiesGlobalSection(this List<ISolutionFileGlobalSection> globalSections)
        {
            var solutionPropertiesGlobalSection = globalSections.AcquireGlobalSectionByName(SolutionPropertiesGlobalSection.GlobalSectionName, SolutionPropertiesGlobalSection.New);
            return solutionPropertiesGlobalSection;
        }

        #endregion

        #region Solution Properties

        public static bool HasExtensibilityGlobalsGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections, out ExtensibilityGlobalsGlobalSection extensibilityGlobalsGlobalSection)
        {
            var output = globalSections.HasGlobalSectionByName(ExtensibilityGlobalsGlobalSection.GlobalSectionName, out extensibilityGlobalsGlobalSection);
            return output;
        }

        public static bool HasExtensibilityGlobalsGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections)
        {
            var output = globalSections.HasGlobalSectionByName<ExtensibilityGlobalsGlobalSection>(ExtensibilityGlobalsGlobalSection.GlobalSectionName);
            return output;
        }

        public static ExtensibilityGlobalsGlobalSection GetExtensibilityGlobalsGlobalSection(this IEnumerable<ISolutionFileGlobalSection> globalSections)
        {
            var extensibilityGlobalsGlobalSection = globalSections.GetGlobalSectionByName<ExtensibilityGlobalsGlobalSection>(ExtensibilityGlobalsGlobalSection.GlobalSectionName);
            return extensibilityGlobalsGlobalSection;
        }

        public static ExtensibilityGlobalsGlobalSection AddExtensibilityGlobalsGlobalSection(this List<ISolutionFileGlobalSection> globalSections)
        {
            var extensibilityGlobalsGlobalSection = globalSections.AddGlobalSection(ExtensibilityGlobalsGlobalSection.New);
            return extensibilityGlobalsGlobalSection;
        }

        public static ExtensibilityGlobalsGlobalSection AcquireExtensibilityGlobalsGlobalSection(this List<ISolutionFileGlobalSection> globalSections)
        {
            var extensibilityGlobalsGlobalSection = globalSections.AcquireGlobalSectionByName(ExtensibilityGlobalsGlobalSection.GlobalSectionName, ExtensibilityGlobalsGlobalSection.New);
            return extensibilityGlobalsGlobalSection;
        }

        #endregion
    }
}
