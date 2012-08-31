using System;

namespace BasicMVC4
{
    public interface ICodeProgram
    {
        string Name { get; }

        string Language { get; }

        string Content { get; }

        string Classes { get; }

        TimeSpan TimeoutPeriod { get; }
    }
}