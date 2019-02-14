using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;

namespace ACUtils
{
    public static class DotNetUtils
    {
        public static Assembly GetAssembly()
        {
            return Assembly.GetCallingAssembly();
        }

        public static List<string> GetEmbeddedResourcesNames()
        {
            return Assembly.GetCallingAssembly().GetManifestResourceNames().ToList();
        }


        public static string GetEmbeddedResource(string resourceName)
        {
            var stream = Assembly.GetCallingAssembly().GetManifestResourceStream(resourceName);
            return new StreamReader(stream).ReadToEnd();
        }
    }
}