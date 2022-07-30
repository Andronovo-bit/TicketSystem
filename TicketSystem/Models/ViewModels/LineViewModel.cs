using System;
using System.Xml.Serialization;

namespace TicketSystem.Models
{

    [XmlRoot(ElementName = "Hat")]
    public class LineViewModel
    {

        [XmlElement(ElementName = "FirmaNo")]
        public int FirmaNo { get; set; }

        [XmlElement(ElementName = "HatNo")]
        public int HatNo { get; set; }

        [XmlElement(ElementName = "KalkisNoktaID")]
        public int KalkisNoktaID { get; set; }

        [XmlElement(ElementName = "VarisNoktaID")]
        public int VarisNoktaID { get; set; }

        [XmlElement(ElementName = "BilgiIslemAdi")]
        public string BilgiIslemAdi { get; set; }

        [XmlElement(ElementName = "SeferTakipNo")]
        public int SeferTakipNo { get; set; }

        [XmlElement(ElementName = "Tarih")]
        public string Tarih { get; set; }
    }

}