using System.IO;
using Roslyn.Compilers.Common;

namespace BasicMVC4.Extensions
{
    internal static class CompilationExtensions
    {
        internal static CommonEmitResult Emit(this CommonCompilation compilation)
        {
            using (var stream = new MemoryStream())
            {
                return compilation.Emit(stream);
            }
        }
    }
}
