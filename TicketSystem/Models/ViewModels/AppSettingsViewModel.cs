namespace TicketSystem.Models
{
    public class AppSettingsViewModel { 

        public string TicketWebServiceKullaniciAdi { get; set; }
        public string TicketWebServiceSifre { get; set; }
        public int TicketWebServiceCacheTime { get; set; } = 24;
    }
}