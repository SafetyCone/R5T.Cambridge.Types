using System;


namespace R5T.Cambridge.Types
{
    public class ProjectNesting
    {
        public Guid ProjectGUID { get; set; }
        public Guid ParentProjectGUID { get; set; }


        public override string ToString()
        {
            var representation = $"{this.ProjectGUID.ToString("B").ToUpperInvariant()} = {this.ParentProjectGUID.ToString("B").ToUpperInvariant()}";
            return representation;
        }
    }
}
