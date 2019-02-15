﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

using Five.Car.IRepository;
using Five.Car.Repository;
using Autofac.Integration.WebApi;
using System.Web.Http;
using Autofac.Integration.Mvc;
using Five.Car.Repository.EvaluateDetails;
using Five.Car.IRepository.IEvaluateDetails;
using Five.Car.IRepository.OrderDetails;

namespace Five.Api
{
    public static class AutofacConfig
    {
        /// <summary>
        /// 项目初始化，实例化IOC容器
        /// </summary>
        public static void Register()
        {
            var builder = new ContainerBuilder();
            SetupResolveRules(builder);

            //注册所有的ApiControllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            var container = builder.Build();

            //注册api容器需要使用HttpConfiguration对象
            HttpConfiguration config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        /// <summary>
        /// 将实现类与接口注入到IOC容器中
        /// </summary>
        /// <param name="builder"></param>
        public static void SetupResolveRules(ContainerBuilder container)
        {
            container.RegisterType<RotationChartRepository>().As<IRotationChartRepository>();
            container.RegisterType<CarBrand>().As<ICarBrand>();
            container.RegisterType<CarDetailsRepository>().As<ICarDetailsRepository>();
            container.RegisterType<CollectionRepository>().As<ICollectionRepository>();
            container.RegisterType<AddressDetailsRepository>().As<IAddressDetailsRepository>();
            container.RegisterType<EvaluateDetailsRepository>().As<IEvaluateDetailsRepository>();
            container.RegisterType<Collect>().As<ICollect>();
            container.RegisterType<UserInfo>().As<IUserInfo>();



        }
    }
}