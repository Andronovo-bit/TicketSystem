export interface BookRezervation 
{
    "firmaNo":number,
    "kalkisNoktaID": number,
    "varisNoktaID": number,
    "tarih": string,
    "saat": Date,
    "hatNo": number,
    "seferNo": number,
    "kalkisTerminalAdiSaatleri": string,
    "koltukNo1": string,
    "adi1": string,
    "soyadi1": string,
    "tcKimlikNo1": string,
    "servisYeriKalkis1": string,
    "telefonNo": string,
    "cinsiyet": string,
    "yolcuSayisi": number,
    "firmaAciklama": string,
    "hatirlaticiNot": string,
    "WebYolcu": WebYolcu,
  }

  export interface WebYolcu {
    "WebUyeNo"?: number | 0,
    "Ip"?: string | "127.0.0.1",
    "Email": string,
  }

