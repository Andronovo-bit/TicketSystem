

using TicketSystem.Models.Domain.Base;

public class Rezervation : BaseEntity<int>,IBaseEntity
{
    public string PnrNo { get; set; }
    public int FirmaNo { get; set; }
    public int KalkisNoktaID { get; set; }
    public int VarisNoktaID { get; set; }
    public string Guzergah { get; set; }
    public string KoltukNo { get; set; }
    public string Isim { get; set; }
    public string SoyIsim { get; set; }
    public string TcNo { get; set; }
    public int Cinsiyet { get; set; }

}