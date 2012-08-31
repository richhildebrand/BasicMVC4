using Autofac;
using Autofac.Integration.Mvc;
using BasicMVC4;

namespace BasicMVC4.Infrastructure.DependencyInjection
{
    public class MvcModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           var assembly = typeof(MvcApplication).Assembly;
            builder.RegisterControllers(assembly);
            builder.RegisterModelBinders(assembly);
            builder.RegisterModelBinderProvider();
            builder.RegisterModule(new AutofacWebTypesModule());
            builder.RegisterFilterProvider();
        }
    }
}