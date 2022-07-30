
using System.Xml.Serialization;
namespace TicketSystem.Models;

[XmlRoot(ElementName="PnrIslem")]
public class QueryPNRViewModel { 

	[XmlElement(ElementName="PnrNo")] 
	public string PnrNo { get; set; } 

	[XmlElement(ElementName="PnrIslemTip")] 
	public int PnrIslemTip { get; set; } 

	[XmlElement(ElementName="PnrAramaParametre")] 
	public string PnrAramaParametre { get; set; } 
}
