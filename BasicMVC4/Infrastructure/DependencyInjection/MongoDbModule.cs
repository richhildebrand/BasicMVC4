﻿using System.Configuration;
using Autofac;
using Autofac.Integration.Mvc;
using BasicMVC4.DataAccess.MongoDB;
using BasicMVC4.Models;

namespace BasicMVC4.Infrastructure.DependencyInjection
{
    public class MongoDbModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var connectionString = ConfigurationManager.AppSettings["MONGOLAB_URI"];

            builder.Register(c => new MongoConnectionFactory(connectionString))
                   .As<IMongoConnectionFactory>()
                   .SingleInstance();

            builder.RegisterType<MongoDbPostRepository>()
                   .As<IPostRepository>()
                   .InstancePerHttpRequest();
        }
    }
}