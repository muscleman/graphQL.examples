using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using graphQL.examples.Repository;

namespace graphQL.examples.IOC
{
    public class GraphQLInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            try
            {
                container.Register(Component.For<IContext>()
                       .ImplementedBy<MyContext>()
                       .DependsOn(Dependency
                       .OnValue("connectionString", ""))
                       .LifestyleTransient());

                container.Register(Component.For<IGraphQLService>()
                    .ImplementedBy<GraphQLService>()
                    .LifestyleTransient());
            }
            catch (Exception)
            {

                throw;
            }


            //container.Register(Classes.FromThisAssembly()
            //    .BasedOn<IContext>()
            //    .LifestyleTransient());

            //container.Register(Classes.FromThisAssembly()
            //    .BasedOn<IGraphQLService>()
            //    .LifestyleTransient());
        }
    }
}