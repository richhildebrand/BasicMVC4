namespace BasicMVC4
{
    public interface ICodeAssembly
    {
        string EntryPointClassName { get; set; }

        string EntryPointMethodName { get; set; }

        byte[] CompiledAssembly { get; set; }
    }
}