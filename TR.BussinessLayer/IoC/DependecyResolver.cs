using Autofac;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.BussinessLayer.Abstract;
using TR.BussinessLayer.AutoMapper;
using TR.BussinessLayer.Manager;
using TR.DataAccessLayer.Abstract;
using TR.DataAccessLayer.EntityFramework;

namespace TR.BussinessLayer.IoC
{
	public class DependecyResolver : Module
	{
		protected override void Load(ContainerBuilder builder)
		{

			// Repository
			builder.RegisterType<EFPhoneBookDal>().As<IPhoneBookDal>().InstancePerLifetimeScope();

			// Services
			builder.RegisterType<PhoneBookManager>().As<IPhoneBookService>().InstancePerLifetimeScope();

			// Other registrations...
			// AutoMapper (if needed)
			builder.Register(context => new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<Mapping>();
			})).AsSelf().SingleInstance();
			builder.Register(c =>
			{
				var context = c.Resolve<IComponentContext>();
				var config = context.Resolve<MapperConfiguration>();

				return config.CreateMapper(context.Resolve);
			}).As<IMapper>().InstancePerLifetimeScope();


			base.Load(builder);
		}
	}
}
