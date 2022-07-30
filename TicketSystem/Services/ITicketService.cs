using System.Threading.Tasks;
using TicketSystem.Manager;
using TicketSystem.Models;

namespace TicketSystem.Services
{
    public interface ITicketService
    {
        Task<NewDataSet> GetTicketsAsync(SeferViewModel seferViewModel);
        Task<LineDataSet> GetRouteByLineAsync(LineViewModel lineViewModel);
        Task<Otobus> GetBusDetailAsync(BusDetailViewModel busDetailViewModel);
        Task<IslemSonuc> BuyTicketAsync(IslemRezervasyonViewModel buyTicketViewModel);
        Task<KaraNoktalar> GetTransferPoint();
        Task<Bilet> QueryPNR(QueryPNRViewModel queryPNRViewModel);
    }
}