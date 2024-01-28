using System;
using Microsoft.EntityFrameworkCore;
using VetHos.Data;
using VetHos.Data.Action.VetTable;
using VetHos.DTOS;
using VetHos.DTOS.ControllerDtos.VetController;

namespace VetHos.Business.Services.VetService
{
	public class VetService : IVetService
	{
		private readonly MyDbContext _context;
        private readonly IVetTableAction _vetTableAction;

		public VetService(MyDbContext context, IVetTableAction vetTableAction)
		{
			_context = context;
            _vetTableAction = vetTableAction;
		}

        public async Task<GeneralResponseDTO> CreateAsync(VetControllerDTO request)
        {
            var dataId = await _vetTableAction.CreateData(request);
            var responseData = new
            {
                Id = dataId,
                request.Name,
                request.OwnerId
            };
            var response = new GeneralResponseDTO
            {
                Data = responseData,
                IsSuccessful = true,
                StatusCode = 200
            };
            return response;
        }

        public Task<GeneralResponseDTO> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<GeneralResponseDTO> GetAll()
		{
			var data = await _context.VetTable.ToListAsync();

			var response = new GeneralResponseDTO
			{
				Data = data,
				IsSuccessful = true,
				StatusCode = 200
			};
			return response;
        }

        public Task<GeneralResponseDTO> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralResponseDTO> UpdateAsync(VetControllerDTO request)
        {
            throw new NotImplementedException();
        }
    }
}

