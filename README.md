
# Biletall Assignment

Bu proje Gidiş, varış noktalarının ve tarih seçilmesi ile otobüs seferlenin getirilmesi ve gelen sefelerden rezervasyon yapmayı, rezervasyon sonrasında ise pnr numarasını sorgulamayı kapsar.




## Kullanılan Yapılar

- .Net 6 (Entity Framework, In-Memory Cache, Dependecy Injection, Options Pattern, Generic Repository, Code-First)
- React (Typescript, Tailwind, AntDesign, PostCss)


  
## Çalıştırma(Vs Code)

Bu projeyi çalıştrmak için;

- Node version: 18.6.0
- Npm version: 8.13.2
- .Net 6 Enviroment
- SQL Server
gereklidir.

Ortamı ayarladıktan sonra projenin içersinden React için ClientApp dizinine erişilerek aşağıdaki komutlar çalıştırılmalıdır.

```bash
  npm install
  npm run build
```

.Net ortamı için ise proje içersindeki appsettings.json içersine connection string ayarı verildikten sonra veritabanına migration atılmaldır.

Daha sonra Proje içersinde /TicketSystem dizinine girerek aşağıdaki komutu çalıştrmak yeterli olacaktır.

```bash
  dotnet run
```


  
