using System;
using VetHos.DTOS.ControllerDtos.VetController;

namespace VetHos.Data.Action.VetTable
{
	public interface IVetTableAction
	{
		Task<long> CreateData(VetControllerDTO request);
	}
}

