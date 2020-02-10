using System;


namespace R5T.Cambridge.Types
{
    public class ProjectNesting
    {
        public Guid ChildProjectGUID { get; set; }
        public Guid ParentProjectGUID { get; set; }


        public override string ToString()
        {
            var representation = $"{this.ChildProjectGUID.ToString("B").ToUpperInvariant()} = {this.ParentProjectGUID.ToString("B").ToUpperInvariant()}";
            return representation;
        }
    }
}
