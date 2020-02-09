using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.sqlRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.IOC
{
   public class DependencyContainer
    {

        public static void RegisterServices(IServiceCollection services)
        {
            #region App_layer
            RegisterApplicationLayer(services);
            #endregion


            #region DataLayer
            RegisterDataLayer(services);
            #endregion
        }

        private static void RegisterDataLayer(IServiceCollection services)
        {
            services.AddScoped<ICourseRepository, CourseRepositories>();
        }

        private static void RegisterApplicationLayer(IServiceCollection services)
        {
            services.AddScoped<ICoursesService, CourseService>();
        }
    }
}
