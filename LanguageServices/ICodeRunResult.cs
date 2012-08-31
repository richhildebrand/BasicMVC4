using System;

namespace BasicMVC4
{
    public interface ICodeRunResult
    {
        DateTime StartTime { get; set; }

        DateTime StopTime { get; set; }

        TimeSpan RunDuration { get; set; }

        TimeSpan ProcessorTime { get; set; }

        long TotalMemoryAllocated { get; set; }

        string ConsoleOutput { get; set; }

        string Result { get; set; }
    }
}