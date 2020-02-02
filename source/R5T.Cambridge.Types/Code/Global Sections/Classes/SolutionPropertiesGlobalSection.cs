using System;


namespace R5T.Cambridge.Types
{
    public class SolutionPropertiesGlobalSection : SolutionFileGlobalSectionBase
    {
        public const string GlobalSectionName = "SolutionProperties";


        #region Static

        /// <summary>
        /// Creates a new <see cref="SolutionPropertiesGlobalSection"/> with the <see cref="SolutionPropertiesGlobalSection.GlobalSectionName"/> and <see cref="PreOrPostSolution.PreSolution"/>.
        /// </summary>
        public static SolutionPropertiesGlobalSection New()
        {
            var output = new SolutionPropertiesGlobalSection
            {
                Name = SolutionPropertiesGlobalSection.GlobalSectionName,
                PreOrPostSolution = PreOrPostSolution.PreSolution,
            };
            return output;
        }

        #endregion


        public bool HideSolutionNode { get; set; }
    }
}
