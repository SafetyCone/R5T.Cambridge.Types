using System;
using System.Collections.Generic;


namespace R5T.Cambridge.Types
{
    /// <summary>
    /// Defines a common abstraction for Visual Studio solution file global sections.
    /// </summary>
    public interface ISolutionFileGlobalSection
    {
        string Name { get; }
        PreOrPostSolution PreOrPostSolution { get; }
    }
}
