using System;
namespace VetHos.DTOS.ControllerDtos.VetController
{
	public class VetControllerDTO
    {
        public required string Name { get; set; }
        public string? OwnerId { get; set; }
    }
}

