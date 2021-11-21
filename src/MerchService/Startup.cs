using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using MerchadiseSevice.Application.Common.Behaviors;
using MerchandiseService.Infrastructure.Behaviors;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MerchService
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
    .AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
            services.AddTransient(typeof(IPipelineBehavior<,>),
                typeof(ValidationBehavior<,>));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
        
        }
    }
}