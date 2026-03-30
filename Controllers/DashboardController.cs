using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using socialmediaapi.Model;
using socialmediaapi.Services;

namespace socialmediaapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly DashboardService _service;
        public DashboardController(DashboardService service)
        {
            _service = service;
        }

        [HttpGet("GetDashboard")]
        public async Task<ActionResult<DashboardModel>> GetDashboard()
        {   
            var dashboard = await _service.GetDashboard();
            return dashboard;
        }
    }
}