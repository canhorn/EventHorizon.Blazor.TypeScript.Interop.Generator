using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHorizon.Blazor.TypeScript.Interop.Tool.Model
{
    class ProgramArguments
    {
        public string ProjectAssembly { get; set; }
        public string ProjectGenerationLocation { get; set; }
        public string SourceDirectory { get; set; }
        public string[] SourceFiles { get; set; }
        public string[] GenerationList { get; set; }
    }
}
