using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem.Manager
{
    public interface ITicketManager
    {

        Task<KaraNoktalar> GetTransferPoint();
        Task<NewDataSet> GetTicket(SeferViewModel seferModel);
        Task<LineDataSet> GetRouteByLine(LineViewModel lineViewModel);
        Task<Otobus> GetBusDetail(BusDetailViewModel busDetailViewModel);
        Task<IslemSonuc> CreateRezervation(IslemRezervasyonViewModel islemRezervasyonViewModel);
        Task<Bilet> QueryPNR(QueryPNRViewModel queryPNRViewModel);        
    }
}