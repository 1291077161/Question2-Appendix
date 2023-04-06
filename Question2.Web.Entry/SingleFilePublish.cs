using Furion;
using System.Reflection;

namespace Question2.Web.Entry
{
    public class SingleFilePublish : ISingleFilePublish
    {
        public Assembly[] IncludeAssemblies()
        {
            return Array.Empty<Assembly>();
        }

        public string[] IncludeAssemblyNames()
        {
            return new[]
            {
            "Question2.Application",
            "Question2.Core",
            "Question2.EntityFramework.Core",
            "Question2.Web.Core"
        };
        }
    }
}