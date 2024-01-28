using System;
using AutoMapper;
using System.Reflection;
using NuGet.Packaging.Licenses;
using System.ComponentModel;
using VetHos.DTOS.ControllerDtos.VetController;
using VetHos.Data.Tables;

namespace VetHos.MapperProfile
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
            LoadStandardMappings();
            LoadConverters();
        }

        private void LoadConverters()
        {
            CreateMap<VetControllerDTO, VetTable>();
        }

        private void LoadStandardMappings()
        {
            var mapsFrom = MapperProfileHelper.LoadStandardMappings(Assembly.GetExecutingAssembly());

            foreach (var map in mapsFrom)
            {
                CreateMap(map.Source, map.Destination).ReverseMap();
            }
        }
    }
}

