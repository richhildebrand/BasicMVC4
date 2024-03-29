﻿using System.Threading;
using System.Threading.Tasks;

namespace BasicMVC4.LanguageServices
{
    public interface ICodeEvaluator
    {
        Task<ICodeRunResult> EvaluateAsync(ICodeProgram program, CancellationToken cancellationToken);
    }
}
