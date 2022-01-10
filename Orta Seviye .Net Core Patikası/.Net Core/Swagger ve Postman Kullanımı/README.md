# Swagger ve Postman Kullanımı
## Swagger UI Nedir ?

Swagger UI, oluşturduğumuz API'lar ile ilgili bilgileri görselleştirmemiz ve otomatik dökümantasyon oluşturabilmemize yarayan yardımcı bir arayüzdür. Bu arayüz sayesinde web api projemizde hangi resource'lara sahip olduğumuzu ve bu resourcelarla ilgili hangi eylemleri yapabileceğimizle ilgili bir dökümantasyon oluşturmuş oluruz. Bu sayede hem ekip içindeki, hem de API'mizi kullanacak diğer geliştirici arkadaşların bilgi sahibi olmasını sağlamış oluruz.

Bir .net core web api projesi yarattığımızda proje içerisine varsayılan olarak swagger ui eklentisi eklenmiş olarak gelir. Development ortamında çalışan uygulama için varsayılan olarak https://localhost:5001/swagger/index.htmladresinden erişilebilir.

Swagger UI içerisinde bir eylemle ilgili olarak temel iki çeşit bilgi bulunur.

Parameters : Http Put ve Http Post çağrımlarının beklediği parametreleri gördüğümüz yerdir.

Responses : Http talebine karşılık olarak nasıl bir HTTP response'u oluşturabileceğini, response içerisinde hangi tipte bir data döneceğini detaylı olarak görebiliriz.

Swagger UI aracılığı ile eylemlerin beklediği parametreleri kolay bir şekilde doldurarak örnek çağrımlar yapabilir, dönen cevapları gözlemleyebiliriz.

İnceleme Önerisi: Swagger UI ile ilgili detaylı bilgi için [tıklayınız.](https://swagger.io/tools/swagger-ui/)


- Projenin içine girelim "**cd HelloWebapi**"
- **dotnet wacth run**
---
## Postman 
Postman Nedir ?

Postman, API geliştirme için bir işbirliği platformudur. Postman'ın özellikleri, bir API oluşturmanın her adımını basitleştirir ve işbirliğini kolaylaştırarak daha iyi API'leri daha hızlı oluşturabilmenizi sağlar.

Temel özellikleri şu şekildedir:

- Api Client : Postman ile hızlı ve kolay bir şekilde Rest ve Soap istekleri oluşturabilirsiniz. Client yerine kullanabilirsiniz.

- Automated Tests: Testler, tekrar tekrar çalışabilen test grupları oluşturularak otomatik hale getirilir. Postman; birim testleri, fonksiyonel testler, entegrasyon testleri, uçtan-uca testler, regresyon testleri vb.. dahil olmak üzere birçok test türünü otomatikleştirmek için kullanılabilir. Otomatik test, insan hatasını önler ve testi kolaylaştırır.

- Documentation: Postman, dökümanlarınınızı hızlı ve kolay bir şekilde yayınlamanıza olanak tanır. Postman, dokümantasyon sayfanızı dinamik örneklerle ve makine tarafından okunabilir talimatlarla doldurmak için örnek requestlerinizi otomatik olarak çeker, böylece API'nizi dünyanın geri kalanıyla kolayca paylaşabilirsiniz.

İnceleme Önerisi: Postman ile ilgili daha fazla bilgiye sahip olmak için [tıklayınız.](https://www.postman.com/)

- Swagger UI 'dan farklı olarak hem dökümantasyon oluşturmamızı hemde  otomatize testler yapmamızıda sağlar.

---

- - DİPNOT
- - - Postman konusu biraz havada haldı Postman'i indirmedim ve Swagger UI kullanmayı tercih edeceğim gibi duruyor.

---
---
---
---
## Api Debug
Konuyu anladım fakat Pardus'ta HelloWebapi.dll'yi attach kısmında bulamadım hemde Postman kullanmadığım için uygulamayı yapmadım bu konu TEKRAR edilmesi gereken bir konu olarak notlarda bulunsun.