using System;


namespace R5T.Cambridge.Types
{
    public class SolutionFileGenerator
    {
        #region Static

        /// <summary>
        /// Creates the result of "dotnet new sln".
        /// </summary>
        public static SolutionFile NewVisualStudio2017()
        {
            var solutionFile = new SolutionFile
            {
                FormatVersion = Version.Parse("12.00"),
                VisualStudioMoniker = "# Visual Studio 15",
                VisualStudioVersion = Version.Parse("15.0.26124.0"),
                MinimumVisualStudioVersion = Version.Parse("15.0.26124.0"),
            };

            solutionFile.GlobalSections.AddGlobalSection(SolutionFileGenerator.CreateSolutionPropertiesGlobalSection);
            solutionFile.GlobalSections.AddGlobalSection(SolutionFileGenerator.CreateExtensibilityGlobals);

            return solutionFile;
        }

        public static SolutionConfigurationPlatformsGlobalSection CreateSolutionConfigurationPlatformsGlobalSection()
        {
            var solutionConfigurationPlatforms = SolutionConfigurationPlatformsGlobalSection.New();

            solutionConfigurationPlatforms.SolutionBuildConfigurationMappings.AddRange(new[]
            {
                new SolutionBuildConfigurationPlatform { Source = BuildConfigurationPlatform.DebugAnyCPU, Destination = BuildConfigurationPlatform.DebugAnyCPU },
                new SolutionBuildConfigurationPlatform { Source = BuildConfigurationPlatform.DebugX64, Destination = BuildConfigurationPlatform.DebugX64 },
                new SolutionBuildConfigurationPlatform { Source = BuildConfigurationPlatform.DebugX86, Destination = BuildConfigurationPlatform.DebugX86 },
                new SolutionBuildConfigurationPlatform { Source = BuildConfigurationPlatform.ReleaseAnyCPU, Destination = BuildConfigurationPlatform.ReleaseAnyCPU },
                new SolutionBuildConfigurationPlatform { Source = BuildConfigurationPlatform.ReleaseX64, Destination = BuildConfigurationPlatform.ReleaseX64 },
                new SolutionBuildConfigurationPlatform { Source = BuildConfigurationPlatform.ReleaseX86, Destination = BuildConfigurationPlatform.ReleaseX86 },
            });

            return solutionConfigurationPlatforms;
        }

        public static SolutionPropertiesGlobalSection CreateSolutionPropertiesGlobalSection()
        {
            var solutionProperties = new SolutionPropertiesGlobalSection
            {
                Name = SolutionPropertiesGlobalSection.GlobalSectionName,
                PreOrPostSolution = PreOrPostSolution.PreSolution,
            };

            solutionProperties.HideSolutionNode = false;

            return solutionProperties;
        }

        public static ExtensibilityGlobalsGlobalSection CreateExtensibilityGlobals()
        {
            var extensibilityGlobals = new ExtensibilityGlobalsGlobalSection
            {
                Name = ExtensibilityGlobalsGlobalSection.GlobalSectionName,
                PreOrPostSolution = PreOrPostSolution.PostSolution,
            };

            extensibilityGlobals.SolutionGuid = Guid.NewGuid();

            return extensibilityGlobals;
        }

        #endregion
    }
}
