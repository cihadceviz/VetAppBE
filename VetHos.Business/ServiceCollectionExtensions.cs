using System;
using VetHos.Business.Services.VetName;
using VetHos.Business.Services.VetService;

namespace VetHos.Business
{
	public static class ServiceCollectionExtensions
    {
		public static IServiceCollection AddVetHosBusinesServices(this IServiceCollection services)
		{
			services.AddScoped<IVetNameService, VetNameService>();
			services.AddScoped<IVetService, VetService>();
            return services;
		}
	}
}

