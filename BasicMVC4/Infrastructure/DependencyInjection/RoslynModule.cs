using Autofac;
using BasicMVC4.LanguageServices;

namespace BasicMVC4.Infrastructure.DependencyInjection
{
    public class RoslynModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CSharpCompiler>().As<ICodeCompiler>();
            builder.RegisterType<CSharpValidator>().As<ICodeValidator>();
        }
    }
}