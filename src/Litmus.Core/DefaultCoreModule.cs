using Autofac;
using Litmus.Core.Interfaces;
using Litmus.Core.Services;

namespace Litmus.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}
