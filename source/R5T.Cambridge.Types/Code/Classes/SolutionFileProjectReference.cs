using System;


namespace R5T.Cambridge.Types
{
    /// <summary>
    /// A project reference in a solution file.
    /// </summary>
    /// <remarks>
    /// Example:
    /// Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "R5T.Private.SimpleConsoleAndLib", "R5T.Private.SimpleConsoleAndLib\R5T.Private.SimpleConsoleAndLib.csproj", "{9DAD5F24-3C22-47C9-8D69-3C7D72C62DAD}"
    /// EndProject
    /// </remarks>
    public class SolutionFileProjectReference
    {
        #region Static

        public static SolutionFileProjectReference New(string projectName, string projectFileRelativePathValue, Guid projectTypeGUID)
        {
            var solutionFileProjectReference = new SolutionFileProjectReference
            {
                ProjectGUID = Guid.NewGuid(),
                ProjectName = projectName,
                ProjectFileRelativePathValue = projectFileRelativePathValue,
                ProjectTypeGUID = projectTypeGUID,
            };
            return solutionFileProjectReference;
        }

        //public static SolutionFileProjectReference NewNetCoreOrStandardFromProjectFileRelativePath(string projectName, string projectFileRelativePathValue)
        //{
        //    var solutionFileProjectReference = SolutionFileProjectReference.New(projectName, projectFileRelativePathValue, Constants.NetStandardLibraryProjectTypeGUID);
        //    return solutionFileProjectReference;
        //}

        #endregion


        public Guid ProjectTypeGUID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectFileRelativePathValue { get; set; }
        public Guid ProjectGUID { get; set; }
    }
}
