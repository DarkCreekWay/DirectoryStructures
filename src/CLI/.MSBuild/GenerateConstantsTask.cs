using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace MyTasks {
    public class GenerateConstantsTask
    : Task {

        [Required] public string IntermediateOutputPath { get; set; }
        [Required] public string Namespace { get; set; }

        public string ClassName { get; set; } = "Constants";
        public string PropertyPrefix { get; set; } = "s_";

        public ITaskItem CompanyIdentifier { get; set; }
        public ITaskItem ProductIdentifier { get; set; }
        public ITaskItem Copyright { get; set; }

        public ITaskItem GitHubUrl { get;set; }

        public ITaskItem ProductAssemblyVersion { get; set; }
        public ITaskItem ProductInformationalVersion { get; set; }

        public override bool Execute() {

            string filename = Path.Combine( IntermediateOutputPath, $"{ClassName}.generated.cs" );
            File.Delete( filename );

            StringBuilder sb = new StringBuilder( 1024 );

            sb.Append( "using System;\r\n" );
            sb.Append( $"namespace {Namespace} {{\r\n" );
            sb.Append( $"    public static partial class {ClassName} {{\r\n" );

            // Append constants
            if(null != CompanyIdentifier)  
                sb.Append( $"        public const string {PropertyPrefix}CompanyIdentifier = \"{CompanyIdentifier}\";\r\n" );
            if(null != ProductIdentifier)  
                sb.Append( $"        public const string {PropertyPrefix}ProductIdentifier = \"{ProductIdentifier}\";\r\n" );
            if(null != ProductAssemblyVersion)  
                sb.Append( $"        public const string {PropertyPrefix}ProductAssemblyVersion = \"{ProductAssemblyVersion}\";\r\n" );
            if(null != ProductInformationalVersion)  
                sb.Append( $"        public const string {PropertyPrefix}ProductInformationalVersion = \"{ProductInformationalVersion}\";\r\n" );
            if(null != Copyright)          
                sb.Append( $"        public const string {PropertyPrefix}Copyright = \"Copyright {Copyright}\";\r\n" );

            if(null != GitHubUrl)          
                sb.Append( $"        public const string {PropertyPrefix}GitHubUrl = \"{GitHubUrl}\";\r\n" );

            sb.Append( $"    }}\r\n" );
            sb.Append( $"}}\r\n" );

            File.WriteAllText( filename, sb.ToString() );

            return true;
        }
    }
}