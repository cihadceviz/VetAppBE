using System;
using VetHos.DTOS;
using VetHos.DTOS.ControllerDtos;
using VetHos.DTOS.ControllerDtos.VetController;

namespace VetHos.Business.Services.VetService
{
	public interface IVetService
	{
		Task<GeneralResponseDTO> GetAll();
		Task<GeneralResponseDTO> GetById(int Id);
        Task<GeneralResponseDTO> CreateAsync(VetControllerDTO request);
		Task<GeneralResponseDTO> UpdateAsync(VetControllerDTO request);
		Task<GeneralResponseDTO> DeleteAsync(int Id);
    }
}

