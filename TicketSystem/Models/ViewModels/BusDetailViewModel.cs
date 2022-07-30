using System.Xml.Serialization;

[XmlRoot(ElementName="Otobus")]
public class BusDetailViewModel { 

	[XmlElement(ElementName="FirmaNo")] 
	public int FirmaNo { get; set; } 

	[XmlElement(ElementName="KalkisNoktaID")] 
	public int KalkisNoktaID { get; set; } 

	[XmlElement(ElementName="VarisNoktaID")] 
	public int VarisNoktaID { get; set; } 

	[XmlElement(ElementName="Tarih")] 
	public string Tarih { get; set; } 

	[XmlElement(ElementName="Saat")] 
	public string Saat { get; set; } 

	[XmlElement(ElementName="HatNo")] 
	public int HatNo { get; set; } 

	[XmlElement(ElementName="IslemTipi")] 
	public int IslemTipi { get; set; } 

	[XmlElement(ElementName="SeferTakipNo")] 
	public int SeferTakipNo { get; set; } 

	[XmlElement(ElementName="Ip")] 
	public string Ip { get; set; } 
}

