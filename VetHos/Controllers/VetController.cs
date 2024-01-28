using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VetHos.Business.Services.VetService;
using VetHos.DTOS.ControllerDtos.VetController;
using VetHos.DTOS;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VetHos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VetController : ControllerBase
    {
        private readonly IVetService _vetService;

        public VetController(IVetService vetService)
        {
            _vetService = vetService;
        }

        [AllowAnonymous]
        [HttpGet("get-all")]
        public async Task<GeneralResponseDTO> GetAll()
        {
            return await _vetService.GetAll();
        }

        [AllowAnonymous]
        [HttpPost("create-vet")]
        public async Task<GeneralResponseDTO> CreateAsync([FromBody] VetControllerDTO request)
        {
            return await _vetService.CreateAsync(request);
        }

    }
}

