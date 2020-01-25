using System;
using System.Collections.Generic;


namespace R5T.Cambridge.Types
{
    public class GenericSolutionFileGlobalSection : SolutionFileGlobalSectionBase
    {
        #region Static

        public static GenericSolutionFileGlobalSection New(string name, PreOrPostSolution preOrPostSolution)
        {
            var output = new GenericSolutionFileGlobalSection
            {
                Name = name,
                PreOrPostSolution = preOrPostSolution,
            };
            return output;
        }

        #endregion


        public List<string> ContentLines { get; } = new List<string>();
    }
}
