using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VetHos.DTOS;
using VetHos.Business.Services.VetName;
using VetHos.DTOS.ControllerDtos;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VetHos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IVetNameService vetNameService;

        public HomeController(IVetNameService vetNameService)
        {
            this.vetNameService = vetNameService;
        }

        [AllowAnonymous]
        [HttpPost("test-home")]
        public async Task<GeneralResponseDTO> TestHome([FromBody] TestHomeDTO request)
        {
            System.Console.WriteLine(request.VetName);
            return await vetNameService.GetVetName(request);

        }
    }
}

