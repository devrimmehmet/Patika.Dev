# MikroServis Mimarisi Nedir?/ Avantajları Nelerdir/ Monolotik Mimari Nedir?/ SOA Nedir?
## MikroServis Mimarisi Nedir ve Avantajları Nelerdir? Monolotik Mimari, SOA Mimarisi Neden Kullanılır?
Yazılım dünyasında adından sıkça söz ettirmeye başlayan MikroServis Mimarisini bu videomuzda ele alıyoruz. Fakat MikroServisleri öğrenmeden önce ilk olarak bu mimariye neden ihtiyacımız oldu? Daha önceden ne kullanıyorduk, hatta şu anda bile ne mimarisi kullanıyoruz. Ve bunların birbirlerine olan avantajlarını ve dezavantajlarını değerlendiriyoruz.


[Bu video içerisinde;](https://www.youtube.com/watch?v=IGUJKGskaOE)

## Monolotik mimarisi nedir? - Monolithic Architecture
Monolithic yaklaşım, üretilecek sistemin/nesnenin/olgunun bileşenlerini(component) birbirlerine bağlı(interdependent) olarak ve kendi kendine yetecek(self-contained) şekilde tasarlanmasını sağlayan ve böylece tek bir bütünsel varlık olarak nihai sonuca varılmasını sağlayan mimaridir.

## Monolotik mimarisinin avantajları nelerdir?
- Geliştirilmesi basit
- Test edilebilirliği kolay
- Deployment oldukça kolay
- Ölçeklendirme oldukça kolay. Yatay olarak mimarinin kopyasını Load Balancer arkasında çalıştırabilirsiniz.

## Monolotik mimarisinin dezavantajları nelerdir?
- Bakımı proje büyüdükçe zorlaşır.(Sürdürülebilirlik)
- Uygulamanın boyutu başlama süresini yavaşlatır
- Uygulama güncelleneceği zaman tüm uygulamayı tekrardan deploy etmeniz gerekir
- Bazen Monolitik uygulamalar ölçeklendirileceği zaman sorun çıkartabilir
- Ölçeklendirme tüm proje genelinde yapılır
- Güvenilirlik / Sağlamlık / Dayanıklılık
- Yeni biri katıldığında ekibe projeyi çözmesi için 3-6 ay zaman sistemi çözmesi gerekecek
-----

## SOA nedir?
- Özet olarak Servislerin ayrı ayrı tasarlanıp, bir yapı oluşturmasını sağlar
- Yapılar birbirlerinden bağımsız olarak çalışabilirler (loose coupling)
- Birden çok sistemin yer aldığı yapılarda kullanılır
- Kendi içerisinde bir çok bileşeni vardır
    - Policies, Contracts, Services ve çok daha fazlası
-Dağıtık yazılım sistemlerinin kalitelerini arttırmayı hedefler
   
## SOA avantajları nelerdir?
    - Tekrar kullanılabilirlik(Reusable)
    - Uyumluluk (Adaptability)
    - Bakım Yeteneği (Maintainability)
    - Güvenilirlik / Dayanıklılık
    - Up Time oranları yüksektir. Ulaşılabilirlik
    - Yatay ve Dikey ölçeklendirme mümkündür
    - Platform bağımsızdır
    - Üretkenlik artar
## SOA dezavantajları nelerdir?
    - Overload // 
    - Yüksek maliyet
    - Yüksek Bant Genişliği

# Mikro Servisler Mimarisi - Micro Services Architecture

## MikroServis mimarisi nedir?

Aslında bir mimari değildir.

- SOA'nın bir yorumudur.
- Her bir servisin kendine ait bir dünyada çalışmasını hedefler (Server Stack)
- Kendine ait veritabanları vardır.
- Sadece 1 küçük işi çok iyi yapmalıdır.
- Api GW üzerinden dış ve iç dünyaya açılırlar.
    - GW (GateWay) 
- Böylece herhangi bir teknoloji ve dile ait kısıtlama olmaz.
- Stateless yapılardır.
- Kolay ölçeklenebilirler (Yatay) 

## MikroServis mimarisinin avantajları nelerdir?
- Çok dilli mimari
- Kolay ölçeklendirme
- Daha iyi bir takım yönetimi
- Yenilik yapmak daha kolay
- Mikro servislerin kendine ait bir veri tabanı vardır
- Daha odaklı (Yapı, Ölçeklendirme)
- İmplemente edilirken diğer servisler etkilenmezler
## MikroServis mimarisinin dezavantajları nelerdir?
- Implementasyon kolay değildir (Network Calls, Service Discovery)
- Debug kolay değildir
- Fault Management(Hata yönetimi) kolay değildir