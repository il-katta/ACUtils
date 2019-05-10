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
            var assembly = GetAssembly();
            var stream = assembly.GetManifestResourceStream(FormatResourceName(assembly, resourceName));
            return new StreamReader(stream).ReadToEnd();
        }

        private static string FormatResourceName(Assembly assembly, string resourceName)
        {
            resourceName = resourceName.Replace(" ", "_").Replace("\\", ".").Replace("/", ".");
            return $"{assembly.GetName().Name}.{resourceName}";
        }
    }
}