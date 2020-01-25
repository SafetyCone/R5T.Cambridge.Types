using System;


namespace R5T.Cambridge.Types
{
    public abstract class SolutionFileGlobalSectionBase : ISolutionFileGlobalSection
    {
        public string Name { get; set; }
        public PreOrPostSolution PreOrPostSolution { get; set; }


        public override string ToString()
        {
            var representation = this.Name;
            return representation;
        }
    }
}
