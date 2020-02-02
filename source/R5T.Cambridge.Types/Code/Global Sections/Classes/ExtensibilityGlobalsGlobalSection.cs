using System;


namespace R5T.Cambridge.Types
{
    public class ExtensibilityGlobalsGlobalSection : SolutionFileGlobalSectionBase
    {
        public const string GlobalSectionName = "ExtensibilityGlobals";

        #region Static

        /// <summary>
        /// Creates a new <see cref="ExtensibilityGlobalsGlobalSection"/> with the <see cref="ExtensibilityGlobalsGlobalSection.GlobalSectionName"/> and <see cref="PreOrPostSolution.PostSolution"/>.
        /// </summary>
        public static ExtensibilityGlobalsGlobalSection New()
        {
            var output = new ExtensibilityGlobalsGlobalSection
            {
                Name = ExtensibilityGlobalsGlobalSection.GlobalSectionName,
                PreOrPostSolution = PreOrPostSolution.PostSolution,
            };
            return output;
        }

        #endregion


        public Guid SolutionGuid { get; set; }
    }
}
