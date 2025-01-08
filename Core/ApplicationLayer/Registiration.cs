using ApplicationLayer.Bases;
using ApplicationLayer.Exceptions;
using ApplicationLayer.Features.Products.Rules;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public static class Registiration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddTransient<ExceptionMiddleware>();
            services.AddRulesFromAssemblyContaining(assembly, typeof(BaseRules));

            services.AddMediatR(con => con.RegisterServicesFromAssembly(assembly));
        }

        private static IServiceCollection AddRulesFromAssemblyContaining(this IServiceCollection services,
            Assembly assembly,Type type)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (var item in types) 
                services.AddTransient(item);

            return services;
        }
    }
}
