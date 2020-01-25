using System;
using System.Collections.Generic;


namespace R5T.Cambridge.Types
{
    public class NestedProjectsSolutionFileGlobalSection : SolutionFileGlobalSectionBase
    {
        public const string GlobalSectionName = "NestedProjects";


        #region Static

        /// <summary>
        /// Creates a new <see cref="NestedProjectsSolutionFileGlobalSection"/> with the <see cref="NestedProjectsSolutionFileGlobalSection.GlobalSectionName"/> and <see cref="PreOrPostSolution.PreSolution"/>.
        /// </summary>
        public static NestedProjectsSolutionFileGlobalSection New()
        {
            var output = new NestedProjectsSolutionFileGlobalSection
            {
                Name = NestedProjectsSolutionFileGlobalSection.GlobalSectionName,
                PreOrPostSolution = PreOrPostSolution.PreSolution,
            };
            return output;
        }

        #endregion


        public List<ProjectNesting> ProjectNestings { get; } = new List<ProjectNesting>();
    }
}
