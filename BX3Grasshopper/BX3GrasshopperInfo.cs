using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace BX3Grasshopper
{
    public class BX3GrasshopperInfo : GH_AssemblyInfo
    {
        public override string Name => "Bombyx 3";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("242ab1b2-c723-416c-960f-1e5e693c7591");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";

        //Return a string representing the version.  This returns the same version as the assembly.
        public override string AssemblyVersion => GetType().Assembly.GetName().Version.ToString();
    }
}