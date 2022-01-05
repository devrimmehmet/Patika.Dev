# HTTP NEDİR? (Hyper Text Transfer Protocol )
Restful servisler Http protokolü ile çalışır. 

Hyper Text Transfer Protokol kelimelerinin baş harflerinden meydana gelen bir metin aktarı protokolüdür. Protokol oluşu ise bu veri aktarımının kurallarının önceden belirlenmiş olmasından gelir.

Örnek olarak statik web site düşünelim. Web site içerisinde yüzlerce nesne farklı formatlarda bulunur, buna css, imaj ve videolar dahildir. Http protokolü bu web sayfalarının (genelde html formatta olurlar) client(istemci) ve server(sunucu) arasındaki bu alışverişten sorumludur.
## Client - Server Mimarisi

![alt text](https://raw.githubusercontent.com/devrimmehmet/Patika.Dev/master/Orta%20Seviye%20.Net%20Core%20Patikas%C4%B1/.Net%20Core/Http%20Protokol/client-server.jpeg)

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

