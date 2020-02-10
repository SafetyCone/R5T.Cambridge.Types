using System;
using System.Collections.Generic;


namespace R5T.Cambridge.Types
{
    public class NestedProjectsGlobalSection : SolutionFileGlobalSectionBase
    {
        public const string GlobalSectionName = "NestedProjects";


        #region Static

        /// <summary>
        /// Creates a new <see cref="NestedProjectsGlobalSection"/> with the <see cref="NestedProjectsGlobalSection.GlobalSectionName"/> and <see cref="PreOrPostSolution.PreSolution"/>.
        /// </summary>
        public static NestedProjectsGlobalSection New()
        {
            var output = new NestedProjectsGlobalSection
            {
                Name = NestedProjectsGlobalSection.GlobalSectionName,
                PreOrPostSolution = PreOrPostSolution.PreSolution,
            };
            return output;
        }

        #endregion


        public List<ProjectNesting> ProjectNestings { get; } = new List<ProjectNesting>();
    }
}
