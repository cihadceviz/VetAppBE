using System;
using VetHos.Business.Services.VetName;

namespace VetHos.Business
{
	public static class ServiceCollectionExtensions
    {
		public static IServiceCollection AddVetHosBusinesServices(this IServiceCollection services)
		{
			services.AddScoped<IVetNameService, VetNameService>();
			return services;
		}
	}
}

