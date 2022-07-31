using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using TicketSystem.Manager;
using TicketSystem.Models;

namespace TicketSystem.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketManager _ticketManager;
        private readonly IMemoryCache _memoryCache;

        private readonly IRepository<Rezervation> _rezervationRepository;

        private readonly AppSettingsViewModel _appSettings;

        public TicketService(ITicketManager ticketManager, IMemoryCache memoryCache, AppSettingsViewModel appSettings, IRepository<Rezervation> rezervationRepository)
        {
            _ticketManager = ticketManager;
            _memoryCache = memoryCache;
            _appSettings = appSettings;
            _rezervationRepository = rezervationRepository;
    }

        public async Task<NewDataSet> GetTicketsAsync(SeferViewModel seferViewModel)
        {
            return await _ticketManager.GetTicket(seferViewModel);
        }
        
        public async Task<LineDataSet> GetRouteByLineAsync(LineViewModel lineViewModel)
        {
            return await _ticketManager.GetRouteByLine(lineViewModel);
        }

        public async Task<Otobus> GetBusDetailAsync(BusDetailViewModel busDetailViewModel)
        {
            var cacheName = $"busDetail_{busDetailViewModel.FirmaNo}_{busDetailViewModel.SeferTakipNo}_{busDetailViewModel.KalkisNoktaID}";
            var bus =  await _memoryCache.GetOrCreateAsync(cacheName, async entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromHours(1);
                return  await _ticketManager.GetBusDetail(busDetailViewModel);
            });
            return bus;
        }

        public async Task<IslemSonuc> BuyTicketAsync(IslemRezervasyonViewModel buyTicketViewModel)
        {
            var resultRezervation =  await _ticketManager.CreateRezervation(buyTicketViewModel);

            if(!resultRezervation.Sonuc) throw new Exception(resultRezervation.Mesaj);

            var rezarvation = new Rezervation{
                InsertDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                FirmaNo = buyTicketViewModel.FirmaNo,
                VarisNoktaID = buyTicketViewModel.VarisNoktaID,
                KalkisNoktaID = buyTicketViewModel.KalkisNoktaID,
                Active = true,
                TcNo = buyTicketViewModel.TcKimlikNo1,
                PnrNo = resultRezervation.PNR,
                Isim = buyTicketViewModel.Adi1,
                SoyIsim = buyTicketViewModel.Soyadi1

            };

            _rezervationRepository.Insert(rezarvation);

            return resultRezervation;
        }

        public async Task<KaraNoktalar> GetTransferPoint()
        {

            var points =  await _memoryCache.GetOrCreateAsync("points", async entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromHours(_appSettings.TicketWebServiceCacheTime);
                return await  _ticketManager.GetTransferPoint();
            });
            return points;
        }

        public async Task<Bilet> QueryPNR(QueryPNRViewModel queryPNRViewModel)
        {
            return await _ticketManager.QueryPNR(queryPNRViewModel);
        }

    }
}