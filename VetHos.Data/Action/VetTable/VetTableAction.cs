using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VetHos.DTOS.ControllerDtos.VetController;

namespace VetHos.Data.Action.VetTable
{
	public class VetTableAction : IVetTableAction
	{
		private readonly MyDbContext _myDbContext;
		private readonly IMapper _mapper;

		public VetTableAction(MyDbContext myDbContext, IMapper mapper)
		{
			_myDbContext = myDbContext;
			_mapper = mapper;
		}

        public async Task<long> CreateData(VetControllerDTO request)
        {
			var entity = _mapper.Map<VetControllerDTO, Tables.VetTable>(request);
			await _myDbContext.Set<Tables.VetTable>().AddAsync(entity);
			await _myDbContext.SaveChangesAsync();
			return entity.Id;
            
        }
    }

}

