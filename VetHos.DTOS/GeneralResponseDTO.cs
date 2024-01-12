using System;
namespace VetHos.DTOS
{
	public class GeneralResponseDTO
    {
		public object Data { get;  set; }
		public bool IsSuccessful { get; set; }
		public int StatusCode { get; set; }

    }
}

