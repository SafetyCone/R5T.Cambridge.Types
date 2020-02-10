using System;


namespace R5T.Cambridge.Types
{
    public static class ProjectConfigurationPlatformsGlobalSectionExtensions
    {
        public static void AddProjectConfigurations(this ProjectConfigurationPlatformsGlobalSection projectConfigurationPlatforms, Guid projectGUID, SolutionConfigurationPlatformsGlobalSection solutionConfigurationPlatforms)
        {
            var indicators = new[]
            {
                ProjectConfigurationIndicator.ActiveCfg,
                ProjectConfigurationIndicator.Build0,
            };

            foreach (var solutionBuildConfigurationMapping in solutionConfigurationPlatforms.SolutionBuildConfigurationMappings)
            {
                var mappedSolutionBuildConfiguration = solutionBuildConfigurationMapping.Source.BuildConfiguration == BuildConfiguration.Debug
                    ? BuildConfigurationPlatform.DebugAnyCPU
                    : BuildConfigurationPlatform.ReleaseAnyCPU;

                foreach (var indicator in indicators)
                {
                    projectConfigurationPlatforms.ProjectBuildConfigurationMappings.Add(new ProjectBuildConfigurationMapping
                    {
                        ProjectGUID = projectGUID,
                        SolutionBuildConfiguration = solutionBuildConfigurationMapping.Source,
                        MappedSolutionBuildConfiguration = mappedSolutionBuildConfiguration,
                        ProjectConfigurationIndicator = indicator,
                    });
                }
            }
        }
    }
}
