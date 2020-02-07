using System;


namespace R5T.Cambridge.Types
{
    public class SolutionFileProjectFileReference
    {
        public Guid ProjectTypeGUID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectFilePathValue { get; set; }
        public Guid ProjectGUID { get; set; }
    }
}
