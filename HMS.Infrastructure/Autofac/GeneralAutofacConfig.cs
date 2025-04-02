using Autofac;
using AutoMapper;
using HMS.Application.Common.Abstracts;
using HMS.Application.Common.Commands;
using HMS.Application.Common.Conctrete;
using HMS.Application.Common.Handlers.Commands;
using HMS.Application.Common.Handlers.Queries;
using HMS.Application.Common.Queries;
using HMS.Business.Concrete.ReservationOperations;
using HMS.Business.Concrete.SalesAndMarketingOperations;
using HMS.Business.Services.ReservationOperations;
using HMS.Business.Services.SalesAndMarketingOperations;
using HMS.Core.Abstracts;
using HMS.DataAccess;
using HMS.DataAccess.Common;
using HMS.DataAccess.Context;
using HMS.Infrastructure.AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure.Autofac
{
    public class GeneralAutofacConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile()); // YourProfile, AutoMapper profili
            });
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<HMSContext>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterInstance(mapperConfig.CreateMapper()).As<IMapper>().SingleInstance();


            builder.RegisterGeneric(typeof(GenericCQRS<,>)).As(typeof(IGenericCQRS<,>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType<ContractCQRS>().As<IContractMethods>().InstancePerLifetimeScope();
            builder.RegisterType<ReservationCQRS>().As<IReservationMethods>().InstancePerLifetimeScope();
            builder.RegisterType<ContractServices>().As<IContractServices>().InstancePerLifetimeScope();
            builder.RegisterType<ReservationServices>().As<IReservationServices>().InstancePerLifetimeScope();


            // MediatR için assembly kaydetme
            builder.RegisterAssemblyTypes(typeof(IMediator).Assembly)
                   .AsImplementedInterfaces();

            builder.RegisterGeneric(typeof(CreateCommandHandler<,>))
               .As(typeof(IRequestHandler<,>));

            builder.RegisterGeneric(typeof(CreateBaseCommandHandler<,,,>))
               .As(typeof(IRequestHandler<,>));

            builder.RegisterGeneric(typeof(DeleteCommandHandler<,>))
              .As(typeof(IRequestHandler<,>));

            builder.RegisterGeneric(typeof(DeleteBaseCommandHandler<,,,>))
              .As(typeof(IRequestHandler<,>));

            builder.RegisterGeneric(typeof(UpdateCommanHandler<,>))
              .As(typeof(IRequestHandler<,>));

            builder.RegisterGeneric(typeof(UpdateBaseCommandHandler<,,,>))
              .As(typeof(IRequestHandler<,>));

            builder.RegisterGeneric(typeof(GetByIdQueryHandler<,>))
             .As(typeof(IRequestHandler<,>));

            builder.RegisterGeneric(typeof(GetByIdBaseQueryHandler<,,,>))
                .As(typeof(IRequestHandler<,>));

            builder.RegisterGeneric(typeof(GetAllQueriesHandler<,>))
                .As(typeof(IRequestHandler<,>));

            builder.RegisterGeneric(typeof(GetAllBaseQueryHandler<,,,>))
                .As(typeof(IRequestHandler<,>));

            builder.RegisterAssemblyTypes(System.Reflection.Assembly.GetExecutingAssembly())
              .AsClosedTypesOf(typeof(IRequestHandler<,>)) // Tüm IRequestHandler'ları kapalı türler olarak kaydet
              .AsImplementedInterfaces();

            base.Load(builder);
        }
    }
}
