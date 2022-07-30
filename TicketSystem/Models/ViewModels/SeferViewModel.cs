using System;
using System.Xml.Serialization;

namespace TicketSystem.Models
{
[XmlRoot(ElementName="Sefer")]
public class SeferViewModel { 

	[XmlElement(ElementName="FirmaNo")] 
	public int FirmaNo { get; set; } 

	[XmlElement(ElementName="KalkisNoktaID")] 
	public int KalkisNoktaID { get; set; } 

	[XmlElement(ElementName="VarisNoktaID")] 
	public int VarisNoktaID { get; set; } 

	[XmlElement(ElementName="Tarih")] 
	public string Tarih { get; set; } 

	[XmlElement(ElementName="AraNoktaGelsin")] 
	public int AraNoktaGelsin { get; set; } 

	[XmlElement(ElementName="IslemTipi")] 
	public int IslemTipi { get; set; } 

	[XmlElement(ElementName="YolcuSayisi")] 
	public int YolcuSayisi { get; set; } 

	[XmlElement(ElementName="Ip")] 
	public string Ip { get; set; } 
}
}
