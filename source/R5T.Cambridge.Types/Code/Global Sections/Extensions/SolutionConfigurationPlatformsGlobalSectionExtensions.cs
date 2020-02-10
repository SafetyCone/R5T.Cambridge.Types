using System;


namespace R5T.Cambridge.Types
{
    public static class SolutionConfigurationPlatformsGlobalSectionExtensions
    {
        public static void AddDefaultSolutionBuildConfigurationPlatforms(this SolutionConfigurationPlatformsGlobalSection solutionConfigurationPlatformsGlobalSection)
        {
            solutionConfigurationPlatformsGlobalSection.SolutionBuildConfigurationMappings.AddRange(new[]
            {
                new SolutionBuildConfigurationPlatform { Source = BuildConfigurationPlatform.DebugAnyCPU, Destination = BuildConfigurationPlatform.DebugAnyCPU },
                new SolutionBuildConfigurationPlatform { Source = BuildConfigurationPlatform.DebugX64, Destination = BuildConfigurationPlatform.DebugX64 },
                new SolutionBuildConfigurationPlatform { Source = BuildConfigurationPlatform.DebugX86, Destination = BuildConfigurationPlatform.DebugX86 },
                new SolutionBuildConfigurationPlatform { Source = BuildConfigurationPlatform.ReleaseAnyCPU, Destination = BuildConfigurationPlatform.ReleaseAnyCPU },
                new SolutionBuildConfigurationPlatform { Source = BuildConfigurationPlatform.ReleaseX64, Destination = BuildConfigurationPlatform.ReleaseX64 },
                new SolutionBuildConfigurationPlatform { Source = BuildConfigurationPlatform.ReleaseX86, Destination = BuildConfigurationPlatform.ReleaseX86 },
            });
        }
    }
}
