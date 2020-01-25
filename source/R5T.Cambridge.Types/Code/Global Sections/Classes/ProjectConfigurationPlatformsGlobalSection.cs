using System;
using System.Collections.Generic;


namespace R5T.Cambridge.Types
{
    public class ProjectConfigurationPlatformsGlobalSection : SolutionFileGlobalSectionBase
    {
        public const string GlobalSectionName = "ProjectConfigurationPlatforms";


        #region Static

        /// <summary>
        /// Creates a new <see cref="ProjectConfigurationPlatformsGlobalSection"/> with the <see cref="ProjectConfigurationPlatformsGlobalSection.GlobalSectionName"/> and <see cref="PreOrPostSolution.PostSolution"/>.
        /// </summary>
        public static ProjectConfigurationPlatformsGlobalSection New()
        {
            var output = new ProjectConfigurationPlatformsGlobalSection
            {
                Name = ProjectConfigurationPlatformsGlobalSection.GlobalSectionName,
                PreOrPostSolution = PreOrPostSolution.PostSolution,
            };
            return output;
        }

        #endregion


        public List<ProjectBuildConfigurationMapping> ProjectBuildConfigurationMappings { get; } = new List<ProjectBuildConfigurationMapping>();
    }
}
