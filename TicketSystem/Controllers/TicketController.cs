using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TicketSystem.Models;
using TicketSystem.Services;

namespace TicketSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {

        
        private readonly ILogger<TicketController> _logger;
        private readonly ITicketService _ticketService;

        public TicketController(ILogger<TicketController> logger, ITicketService ticketService)
        {
            _logger = logger;
            _ticketService = ticketService;
        }

        [HttpPost]
        public async Task<IActionResult> GetTicket([FromBody] SeferViewModel seferViewModel)
        {
            var tickets = await _ticketService.GetTicketsAsync(seferViewModel);
            return Ok(tickets);
        }

        [HttpPost("GetRouteByLine")]
        public async Task<IActionResult> GetRouteByLine([FromBody] LineViewModel lineViewModel)
        {
            var lines = await _ticketService.GetRouteByLineAsync(lineViewModel);
            return Ok(lines);
        }

        [HttpPost("GetBusDetail")]
        public async Task<IActionResult> GetBusDetail([FromBody] BusDetailViewModel busDetailViewModel)
        {
            var bus = await _ticketService.GetBusDetailAsync(busDetailViewModel);
            return Ok(bus);
        }

        [HttpPost("BuyTicket")]
        public async Task<IActionResult> BuyTicket([FromBody] IslemRezervasyonViewModel buyTicketViewModel)
        {
            var ticket = await _ticketService.BuyTicketAsync(buyTicketViewModel);
            return Ok(ticket);
        }
        [HttpGet("GetTransferPoint")]
        public async Task<IActionResult> GetTransferPoint()
        {
            var points = await _ticketService.GetTransferPoint();
            return Ok(points);
        }

        [HttpPost("QueryPNR")]
        public async Task<IActionResult> QueryPNR([FromBody] QueryPNRViewModel queryPNRViewModel)
        {
            var pnr = await _ticketService.QueryPNR(queryPNRViewModel);
            return Ok(pnr);
        }

    }
}