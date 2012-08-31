using System;
using System.Linq;
using BasicMVC4.Models;

namespace BasicMVC4.LanguageServices
{
    public interface ICodeExecutor : IDisposable
    {
        ExecutionResult Execute(ICodeAssembly assembly, TimeSpan timeout);
    }
}
