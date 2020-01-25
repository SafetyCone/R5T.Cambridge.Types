using System;


namespace R5T.Cambridge.Types
{
    public class ProjectBuildConfigurationMapping
    {
        public Guid ProjectGUID { get; set; }
        public BuildConfigurationPlatform SolutionBuildConfiguration { get; set; }
        public ProjectConfigurationIndicator ProjectConfigurationIndicator { get; set; }
        public BuildConfigurationPlatform MappedSolutionBuildConfiguration { get; set; }
    }
}
