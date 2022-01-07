# HTTP NEDİR? (Hyper Text Transfer Protocol )
Restful servisler Http protokolü ile çalışır. 

Hyper Text Transfer Protokol kelimelerinin baş harflerinden meydana gelen bir metin aktarı protokolüdür. Protokol oluşu ise bu veri aktarımının kurallarının önceden belirlenmiş olmasından gelir.

Örnek olarak statik web site düşünelim. Web site içerisinde yüzlerce nesne farklı formatlarda bulunur, buna css, imaj ve videolar dahildir. Http protokolü bu web sayfalarının (genelde html formatta olurlar) client(istemci) ve server(sunucu) arasındaki bu alışverişten sorumludur.
## Client - Server Mimarisi

![Patika-Dev](https://raw.githubusercontent.com/devrimmehmet/Patika.Dev/master/Orta%20Seviye%20.Net%20Core%20Patikas%C4%B1/.Net%20Core/Http%20Protokol/client-server.jpeg)

Client'ları istemciler yani bilgisayarınızdaki tarayıcılar gibi düşünebilirsiniz. Siz tarayıcınızın adres çubuğuna bir url yazdığınızda uzaktaki bir sunucudan bir talepte bulunursunuz. Burda istemci sizin yerinize tarayıcınızdır, yani Client.

Server yani sunucu ise tarayıcınız aracılığıyla bulunduğunuz isteği karşılayan, eğer uygun ise size cevabı dönen makinedir.

Http protokolü client-server mimarisi ile çalışır. Yani tarayıcınız sunucuya isteği Http aracılığıyla gönderir.

## Http Metotları

HTTP GET // sunucudan veri almak için kullanılır crud içerisinde REST 

HTTP POST // sunucuya veri göndermek için kullanılır crud içerisinde create veri ekleme işlemine karşılık gelir

HTTP PUT // veriyi değiştirmek için. crud içerisinde update

HTTP DELETE // veriyi sunucudan tamamen silmek için kullanılır silme işlemine karşılık gelir

## Http Responses 

---

HTTP/1.1 200 OK

Date: Wed, 12 May 2021 15:44:04 GMT

Server: Apache/2.2.3 (CentOS)

Content-Type: text/html

(Response Body..)

---

- Durum Satırı
- Date //veriyi hazırlayıp geri getirdiği tarih saat
- Server 
- Content Type // sunucunun geri gönderdiği verinin türünü
- Response Body // sunucunun döndüğü veri

### Http Durum Kodları

-200: OK // istek başarılı 

-401: Unauthorized // bu işlemi yapmak için yetkili bir kullanıcı değilsiniz.

-403: Forbidden // hatalı erişim isteği bu kaynağa erişim yetkiniz yok.

-404: Not Found // istekte bulunduğunuz kaynağı yanlış girmiş olabilirsin dosyayı bulamıyor.

-500: Internal Server Error // en kötüsü bu 

Daha farklı kodlarda bulunuyor.

[Http durum kodlarının tamamı için](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status)

[Http Protokolü ve metotları ile ilgili daha detay bilgi için](https://developer.mozilla.org/en-US/docs/Web/HTTP)

-----
-----
-----
-----
-----


# Restful Servisler
Rest 2000 yılında bir sunucu ve istemci arasında hızlı ve kolay iletişimi sağlamak amacıyla ortaya cıkmış bir servis yapısıdır. Http protokolü ile çalışır. Açılımı Representational State Transfer dır. Servis yönelimli yani SOA mimarileriyle geliştirilen yazılımlarda tercih edilir. Rest standartlarına göre yazılmış web servislere RestFul servisler denir.
## REST SERVİS YAPISI - 2000, REPRESENTATIONAL STATE TRANSFER
- SOA
- Restful Servis
- Html, Xml, Json
- Http Protokolü
- Resource  //kaynaklar
    - URI //uniform resources ıdenty files
    - /products/25
- Stateless 
Rest yapısıyla çalışan servislerle Json, Xml ve Html formatında veriler taşınabilir. Http protokolüyle çalışıyor olması basit ve hızlı bir iletişim sunar.
## RESTFUL SERVISLERLE HTTP METOTLARININ KULLANIMI

GET,PUT,DELETE,POST

Http metotlarından GET, PUT, DELETE idempotent yapıda iken POST idempotent değildir.
    - idempotent
    - Get,Put,Delete vs Post   
    // put 1 kere çağır, birden fazla ise post kullan

Peki nedir bu idempotent? Birden fazla defa çağırılmasında sakınca olmayan, nihai sonucu değiştirmeyecek çağrımlara idempotent yapıda diyebiliriz. Örneğin bir Http Get metodunu üst üste istediğiniz kadar çağırabilirsiniz. Bu sonucu değiştiremeyecektir. Yada Http Delete metodunu bir kere çağırdığınızda veriyi sildiğinizi düşünelim. 2. yada 3. çağrımlarda veride bir değişiklik olmaz. Zaten silinmiştir.

Günün sonunda POST ile güncelleme de silme de yapabilirsiniz. Peki neden DELETE ve PUT kullanmalıyz? Rest Http metotları ile veriye anlamlı ve doğru şekilde ulaşmayı amaçlar. Bir request çağrısına baktığınızda onun ne iş yaptığını kolayca anlayabilmelisiniz. Http metotlarının doğru yerde kullanılması bize okunabilirlik gücünü getirir.

Şimdi bu bilgiler ışığında PUT ve POST metotlarına bakalım. Hangi durumda POST hangi durumda PUT kullanacağımıza karar verme noktasında genel olarak bir karmaşa yaşanıyor. PUT ve POST arasındaki en büyük fark idempotent'dir. Birden fazla çağrılması veri üzerinde soruna neden olmayacak çağrımlarınız için PUT kullanabilirsiniz. POST ise, tekrar tekrar çağrıldığında veri tutarlılığını bozabilecek çağrılardır. Biz sunucu tarafında bunu istediğimiz gibi yönetebiliriz ama tarayıcı için put ve post farklı çağrılardır. Ve üst üste post yapılmasına neden olabilecek için tarayıcıların kendi önlemleri vardır. Dolayısıyla kurallara uygun şekilde kullanmak en doğru yaklaşımdır.

Okuma Önerisi:[Restful servislerle ilgili daha detaylı bilgi için tıklayınız.](https://denizirgin.com/rest-ve-restful-web-servis-kavram%C4%B1-30bc4400b9e0)

Inceleme Önerisi:[Durum kodlarına detaylı bakmak için tıklayınız.](https://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html)

-----
-----
-----
-----
-----

# RESTFUL ve SOAP
## SOAP - Simple Object Access Protocol
SOAP (Simple Object Access Protocol) uygulamalar ile web servislerin bilgi aktarımını sağlayan XML tabanlı bir protokoldür. Yani web servise giden bilgi XML olarak gönderilir, web servis bu bilgiyi yorumlar ve sonucunu XML olarak geri döndürür. SOAP tabanlı bir web servisin, gönderilen XML verisini nasıl yorumlayacağının tanımlanması gerekir. Bu web servis tanımlaması WSDL standardı ile yapılır.
### **REST vs SOAP**
![Patika-Dev](https://raw.githubusercontent.com/devrimmehmet/Patika.Dev/master/Orta%20Seviye%20.Net%20Core%20Patikas%C4%B1/.Net%20Core/Http%20Protokol/download.png)

### Rest Servislerde İletişim Seviyesinde Güvenlik


Genellikle bir ön çağrı yapılarak, istemci sunucuya kendisini tanıtan bir istekte bulunur. Sunucu client'a yetki vermek isterse client'ın gönderdiği bilgilere istinaden bir token oluşturur. Ve istemcinin sonraki isteklerde token içerisinde belirtilen süre boyunca bu token ile birlikte gelmesi beklenir. Token geçerli olduğu sürece sunucu istemciyi tanır ve request'lerine cevap verir.
-----
-----
-----
-----
-----

# JSON (JavaScript Object Notation)


JSON ("JavaScript Object Notation") bütün programlama dilleri arasında, yapılandırılmış veri değişimini kolaylaştıran bir metin biçimidir. Json içerisinde kullanılabilecek karakterler şu şekildedir. "{}", "[]",";","," Ecmascript programlama dilinden esinlenerek ortaya çıkmış bir metin biçimidir ama programlama dillerinden bağımsızdır. JSON sahip olduğu ağaç yapısıyla DOM ve XML ile benzerlik gösterse de bunlardan tamamen farklı bir yapıdadır.


## JSON'ın desteklediği veri tipleri şu şekildedir.

- Number
- String
- Boolean
- Array
- Object
- null

Örnek JSON:

{

    "isim": "Albay",
    "tur": "Kedi",
    "sahip": [
        {"ad": "Zikriye Ürkmez", "cinsiyet": "Kadın"},
        {"ad": "İlhan Cengiz", "cinsiyet": "Erkek"}
             ]
}