using System;
using VetHos.DTOS;
using VetHos.DTOS.ControllerDtos;

namespace VetHos.Business.Services.VetName
{
	public interface IVetNameService
	{
		Task<GeneralResponseDTO> GetVetName(TestHomeDTO request);
	}
}

