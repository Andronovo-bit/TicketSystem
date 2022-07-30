using System.Xml.Serialization;

[XmlRoot(ElementName="IslemRezervasyon")]
public class IslemRezervasyonViewModel { 

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

	[XmlElement(ElementName="SeferNo")] 
	public int SeferNo { get; set; } 

	[XmlElement(ElementName="KalkisTerminalAdiSaatleri")] 
	public string KalkisTerminalAdiSaatleri { get; set; } 

	[XmlElement(ElementName="KoltukNo1")] 
	public int KoltukNo1 { get; set; } 

	[XmlElement(ElementName="Adi1")] 
	public string Adi1 { get; set; } 

	[XmlElement(ElementName="Soyadi1")] 
	public string Soyadi1 { get; set; } 

	[XmlElement(ElementName="TcKimlikNo1")] 
	public string TcKimlikNo1 { get; set; } 

	[XmlElement(ElementName="ServisYeriKalkis1")] 
	public string ServisYeriKalkis1 { get; set; } 

	[XmlElement(ElementName="TelefonNo")] 
	public string TelefonNo { get; set; } 

	[XmlElement(ElementName="Cinsiyet")] 
	public int Cinsiyet { get; set; } 

	[XmlElement(ElementName="YolcuSayisi")] 
	public int YolcuSayisi { get; set; } 

	[XmlElement(ElementName="FirmaAciklama")] 
	public string FirmaAciklama { get; set; } 

	[XmlElement(ElementName="HatirlaticiNot")] 
	public string HatirlaticiNot { get; set; } 

	[XmlElement(ElementName="WebYolcu")]
	public WebYolcu WebYolcu { get; set; }
}


public class WebYolcu { 

	[XmlElement(ElementName="WebUyeNo")] 
	public string WebUyeNo { get; set; } 

	[XmlElement(ElementName="Ip")] 
	public string Ip { get; set; } = "127.0.0.1";

	[XmlElement(ElementName="Email")] 
	public string Email { get; set; } 
}
