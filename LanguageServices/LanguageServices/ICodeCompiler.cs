using BasicMVC4.Models;
using Roslyn.Compilers.CSharp;

namespace BasicMVC4.LanguageServices
{
    public interface ICodeCompiler
    {
        ICodeAssembly Compile(ICodeProgram job);
    }
}