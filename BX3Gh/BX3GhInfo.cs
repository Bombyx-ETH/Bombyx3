using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace BX3Gh
{
    public class BX3GhInfo : GH_AssemblyInfo
    {
        public override string Name => "BX3Gh";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("3aae9556-9a3d-48ed-bf61-37f4934d805a");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";

        //Return a string representing the version.  This returns the same version as the assembly.
        public override string AssemblyVersion => GetType().Assembly.GetName().Version.ToString();
    }
}