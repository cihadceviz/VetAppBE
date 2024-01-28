using System;
namespace VetHos.Data.Tables
{
	public class VetTable
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public string? OwnerId { get; set; }
	}	
}

