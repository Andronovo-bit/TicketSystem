using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot(ElementName = "Kullanici")]
    public class Kullanici
    {

        [XmlElement(ElementName = "Adi")]
        public string Adi { get; set; }

        [XmlElement(ElementName = "Sifre")]
        public string Sifre { get; set; }
    }

    [XmlRoot(ElementName = "KaraNoktaGetirKomut")]
    public class KaraNoktaGetirKomut
    {
    }

    [XmlRoot(ElementName = "KaraNokta")]
    public class KaraNokta
    {

        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "SeyahatSehirID")]
        public int SeyahatSehirID { get; set; }

        [XmlElement(ElementName = "Bolge")]
        public string Bolge { get; set; }

        [XmlElement(ElementName = "Ad")]
        public string Ad { get; set; }

        [XmlElement(ElementName = "Aciklama")]
        public string Aciklama { get; set; }

        [XmlElement(ElementName = "MerkezMi")]
        public int MerkezMi { get; set; }

        [XmlElement(ElementName = "BagliOlduguNoktaID")]
        public int BagliOlduguNoktaID { get; set; }
    }

    [XmlRoot(ElementName = "KaraNoktalar")]
    public class KaraNoktalar
    {

        [XmlElement(ElementName = "KaraNokta")]
        public List<KaraNokta> KaraNokta { get; set; }
    }


    [XmlRoot(ElementName = "Table")]
    public class Table
    {

        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Vakit")]
        public string Vakit { get; set; }

        [XmlElement(ElementName = "FirmaNo")]
        public int FirmaNo { get; set; }

        [XmlElement(ElementName = "FirmaAdi")]
        public string FirmaAdi { get; set; }

        [XmlElement(ElementName = "YerelSaat")]
        public DateTime YerelSaat { get; set; }

        [XmlElement(ElementName = "YerelInternetSaat")]
        public DateTime YerelInternetSaat { get; set; }

        [XmlElement(ElementName = "Tarih")]
        public DateTime Tarih { get; set; }

        [XmlElement(ElementName = "GunBitimi")]
        public int GunBitimi { get; set; }

        [XmlElement(ElementName = "Saat")]
        public string Saat { get; set; }

        [XmlElement(ElementName = "HatNo")]
        public int HatNo { get; set; }

        [XmlElement(ElementName = "IlkKalkisYeri")]
        public string IlkKalkisYeri { get; set; }

        [XmlElement(ElementName = "SonVarisYeri")]
        public string SonVarisYeri { get; set; }

        [XmlElement(ElementName = "KalkisYeri")]
        public string KalkisYeri { get; set; }

        [XmlElement(ElementName = "VarisYeri")]
        public string VarisYeri { get; set; }

        [XmlElement(ElementName = "IlkKalkisNoktaID")]
        public int IlkKalkisNoktaID { get; set; }

        [XmlElement(ElementName = "IlkKalkisNokta")]
        public string IlkKalkisNokta { get; set; }

        [XmlElement(ElementName = "KalkisNoktaID")]
        public int KalkisNoktaID { get; set; }

        [XmlElement(ElementName = "KalkisNokta")]
        public string KalkisNokta { get; set; }

        [XmlElement(ElementName = "VarisNoktaID")]
        public int VarisNoktaID { get; set; }

        [XmlElement(ElementName = "VarisNokta")]
        public string VarisNokta { get; set; }

        [XmlElement(ElementName = "SonVarisNoktaID")]
        public int SonVarisNoktaID { get; set; }

        [XmlElement(ElementName = "SonVarisNokta")]
        public string SonVarisNokta { get; set; }

        [XmlElement(ElementName = "OtobusTipi")]
        public string OtobusTipi { get; set; }

        [XmlElement(ElementName = "OtobusKoltukYerlesimTipi")]
        public string OtobusKoltukYerlesimTipi { get; set; }

        [XmlElement(ElementName = "OTipAciklamasi")]
        public string OTipAciklamasi { get; set; }

        [XmlElement(ElementName = "OtobusTelefonu")]
        public string OtobusTelefonu { get; set; }

        [XmlElement(ElementName = "OtobusPlaka")]
        public string OtobusPlaka { get; set; }

        [XmlElement(ElementName = "SeyahatSuresi")]
        public string SeyahatSuresi { get; set; }

        [XmlElement(ElementName = "SeyahatSuresiGosterimTipi")]
        public int SeyahatSuresiGosterimTipi { get; set; }

        [XmlElement(ElementName = "YaklasikSeyahatSuresi")]
        public string YaklasikSeyahatSuresi { get; set; }

        [XmlElement(ElementName = "BiletFiyati1")]
        public int BiletFiyati1 { get; set; }

        [XmlElement(ElementName = "BiletFiyatiInternet")]
        public int BiletFiyatiInternet { get; set; }

        [XmlElement(ElementName = "Sinif_Farki")]
        public int SinifFarki { get; set; }

        [XmlElement(ElementName = "MaxRzvZamani")]
        public int MaxRzvZamani { get; set; }

        [XmlElement(ElementName = "SeferTipi")]
        public string SeferTipi { get; set; }

        [XmlElement(ElementName = "SeferTipiAciklamasi")]
        public string SeferTipiAciklamasi { get; set; }

        [XmlElement(ElementName = "HatSeferNo")]
        public string HatSeferNo { get; set; }

        [XmlElement(ElementName = "O_Tip_Sinif")]
        public int OTipSinif { get; set; }

        [XmlElement(ElementName = "SeferTakipNo")]
        public int SeferTakipNo { get; set; }

        [XmlElement(ElementName = "ToplamSatisAdedi")]
        public int ToplamSatisAdedi { get; set; }

        [XmlElement(ElementName = "DolulukKuraliVar")]
        public int DolulukKuraliVar { get; set; }

        [XmlElement(ElementName = "OTipOzellik")]
        public string OTipOzellik { get; set; }

        [XmlElement(ElementName = "NormalBiletFiyati")]
        public int NormalBiletFiyati { get; set; }

        [XmlElement(ElementName = "DoluSeferMi")]
        public int DoluSeferMi { get; set; }

        [XmlElement(ElementName = "Tesisler")]
        public string Tesisler { get; set; }

        [XmlElement(ElementName = "SeferBosKoltukSayisi")]
        public int SeferBosKoltukSayisi { get; set; }

        [XmlElement(ElementName = "KalkisTerminalAdi")]
        public string KalkisTerminalAdi { get; set; }

        [XmlElement(ElementName = "KalkisTerminalAdiSaatleri")]
        public string KalkisTerminalAdiSaatleri { get; set; }

        [XmlElement(ElementName = "MaximumRezerveTarihiSaati")]
        public DateTime MaximumRezerveTarihiSaati { get; set; }

        [XmlElement(ElementName = "Guzergah")]
        public string Guzergah { get; set; }

        [XmlElement(ElementName = "KKZorunluMu")]
        public bool KKZorunluMu { get; set; }

        [XmlElement(ElementName = "BiletIptalAktifMi")]
        public int BiletIptalAktifMi { get; set; }

        [XmlElement(ElementName = "AcikParaKullanimAktifMi")]
        public int AcikParaKullanimAktifMi { get; set; }

        [XmlElement(ElementName = "SefereKadarIptalEdilebilmeSuresiDakika")]
        public int SefereKadarIptalEdilebilmeSuresiDakika { get; set; }

        [XmlElement(ElementName = "FirmaSeferAciklamasi")]
        public string FirmaSeferAciklamasi { get; set; }

        [XmlElement(ElementName = "SatisYonlendirilecekMi")]
        public string SatisYonlendirilecekMi { get; set; }
    }

    [XmlRoot(ElementName = "OTipOzellik")]
    public class OTipOzellik
    {

        [XmlElement(ElementName = "O_Tip_Ozellik")]
        public int OTipOzellikId { get; set; }

        [XmlElement(ElementName = "O_Tip_Ozellik_Aciklama")]
        public string OTipOzellikAciklama { get; set; }

        [XmlElement(ElementName = "O_Tip_Ozellik_Detay")]
        public string OTipOzellikDetay { get; set; }

        [XmlElement(ElementName = "O_Tip_Ozellik_Icon")]
        public string OTipOzellikIcon { get; set; }
    }

    [XmlRoot(ElementName = "NewDataSet")]
    public class NewDataSet
    {

        [XmlElement(ElementName = "Table")]
        public List<Table> Table { get; set; }

        [XmlElement(ElementName = "OTipOzellik")]
        public List<OTipOzellik> OTipOzellik { get; set; }
    }


    [XmlRoot(ElementName = "Table1")]
    public class LineDetail
    {

        [XmlElement(ElementName = "VarisYeri")]
        public string VarisYeri { get; set; }

        [XmlElement(ElementName = "SiraNo")]
        public int SiraNo { get; set; }

        [XmlElement(ElementName = "KalkisTarihSaat")]
        public DateTime KalkisTarihSaat { get; set; }

        [XmlElement(ElementName = "VarisTarihSaat")]
        public DateTime VarisTarihSaat { get; set; }

        [XmlElement(ElementName = "KaraNoktaID")]
        public int KaraNoktaID { get; set; }

        [XmlElement(ElementName = "KaraNoktaAd")]
        public string KaraNoktaAd { get; set; }
    }

    [XmlRoot(ElementName = "NewDataSet")]
    public class LineDataSet
    {

        [XmlElement(ElementName = "Table1")]
        public List<LineDetail> Table1 { get; set; }
    }

    [XmlRoot(ElementName="element")]
    public class Element { 

      [XmlAttribute(AttributeName="name")] 
      public string Name { get; set; } 

      [XmlAttribute(AttributeName="type")] 
      public string Type { get; set; } 

      [XmlAttribute(AttributeName="minOccurs")] 
      public int MinOccurs { get; set; } 

      [XmlElement(ElementName="complexType")] 
      public ComplexType ComplexType { get; set; } 

      [XmlAttribute(AttributeName="IsDataSet")] 
      public bool IsDataSet { get; set; } 

      [XmlAttribute(AttributeName="UseCurrentLocale")] 
      public bool UseCurrentLocale { get; set; } 
    }

    [XmlRoot(ElementName="sequence")]
    public class Sequence { 

      [XmlElement(ElementName="element")] 
      public List<Element> Element { get; set; } 
    }

    [XmlRoot(ElementName="complexType")]
    public class ComplexType { 

      [XmlElement(ElementName="sequence")] 
      public Sequence Sequence { get; set; } 

      [XmlElement(ElementName="choice")] 
      public Choice Choice { get; set; } 
    }

    [XmlRoot(ElementName="choice")]
    public class Choice { 

      [XmlElement(ElementName="element")] 
      public List<Element> Element { get; set; } 

      [XmlAttribute(AttributeName="minOccurs")] 
      public int MinOccurs { get; set; } 

      [XmlAttribute(AttributeName="maxOccurs")] 
      public string MaxOccurs { get; set; } 
    }

    [XmlRoot(ElementName="schema")]
    public class Schema { 

      [XmlElement(ElementName="element")] 
      public Element Element { get; set; } 

      [XmlAttribute(AttributeName="id")] 
      public string Id { get; set; } 

      [XmlAttribute(AttributeName="xs")] 
      public string Xs { get; set; } 

      [XmlAttribute(AttributeName="msdata")] 
      public string Msdata { get; set; } 
    }

    [XmlRoot(ElementName="Sefer")]
    public class Sefer { 

      [XmlElement(ElementName="YerelTarihSaat")] 
      public DateTime YerelTarihSaat { get; set; } 

      [XmlElement(ElementName="InternetTarihSaat")] 
      public DateTime InternetTarihSaat { get; set; } 

      [XmlElement(ElementName="KalkisAdi")] 
      public string KalkisAdi { get; set; } 

      [XmlElement(ElementName="VarisAdi")] 
      public string VarisAdi { get; set; } 

      [XmlElement(ElementName="HatNo")] 
      public int HatNo { get; set; } 

      [XmlElement(ElementName="FiyatDegistirebilir")] 
      public string FiyatDegistirebilir { get; set; } 

      [XmlElement(ElementName="BiletFiyati1")] 
      public double BiletFiyati1 { get; set; } 

      [XmlElement(ElementName="BiletFiyati2")] 
      public double BiletFiyati2 { get; set; } 

      [XmlElement(ElementName="BiletFiyati3")] 
      public double BiletFiyati3 { get; set; } 

      [XmlElement(ElementName="BiletFiyatiInternet")] 
      public double BiletFiyatiInternet { get; set; } 

      [XmlElement(ElementName="BiletFiyatiSinifFarki")] 
      public double BiletFiyatiSinifFarki { get; set; } 

      [XmlElement(ElementName="BiletTekKoltukFarki")] 
      public double BiletTekKoltukFarki { get; set; } 

      [XmlElement(ElementName="BiletFiyatiMisafir")] 
      public double BiletFiyatiMisafir { get; set; } 

      [XmlElement(ElementName="MisafirBiletSatar")] 
      public bool MisafirBiletSatar { get; set; } 

      [XmlElement(ElementName="OzurluIndirmliBiletSatar")] 
      public bool OzurluIndirmliBiletSatar { get; set; } 

      [XmlElement(ElementName="KontenjanliBiletSatar")] 
      public bool KontenjanliBiletSatar { get; set; } 

      [XmlElement(ElementName="RezervasyonAktifMi")] 
      public bool RezervasyonAktifMi { get; set; } 

      [XmlElement(ElementName="SatisAktifMi")] 
      public bool SatisAktifMi { get; set; } 

      [XmlElement(ElementName="MaximumRezerveTarihiSaati")] 
      public string MaximumRezerveTarihiSaati { get; set; } 

      [XmlElement(ElementName="OtobusTip")] 
      public string OtobusTip { get; set; } 

      [XmlElement(ElementName="OtobusTipSinif")] 
      public int OtobusTipSinif { get; set; } 

      [XmlElement(ElementName="OtobusTipIkinciKatSira")] 
      public int OtobusTipIkinciKatSira { get; set; } 

      [XmlElement(ElementName="OtobusPlaka")] 
      public string OtobusPlaka { get; set; } 

      [XmlElement(ElementName="OtobusKaptanAdi")] 
      public string OtobusKaptanAdi { get; set; } 

      [XmlElement(ElementName="OtobusHostesAdi")] 
      public string OtobusHostesAdi { get; set; } 

      [XmlElement(ElementName="Okalkti")] 
      public int Okalkti { get; set; } 

      [XmlElement(ElementName="OtobusSeferMesaji")] 
      public string OtobusSeferMesaji { get; set; } 

      [XmlElement(ElementName="OtobusSubeMesaji")] 
      public string OtobusSubeMesaji { get; set; } 

      [XmlElement(ElementName="PeronNo")] 
      public string PeronNo { get; set; } 

      [XmlElement(ElementName="KalkisTerminalAdi")] 
      public string KalkisTerminalAdi { get; set; } 

      [XmlElement(ElementName="GeceAciklamasi")] 
      public string GeceAciklamasi { get; set; } 

      [XmlElement(ElementName="MaximumBosBayanYaniSayisi")] 
      public int MaximumBosBayanYaniSayisi { get; set; } 

      [XmlElement(ElementName="SubeBiletPort")] 
      public int SubeBiletPort { get; set; } 

      [XmlElement(ElementName="YolcuUyePuanToplam")] 
      public int YolcuUyePuanToplam { get; set; } 

      [XmlElement(ElementName="YolcuUyePuanCarpan")] 
      public string YolcuUyePuanCarpan { get; set; } 

      [XmlElement(ElementName="DolulukOraniIndirimiYapildi")] 
      public string DolulukOraniIndirimiYapildi { get; set; } 

      [XmlElement(ElementName="OTipOzellik")] 
      public string OTipOzellik { get; set; } 

      [XmlElement(ElementName="YonuTersKoltuklar")] 
      public string YonuTersKoltuklar { get; set; } 

      [XmlElement(ElementName="SubeSatistaTcKimlikNoYazmakZorunlu")] 
      public int SubeSatistaTcKimlikNoYazmakZorunlu { get; set; } 

      [XmlElement(ElementName="SeyahatSuresi")] 
      public string SeyahatSuresi { get; set; } 

      [XmlElement(ElementName="SeferTipiAciklamasi")] 
      public string SeferTipiAciklamasi { get; set; } 

      [XmlElement(ElementName="OTipAciklamasi")] 
      public string OTipAciklamasi { get; set; } 

      [XmlElement(ElementName="FirmaEnUygunFiyatAktifMi")] 
      public int FirmaEnUygunFiyatAktifMi { get; set; } 

      [XmlElement(ElementName="OtobusMesaj")] 
      public string OtobusMesaj { get; set; } 

      [XmlElement(ElementName="Tesisler")] 
      public string Tesisler { get; set; } 

      [XmlElement(ElementName="Odeme3DSecureAktifMi")] 
      public int Odeme3DSecureAktifMi { get; set; } 

      [XmlElement(ElementName="Odeme3DSecureZorunluMu")] 
      public int Odeme3DSecureZorunluMu { get; set; } 

      [XmlElement(ElementName="PaypalUstLimit")] 
      public int PaypalUstLimit { get; set; } 

      [XmlElement(ElementName="MaximumBosBayYaniSayisi")] 
      public int MaximumBosBayYaniSayisi { get; set; } 

      [XmlElement(ElementName="SatilabilirKoltukSayi")] 
      public int SatilabilirKoltukSayi { get; set; } 

      [XmlElement(ElementName="RezervasyonNedenYapilamaz")] 
      public string RezervasyonNedenYapilamaz { get; set; } 

      [XmlElement(ElementName="FirmaMaxToplamBiletFiyati")] 
      public double FirmaMaxToplamBiletFiyati { get; set; } 

      [XmlElement(ElementName="PasaportNoIleIslemYapilirMi")] 
      public int PasaportNoIleIslemYapilirMi { get; set; } 

      [XmlElement(ElementName="FarkliCinsiyetteKoltuklarSecilebilirMi")] 
      public int FarkliCinsiyetteKoltuklarSecilebilirMi { get; set; } 

      [XmlElement(ElementName="OtobusKoltukBoslukSemasi")] 
      public string OtobusKoltukBoslukSemasi { get; set; } 

      [XmlElement(ElementName="OtobusHesKoduZorunluMu")] 
      public int OtobusHesKoduZorunluMu { get; set; } 

      [XmlElement(ElementName="CiftKoltukTekYolcuyaSatilabilirMi")] 
      public int CiftKoltukTekYolcuyaSatilabilirMi { get; set; } 

      [XmlElement(ElementName="TekliKoltuklarDoluysaCiftliKoltuktanSatisYapilabilirMi")] 
      public int TekliKoltuklarDoluysaCiftliKoltuktanSatisYapilabilirMi { get; set; } 

      [XmlElement(ElementName="YaklasikSeyahatSuresi")] 
      public string YaklasikSeyahatSuresi { get; set; } 

      [XmlElement(ElementName="SeyahatSuresiGosterimTipi")] 
      public int SeyahatSuresiGosterimTipi { get; set; } 

      [XmlElement(ElementName="FarkliFiyattaKoltuklarSecilebilirMi")] 
      public int FarkliFiyattaKoltuklarSecilebilirMi { get; set; } 

      [XmlElement(ElementName="BiletIptalAktifMi")] 
      public int BiletIptalAktifMi { get; set; } 

      [XmlElement(ElementName="AcikParaKullanimAktifMi")] 
      public int AcikParaKullanimAktifMi { get; set; } 

      [XmlElement(ElementName="SefereKadarIptalEdilebilmeSuresiDakika")] 
      public int SefereKadarIptalEdilebilmeSuresiDakika { get; set; } 

      [XmlElement(ElementName="KalkisNoktaID")] 
      public int KalkisNoktaID { get; set; } 

      [XmlElement(ElementName="KalkisNokta")] 
      public string KalkisNokta { get; set; } 

      [XmlElement(ElementName="VarisNoktaID")] 
      public int VarisNoktaID { get; set; } 

      [XmlElement(ElementName="VarisNokta")] 
      public string VarisNokta { get; set; } 
    }

    [XmlRoot(ElementName="Koltuk")]
    public class Koltuk { 

      [XmlElement(ElementName="KoltukStr")] 
      public string KoltukStr { get; set; } 

      [XmlElement(ElementName="KoltukNo")] 
      public int KoltukNo { get; set; } 

      [XmlElement(ElementName="Durum")] 
      public int Durum { get; set; } 

      [XmlElement(ElementName="DurumYan")] 
      public int DurumYan { get; set; } 

      [XmlElement(ElementName="KoltukFiyatiInternet")] 
      public decimal KoltukFiyatiInternet { get; set; } 
    }

    [XmlRoot(ElementName="SeyahatTipleri")]
    public class SeyahatTipleri { 

      [XmlElement(ElementName="SeyahatTipi")] 
      public int SeyahatTipi { get; set; } 

      [XmlElement(ElementName="SeyahatAdi")] 
      public string SeyahatAdi { get; set; } 

      [XmlElement(ElementName="BiletFiyati")] 
      public int BiletFiyati { get; set; } 

      [XmlElement(ElementName="BiletFiyatSinifFarki")] 
      public int BiletFiyatSinifFarki { get; set; } 

      [XmlElement(ElementName="BiletTekKoltukFarki")] 
      public int BiletTekKoltukFarki { get; set; } 
    }

    [XmlRoot(ElementName="OdemeKurallari")]
    public class OdemeKurallari { 

      [XmlElement(ElementName="Odeme3DSecureAktifMi")] 
      public int Odeme3DSecureAktifMi { get; set; } 

      [XmlElement(ElementName="Odeme3DSecureZorunluMu")] 
      public int Odeme3DSecureZorunluMu { get; set; } 

      [XmlElement(ElementName="AcikParaliOdemeAktifMi")] 
      public int AcikParaliOdemeAktifMi { get; set; } 

      [XmlElement(ElementName="OnOdemeAktifMi")] 
      public int OnOdemeAktifMi { get; set; } 

      [XmlElement(ElementName="ParakodOdemeAktifMi")] 
      public int ParakodOdemeAktifMi { get; set; } 

      [XmlElement(ElementName="BkmOdemeAktifMi")] 
      public int BkmOdemeAktifMi { get; set; } 

      [XmlElement(ElementName="PaypalOdemeAktifMi")] 
      public int PaypalOdemeAktifMi { get; set; } 

      [XmlElement(ElementName="PaypalUstLimit")] 
      public int PaypalUstLimit { get; set; } 

      [XmlElement(ElementName="HopiAktifMi")] 
      public int HopiAktifMi { get; set; } 

      [XmlElement(ElementName="MasterpassAktifMi")] 
      public int MasterpassAktifMi { get; set; } 

      [XmlElement(ElementName="FastPayOdemeAktifMi")] 
      public int FastPayOdemeAktifMi { get; set; } 

      [XmlElement(ElementName="GarantiPayOdemeAktifMi")] 
      public int GarantiPayOdemeAktifMi { get; set; } 
    }

    [XmlRoot(ElementName="Otobus")]
    public class Otobus { 

      [XmlElement(ElementName="Sefer")] 
      public Sefer Sefer { get; set; } 

      [XmlElement(ElementName="Koltuk")] 
      public List<Koltuk> Koltuk { get; set; } 

      [XmlElement(ElementName="SeyahatTipleri")] 
      public List<SeyahatTipleri> SeyahatTipleri { get; set; } 

      [XmlElement(ElementName="OTipOzellik")] 
      public List<OTipOzellik> OTipOzellik { get; set; } 

      [XmlElement(ElementName="OdemeKurallari")] 
      public OdemeKurallari OdemeKurallari { get; set; } 
    }

    [XmlRoot(ElementName="IslemSonuc")]
    public class IslemSonuc { 

      [XmlElement(ElementName="Sonuc")] 
      public bool Sonuc { get; set; } 

      [XmlElement(ElementName="PNR")] 
      public string PNR { get; set; } 

      [XmlElement(ElementName="RezervasyonOpsiyon")] 
      public string RezervasyonOpsiyon { get; set; } 

      [XmlElement(ElementName="Mesaj")] 
      public string Mesaj { get; set; } 

      [XmlElement(ElementName="SeferInternetTarihSaat")] 
      public string SeferInternetTarihSaat { get; set; } 
    }




[XmlRoot(ElementName="PNR")]
public class PNR { 

	[XmlElement(ElementName="ID")] 
	public int ID { get; set; } 

	[XmlElement(ElementName="PNR")] 
	public string PNRno { get; set; } 

	[XmlElement(ElementName="PnrTip")] 
	public string PnrTip { get; set; } 

	[XmlElement(ElementName="TakipNo")] 
	public string TakipNo { get; set; } 

	[XmlElement(ElementName="Ad")] 
	public string Ad { get; set; } 

	[XmlElement(ElementName="Soyad")] 
	public string Soyad { get; set; } 

	[XmlElement(ElementName="Tel")] 
	public string Tel { get; set; } 

	[XmlElement(ElementName="Email")] 
	public string Email { get; set; } 

	[XmlElement(ElementName="TCKimlikNo")] 
	public string TCKimlikNo { get; set; } 

	[XmlElement(ElementName="OpsiyonTarih")] 
	public DateTime OpsiyonTarih { get; set; } 

	[XmlElement(ElementName="SMSGonderimSayi")] 
	public int SMSGonderimSayi { get; set; } 

	[XmlElement(ElementName="FaturalansinMi")] 
	public bool FaturalansinMi { get; set; } 

	[XmlElement(ElementName="OfflineMi")] 
	public bool OfflineMi { get; set; } 

	[XmlElement(ElementName="UyeID")] 
	public int UyeID { get; set; } 

	[XmlElement(ElementName="CM_EFaturaBireyselMi")] 
	public bool CMEFaturaBireyselMi { get; set; } 

	[XmlElement(ElementName="FirmaNo")] 
	public int FirmaNo { get; set; } 

	[XmlElement(ElementName="ToplamIndirim")] 
	public double ToplamIndirim { get; set; } 

	[XmlElement(ElementName="ServisUcretIndirim")] 
	public int ServisUcretIndirim { get; set; } 
}

[XmlRoot(ElementName="Yolcu")]
public class Yolcu { 

	[XmlElement(ElementName="PNR")] 
	public string PNR { get; set; } 

	[XmlElement(ElementName="ID")] 
	public int ID { get; set; } 

	[XmlElement(ElementName="PNRID")] 
	public int PNRID { get; set; } 

	[XmlElement(ElementName="Ad")] 
	public string Ad { get; set; } 

	[XmlElement(ElementName="Soyad")] 
	public string Soyad { get; set; } 

	[XmlElement(ElementName="TCKimlikNo")] 
	public string TCKimlikNo { get; set; } 

	[XmlElement(ElementName="Cinsiyet")] 
	public int Cinsiyet { get; set; } 

	[XmlElement(ElementName="Tip")] 
	public int Tip { get; set; } 

	[XmlElement(ElementName="Fiyat")] 
	public double Fiyat { get; set; } 

	[XmlElement(ElementName="ServisUcret")] 
	public double ServisUcret { get; set; } 

	[XmlElement(ElementName="Vergi")] 
	public double Vergi { get; set; } 

	[XmlElement(ElementName="EBiletNo")] 
	public string EBiletNo { get; set; } 

	[XmlElement(ElementName="YakitHarc")] 
	public double YakitHarc { get; set; } 

	[XmlElement(ElementName="AlanVergi")] 
	public double AlanVergi { get; set; } 

	[XmlElement(ElementName="ThyCipVarMi")] 
	public bool ThyCipVarMi { get; set; } 

	[XmlElement(ElementName="KoltukNo")] 
	public int KoltukNo { get; set; } 

	[XmlElement(ElementName="BinisYer")] 
	public string BinisYer { get; set; } 

	[XmlElement(ElementName="BinisServis")] 
	public string BinisServis { get; set; } 

	[XmlElement(ElementName="InisServis")] 
	public string InisServis { get; set; } 

	[XmlElement(ElementName="IslemTipi")] 
	public string IslemTipi { get; set; } 

	[XmlElement(ElementName="IslemTarihi")] 
	public DateTime IslemTarihi { get; set; } 

	[XmlElement(ElementName="Acente")] 
	public string Acente { get; set; } 

	[XmlElement(ElementName="Kullanici")] 
	public string Kullanici { get; set; } 

	[XmlElement(ElementName="AcenteID")] 
	public int AcenteID { get; set; } 

	[XmlElement(ElementName="KullaniciID")] 
	public int KullaniciID { get; set; } 

	[XmlElement(ElementName="CM_AcenteID")] 
	public int CMAcenteID { get; set; } 

	[XmlElement(ElementName="CM_KullaniciID")] 
	public int CMKullaniciID { get; set; } 

	[XmlElement(ElementName="MerkezAcenteID")] 
	public int MerkezAcenteID { get; set; } 

	[XmlElement(ElementName="Durum1")] 
	public string Durum1 { get; set; } 

	[XmlElement(ElementName="Durum2")] 
	public string Durum2 { get; set; } 

	[XmlElement(ElementName="Durum1Tarih")] 
	public DateTime Durum1Tarih { get; set; } 

	[XmlElement(ElementName="Durum2Tarih")] 
	public DateTime Durum2Tarih { get; set; } 

	[XmlElement(ElementName="AktifDurum")] 
	public int AktifDurum { get; set; } 
}

[XmlRoot(ElementName="KalkisKod")]
public class KalkisKod { 

	[XmlAttribute(AttributeName="space")] 
	public string Space { get; set; } 
}

[XmlRoot(ElementName="VarisKod")]
public class VarisKod { 

	[XmlAttribute(AttributeName="space")] 
	public string Space { get; set; } 
}

[XmlRoot(ElementName="Segment")]
public class Segment { 

	[XmlElement(ElementName="ID")] 
	public int ID { get; set; } 

	[XmlElement(ElementName="PNRID")] 
	public int PNRID { get; set; } 

	[XmlElement(ElementName="Kalkis")] 
	public string Kalkis { get; set; } 

	[XmlElement(ElementName="Varis")] 
	public string Varis { get; set; } 

	[XmlElement(ElementName="SeferNo")] 
	public int SeferNo { get; set; } 

	[XmlElement(ElementName="HatNo")] 
	public int HatNo { get; set; } 

	[XmlElement(ElementName="KalkisTarih")] 
	public DateTime KalkisTarih { get; set; } 

	[XmlElement(ElementName="VarisTarih")] 
	public DateTime VarisTarih { get; set; } 

	[XmlElement(ElementName="TasiyiciFirma")] 
	public int TasiyiciFirma { get; set; } 

	[XmlElement(ElementName="AracTipi")] 
	public string AracTipi { get; set; } 

	[XmlElement(ElementName="Sinif")] 
	public string Sinif { get; set; } 

	[XmlElement(ElementName="SeferSure")] 
	public DateTime SeferSure { get; set; } 

	[XmlElement(ElementName="SeferTip")] 
	public string SeferTip { get; set; } 

	[XmlElement(ElementName="PeronNo")] 
	public string PeronNo { get; set; } 

	[XmlElement(ElementName="KalkisTerminal")] 
	public string KalkisTerminal { get; set; } 

	[XmlElement(ElementName="BosTarih")] 
	public DateTime BosTarih { get; set; } 

	[XmlElement(ElementName="BosSaat")] 
	public DateTime BosSaat { get; set; } 

	[XmlElement(ElementName="SeferTakipNo")] 
	public int SeferTakipNo { get; set; } 

	[XmlElement(ElementName="DonusMu")] 
	public int DonusMu { get; set; } 

	[XmlElement(ElementName="KalkisKod")] 
	public KalkisKod KalkisKod { get; set; } 

	[XmlElement(ElementName="VarisKod")] 
	public VarisKod VarisKod { get; set; } 

	[XmlElement(ElementName="KalkisNoktaID")] 
	public int KalkisNoktaID { get; set; } 

	[XmlElement(ElementName="VarisNoktaID")] 
	public int VarisNoktaID { get; set; } 

	[XmlElement(ElementName="CiktilardaKaraAramaNoktalariGozuksunMu")] 
	public bool CiktilardaKaraAramaNoktalariGozuksunMu { get; set; } 

	[XmlElement(ElementName="SeyahatSuresiGosterimTipi")] 
	public int SeyahatSuresiGosterimTipi { get; set; } 

	[XmlElement(ElementName="SinifTip")] 
	public string SinifTip { get; set; } 

	[XmlElement(ElementName="FirmaAd")] 
	public string FirmaAd { get; set; } 

	[XmlElement(ElementName="FirmaKod")] 
	public int FirmaKod { get; set; } 

	[XmlElement(ElementName="FirmaID")] 
	public int FirmaID { get; set; } 

	[XmlElement(ElementName="FirmaNo")] 
	public int FirmaNo { get; set; } 

	[XmlElement(ElementName="BiletIptalAktifMi")] 
	public int BiletIptalAktifMi { get; set; } 

	[XmlElement(ElementName="BiletAcigaAlAktifMi")] 
	public int BiletAcigaAlAktifMi { get; set; } 

	[XmlElement(ElementName="SeferSureDk")] 
	public int SeferSureDk { get; set; } 

	[XmlElement(ElementName="YaklasikSeyahatSuresi")] 
	public string YaklasikSeyahatSuresi { get; set; } 

	[XmlElement(ElementName="KalkisKaraNoktaID")] 
	public int KalkisKaraNoktaID { get; set; } 

	[XmlElement(ElementName="KalkisKaraNokta")] 
	public string KalkisKaraNokta { get; set; } 

	[XmlElement(ElementName="VarisKaraNoktaID")] 
	public int VarisKaraNoktaID { get; set; } 

	[XmlElement(ElementName="VarisKaraNokta")] 
	public string VarisKaraNokta { get; set; } 

	[XmlElement(ElementName="SefereKadarIptalEdilebilmeSuresiDakika")] 
	public int SefereKadarIptalEdilebilmeSuresiDakika { get; set; } 
}

[XmlRoot(ElementName="AcikBilet")]
public class AcikBilet { 

	[XmlElement(ElementName="Tahsilat")] 
	public double Tahsilat { get; set; } 

	[XmlElement(ElementName="HarcananTutar")] 
	public double HarcananTutar { get; set; } 

	[XmlElement(ElementName="AcikTutar")] 
	public double AcikTutar { get; set; } 

	[XmlElement(ElementName="KazanilanPuan")] 
	public double KazanilanPuan { get; set; } 

	[XmlElement(ElementName="HarcananPuan")] 
	public double HarcananPuan { get; set; } 

	[XmlElement(ElementName="NetPuan")] 
	public double NetPuan { get; set; } 

	[XmlElement(ElementName="TakipNo")] 
	public string TakipNo { get; set; } 
}

[XmlRoot(ElementName="Uyelik")]
public class Uyelik { 

	[XmlElement(ElementName="MilparaKartNo")] 
	public int MilparaKartNo { get; set; } 

	[XmlElement(ElementName="Ad")] 
	public string Ad { get; set; } 

	[XmlElement(ElementName="Soyad")] 
	public string Soyad { get; set; } 

	[XmlElement(ElementName="Email")] 
	public string Email { get; set; } 

	[XmlElement(ElementName="CepTel")] 
	public string CepTel { get; set; } 

	[XmlElement(ElementName="TcKimlikNo")] 
	public string TcKimlikNo { get; set; } 

	[XmlElement(ElementName="Cinsiyet")] 
	public string Cinsiyet { get; set; } 
}

[XmlRoot(ElementName="Tahsilat")]
public class Tahsilat { 

	[XmlElement(ElementName="Tarih")] 
	public DateTime Tarih { get; set; } 

	[XmlElement(ElementName="Acente")] 
	public string Acente { get; set; } 

	[XmlElement(ElementName="IslemTip")] 
	public string IslemTip { get; set; } 

	[XmlElement(ElementName="Tip")] 
	public string Tip { get; set; } 

	[XmlElement(ElementName="Tutar")] 
	public double Tutar { get; set; } 
}

[XmlRoot(ElementName="PNRIslemDetay")]
public class PNRIslemDetay { 

	[XmlElement(ElementName="PNR")] 
	public string PNR { get; set; } 

	[XmlElement(ElementName="IslemTipi")] 
	public string IslemTipi { get; set; } 

	[XmlElement(ElementName="Tarih")] 
	public DateTime Tarih { get; set; } 

	[XmlElement(ElementName="Firma")] 
	public string Firma { get; set; } 

	[XmlElement(ElementName="KalkisVaris")] 
	public string KalkisVaris { get; set; } 

	[XmlElement(ElementName="KoltukNo")] 
	public int KoltukNo { get; set; } 

	[XmlElement(ElementName="AdSoyad")] 
	public string AdSoyad { get; set; } 

	[XmlElement(ElementName="Tutar")] 
	public double Tutar { get; set; } 
}

[XmlRoot(ElementName="Fatura")]
public class Fatura { 

	[XmlElement(ElementName="ID")] 
	public int ID { get; set; } 

	[XmlElement(ElementName="PNRID")] 
	public int PNRID { get; set; } 

	[XmlElement(ElementName="FaturaTip")] 
	public int FaturaTip { get; set; } 
}

[XmlRoot(ElementName="Komisyon")]
public class Komisyon { 

	[XmlElement(ElementName="Acente")] 
	public string Acente { get; set; } 

	[XmlElement(ElementName="Tutar")] 
	public double Tutar { get; set; } 

	[XmlElement(ElementName="Oran")] 
	public double Oran { get; set; } 
}

[XmlRoot(ElementName="KoltukNolar")]
public class KoltukNolar { 

	[XmlElement(ElementName="KoltukNo")] 
	public int KoltukNo { get; set; } 

	[XmlElement(ElementName="PNRSegmentID")] 
	public int PNRSegmentID { get; set; } 

	[XmlElement(ElementName="PNRYolcuID")] 
	public int PNRYolcuID { get; set; } 
}

[XmlRoot(ElementName="AcenteOnOdeme")]
public class AcenteOnOdeme { 

	[XmlElement(ElementName="TaksitSayi")] 
	public int TaksitSayi { get; set; } 

	[XmlElement(ElementName="VadeFark")] 
	public double VadeFark { get; set; } 

	[XmlElement(ElementName="Tutar")] 
	public double Tutar { get; set; } 
}

[XmlRoot(ElementName="Bilet")]
public class Bilet { 

	[XmlElement(ElementName="schema")] 
	public Schema Schema { get; set; } 

	[XmlElement(ElementName="PNR")] 
	public PNR PNR { get; set; } 

	[XmlElement(ElementName="Yolcu")] 
	public List<Yolcu> Yolcu { get; set; } 

	[XmlElement(ElementName="Segment")] 
	public Segment Segment { get; set; } 

	[XmlElement(ElementName="AcikBilet")] 
	public AcikBilet AcikBilet { get; set; } 

	[XmlElement(ElementName="Uyelik")] 
	public Uyelik Uyelik { get; set; } 

	[XmlElement(ElementName="Tahsilat")] 
	public Tahsilat Tahsilat { get; set; } 

	[XmlElement(ElementName="PNRIslemDetay")] 
	public PNRIslemDetay PNRIslemDetay { get; set; } 

	[XmlElement(ElementName="Fatura")] 
	public Fatura Fatura { get; set; } 

	[XmlElement(ElementName="Komisyon")] 
	public Komisyon Komisyon { get; set; } 

	[XmlElement(ElementName="KoltukNolar")] 
	public KoltukNolar KoltukNolar { get; set; } 

	[XmlElement(ElementName="AcenteOnOdeme")] 
	public AcenteOnOdeme AcenteOnOdeme { get; set; } 

	[XmlAttribute(AttributeName="xmlns")] 
	public string Xmlns { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}


