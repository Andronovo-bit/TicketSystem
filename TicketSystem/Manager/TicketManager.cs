using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TicketSystem.Helper;
using TicketSystem.Models;
using TicketSystem.TicketWebService;

namespace TicketSystem.Manager
{
    public class TicketManager : ITicketManager
    {

        private readonly TicketWebService.ServiceSoapClient _ticketService;
        private readonly AppSettingsViewModel _appSettings;
        private readonly Kullanici kullanici = new Kullanici();

        public TicketManager(AppSettingsViewModel appSettings)
        {
            _ticketService = new TicketWebService.ServiceSoapClient(TicketWebService.ServiceSoapClient.EndpointConfiguration.ServiceSoap12);
            _appSettings = appSettings;
            kullanici.Adi = appSettings.TicketWebServiceKullaniciAdi;
            kullanici.Sifre = appSettings.TicketWebServiceSifre;
        }


        public async Task<KaraNoktalar> GetTransferPoint()
        {

            var xmlIsletRequestBody = new TicketWebService.XmlIsletRequestBody();

            xmlIsletRequestBody.xmlYetki = TicketSystemHelper.SerializeToXmlElement(kullanici);
            xmlIsletRequestBody.xmlIslem = TicketSystemHelper.SerializeToXmlElement(new KaraNoktaGetirKomut());

            var xmlStringRemoveTags = await CallWebService(xmlIsletRequestBody);

            var result = TicketSystemHelper.Deserialize<KaraNoktalar>(xmlStringRemoveTags);

            return result;

        }

        public async Task<NewDataSet> GetTicket(SeferViewModel seferModel)
        {

            var xmlIsletRequestBody = new TicketWebService.XmlIsletRequestBody();

            xmlIsletRequestBody.xmlYetki = TicketSystemHelper.SerializeToXmlElement(kullanici);
            xmlIsletRequestBody.xmlIslem = TicketSystemHelper.SerializeToXmlElement(seferModel);

            var xmlStringRemoveTags = await CallWebService(xmlIsletRequestBody);

            var result = TicketSystemHelper.Deserialize<NewDataSet>(xmlStringRemoveTags);

            return result;

        }

        public async Task<LineDataSet> GetRouteByLine(LineViewModel lineViewModel)
        {

            var xmlIsletRequestBody = new TicketWebService.XmlIsletRequestBody();

            xmlIsletRequestBody.xmlYetki = TicketSystemHelper.SerializeToXmlElement(kullanici);
            xmlIsletRequestBody.xmlIslem = TicketSystemHelper.SerializeToXmlElement(lineViewModel);

            var xmlStringRemoveTags = await CallWebService(xmlIsletRequestBody);

            var result = TicketSystemHelper.Deserialize<LineDataSet>(xmlStringRemoveTags);

            return result;

        }

        public async Task<Otobus> GetBusDetail(BusDetailViewModel busDetailViewModel)
        {

            var xmlIsletRequestBody = new TicketWebService.XmlIsletRequestBody();

            xmlIsletRequestBody.xmlYetki = TicketSystemHelper.SerializeToXmlElement(kullanici);
            xmlIsletRequestBody.xmlIslem = TicketSystemHelper.SerializeToXmlElement(busDetailViewModel);

            var xmlStringRemoveTags = await CallWebService(xmlIsletRequestBody);

            var result = TicketSystemHelper.Deserialize<Otobus>(xmlStringRemoveTags);

            return result;

        }

        public async Task<IslemSonuc> CreateRezervation(IslemRezervasyonViewModel islemRezervasyonViewModel)
        {

            var xmlIsletRequestBody = new TicketWebService.XmlIsletRequestBody();

            xmlIsletRequestBody.xmlYetki = TicketSystemHelper.SerializeToXmlElement(kullanici);
            xmlIsletRequestBody.xmlIslem = TicketSystemHelper.SerializeToXmlElement(islemRezervasyonViewModel);

            var xmlStringRemoveTags = await CallWebService(xmlIsletRequestBody);

            var result = TicketSystemHelper.Deserialize<IslemSonuc>(xmlStringRemoveTags);

            return result;

        }

        public async Task<Bilet> QueryPNR(QueryPNRViewModel queryPNRViewModel)
        {

            var xmlIsletRequestBody = new TicketWebService.XmlIsletRequestBody();

            xmlIsletRequestBody.xmlYetki = TicketSystemHelper.SerializeToXmlElement(kullanici);
            xmlIsletRequestBody.xmlIslem = TicketSystemHelper.SerializeToXmlElement(queryPNRViewModel);

            var xmlStringRemoveTags = await CallWebService(xmlIsletRequestBody);

            var result = TicketSystemHelper.Deserialize<Bilet>(xmlStringRemoveTags);

            return result;

        }

        private async Task<string> CallWebService(XmlIsletRequestBody xmlIsletRequestBody)
        {
            var xmlIsletResponse = await _ticketService.XmlIsletAsync(xmlIsletRequestBody.xmlIslem, xmlIsletRequestBody.xmlYetki);

            var xmlIsletResponseBody = xmlIsletResponse.Body;

            var xmlStringRemoveTags = xmlIsletResponseBody.XmlIsletResult.OuterXml.Replace("xmlns=\"\"", "");

            return xmlStringRemoveTags;
    }


    }




}


