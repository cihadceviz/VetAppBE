using System;
using VetHos.DTOS;
using VetHos.DTOS.ControllerDtos;

namespace VetHos.Business.Services.VetName
{
	public class VetNameService : IVetNameService
    {
        
        public VetNameService()
		{
		}
		public async Task<GeneralResponseDTO> GetVetName(TestHomeDTO request)
		{
            var response = new GeneralResponseDTO
            {
                Data = request,
                IsSuccessful = true,
                StatusCode = 200
            };
            return response;
		}
	}
}

