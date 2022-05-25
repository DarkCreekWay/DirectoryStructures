using System.Reflection;
using System.Runtime.Loader;

namespace DarkCreekWay.DirectoryStructures.CLI {

    public class ResourceAssemblResolver
    {
        const string s_SatelliteSuffix = ".resources";
        const string s_ResourceDirectoryParameterName = "I18n.Directory";

        string _i18nDir;

        public ResourceAssemblResolver()
        {
            _i18nDir = AppContext.GetData( s_ResourceDirectoryParameterName ) as string ?? "L10n";
            AssemblyLoadContext.Default.Resolving += Default_Resolving;
        }

        Assembly? Default_Resolving(AssemblyLoadContext context, AssemblyName assemblyName)
        {
            // Caller requested a language specific resource (satellite) assembly.
            // The following custom logic searches for the requested logic within a specific (fixed) sub-directory
            // relative to the location of the main assembly.
            //
            // Be aware, that no specific logic for case sensitive FileSystems (eg. on Linux) is part of the code.
            // For some more inspiration, check the implementation of Method ResolveSatelliteAssembly in the official dot.net source repo
            // https://source.dot.net/System.Private.CoreLib/AssemblyLoadContext.cs.html#cc6b76f71a1f5af5

            if (assemblyName.CultureName?.Length == 0) { 
                return null; 
            }

            if (assemblyName.Name == null || !assemblyName.Name.EndsWith(s_SatelliteSuffix, StringComparison.Ordinal)) {
                return null;
            }

            // Search relative to parent assembly
            //string parentAssemblyName = assemblyName.Name.Substring(0, assemblyName.Name.Length - s_SatelliteSuffix.Length);
            //Assembly parentAssembly = context.LoadFromAssemblyName(new AssemblyName(parentAssemblyName));
            //string path = Path.Combine(Path.GetDirectoryName(parentAssembly.Location), i18nDir, assemblyName.CultureName!, $"{assemblyName.Name}.dll");

            string path = Path.Combine(AppContext.BaseDirectory, _i18nDir, assemblyName.CultureName!, $"{assemblyName.Name}.dll");

            return File.Exists(path) ? context.LoadFromAssemblyPath(path) : null;

        }
    }
}
