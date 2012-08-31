using System.Collections.Generic;
using BasicMVC4.Models;

namespace BasicMVC4.LanguageServices
{
    public interface ICodeValidator
    {
        IEnumerable<EditorError> GetCompilationErrors(ICodeProgram program);
    }
}