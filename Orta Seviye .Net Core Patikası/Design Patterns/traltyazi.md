5:10

---
---
---
---
---
---


ama bu kursu almak için bir Java geliştiricisi olmanıza gerek yok bir



sonraki bölümde size

Java sözdizimine hızlı bir genel bakış sunacağım, böylece siz

Yazdığımız kodu kolayca

anlayabilir Python veya C keskin veya

başka bir dil kullanıyorsanız

, bu kurstaki kavramları alabilir ve

en sevdiğiniz programlama dilinde tekrar uygulayabilirsiniz,

odak noktamız belirli

bir nesneye yönelik yazılım tasarlama sanatıdır.

programlama l  anguage

şimdi bir Java geliştiricisiyseniz

, sizin için biraz basit görünse de bir sonraki bölümü izlemenizi tavsiye



ederim çünkü bir sonraki

bölümde kapsülleme gibi

temel nesne yönelimli programlama

kavramlarından bahsedeceğim.

soyutlama kalıtımı ve

polimorfizm birçok geliştirici bu kavramı gerçekten tam olarak

anlamıyor, bu



yüzden bu bölümün bir sonraki bölümünde



görüşürüz.

Bu dersi alabilmek için anlamamız gereken,

sınıflar

arayüzler, kapsülleme soyutlama

kalıtım polimorfizmi ve bu ders boyunca

kullanacağımız grafik gösterim olan UML hakkında konuşacağız

Java

biliyorsanız, ilk veya iki videoyu atlayabilirsiniz.

yeni bir proje oluşturun ve

size bir sınıfla nasıl çalışacağınızı gösterin, ancak



diğer tüm dersleri özellikle de

arayüzler hakkındaki dersi izlemenizi şiddetle tavsiye ediyorum çünkü int  erfaces Java'daki

en yanlış anlaşılan kavramlardan

biridir ve birçok programlama

dilinde ayrıca kapsülleme soyutlama kalıtımı ve polimorfizm gibi diğer tüm dersleri izlediğinizden emin olun,





bunlar son derece önemlidir

, aynı sayfada olduğumuzdan emin olmak istiyorum ve

gerçekten  bu kavramların

ne olduğunu anlayın,

eğer bu kavramları düzgün

bir şekilde anlamazsanız, tasarım kalıplarını anlayamayacaksınız, o yüzden

hemen başlayalım ve

bu kursta

çok popüler bir Java olan IntelliJ kullanacağım.  IDE, ancak IntelliJ ve benimle birlikte kod

kullanmak istiyorsanız, tercih ettiğiniz herhangi bir kimliği



kullanabilirsiniz, jetbrains comm

slash fikir eğik çizgi indirmesinden alabiliriz,

iki sürümde gelir, ücretli olan nihai ve

ücretsiz ve açık kaynak olan topluluk

burada  IntelliJ'de

yepyeni bir proje oluşturalım bu yüzden soldaki Java'yı

seçiyoruz sonra şablondan proje oluştur seçiyoruz

bir komut satırı uygulaması oluşturmak istiyoruz

bundan sonra vereceğimiz  bu

projeye bir isim hadi buna tasarım

desenleri diyelim burada

temel paket adını belirtmeliyiz Java'daki bir paket

bir veya daha fazla sınıf için bir kapsayıcıdır,

buna C keskin

ve ad alanı denir, bu yüzden burada

temel paket adını şu şekilde yazmalıyız

konvansiyonel ters etki alanı adını kullanıyoruz etki alanım

eşleşme sakinli koddur bu yüzden burada

Marsh ile bu kodu sakinleştirdik bu sadece bir

konvansiyondur bu

bir İnternet'te kayıtlı bir etki alanı adınız olması gerektiği anlamına gelmez

buraya herhangi bir şey yazabilirsiniz tamam

tamam  gördüğünüz gibi her Java

projesinde bu ana dosya ana dat Java var

ve bu dosyada

tam olarak aynı ada sahip bir sınıfımız var, bu sınıf

bu pakette bildirilmiş ve bu

kod yıkama ile comm yani dosyanın üstündeki paket ifadesi

belirliyor  bu

sınıfın tanımlanacağı yerde tamam

şimdi bu sınıfta main adında bir yöntemimiz var

hem bu yöntem hem de bu sınıf

genel olarak ilan edildi,

bu onların bu kod tabanında herhangi bir yerden erişilebilir oldukları anlamına gelir.



bu bölümün ilerleyen kısımlarında bundan bahsedeceğim, şimdi ana

yöntem statik olarak bildirildi, bu



, ana sınıfın bir örneğini oluşturmak zorunda kalmadan doğrudan bu yöntemi çağırabileceğimiz anlamına gelir

void, bu yöntemin dönüş türüdür,

yani bu yöntemin bir geri dönmeyeceği anlamına gelir.

değer ve burada

parantez içinde bu yöntemin parametrelerine sahibiz,

bu durumda

,

bu

programı komut satırından çalıştırırsak ve birkaç

farklı argüman iletirsek, bu

argümanları dize kullanarak yakalayabiliriz, args adlı bir dize dizisi olan tek bir parametremiz var.  dizi tamam

şimdi Java'da bir kod bloğunu temsil etmek için kaşlı ayraçlar kullanıyoruz

ve

geleneksel olarak

C keskin gibi bazı dillerde sol ayracı aynı satıra

koyuyoruz sol ayracı yeni bir satıra koyuyoruz ama

bu Java'da alışılmadık bir durum o yüzden

onu olduğu yere geri getirin, bu

bir Java programının temelleri şimdi

size sınıfları nasıl oluşturacağınızı ve kullanacağınızı



göstereceğim, tamam, izin verin size sınıflarla nasıl çalışacağınızı göstereyim

, bu yüzden projede  ndow

proje klasörünü genişletiyoruz

burada kaynak klasörümüz var burada

bu proje için tüm kaynak kodumuz var ve

bu klasör

ana sınıfı içeren temel paketimiz var şimdi

paket adına sağ tıklayıp

yeni bir sınıf ekliyoruz  bu sınıfta bu kullanıcıyı arayacağız

, doldurabileceğimiz veya

veri depolamak için nitelikler ve yöntemler,

hadi kullanıcı adını saklamak için bir alan ilan edelim,



böylece genel bir dize adı ve

noktalı virgül ile sonlandırdık,

bu nedenle Java'da ifadelerimizi bir ile sonlandırıyoruz.

noktalı virgül

şimdi teknik olarak bu

alanları public olarak ilan etmek kötü bir uygulamadır bundan

bu bölümün ilerleyen kısımlarında bahsedeceğim

şimdilik

her şeyi public olarak ilan edelim, bu yüzden

string bu alanın türüdür ve

buna name deniyor şimdi gidebiliriz

ana sınıfı seçin ve kullanıcı sınıfının yeni bir örneğini oluşturun

, böylece user user

equals new user yazıyoruz, bu yüzden

user adında bir değişken bildiriyoruz, is

değişkeninin türü bizim kullanıcı sınıfımızdır ve burada

bunu yeni bir i olarak ayarlıyoruz

user sınıfının nstance'ını bir kez daha



noktalı virgülle sonlandırıyoruz, şimdi nokta operatörünü kullanarak

bu sınıftaki alan ve yöntemlere erişebiliriz,

böylece name alanını

Marsh olarak ayarlayabiliriz ve bir kez daha bunu

noktalı virgülle sonlandırıyoruz

.  Java'da dizeleri çevrelemek için çift tırnak

kullanırız, şimdi

bu alanı terminalde yazdırabiliriz, böylece

sistem sınıfına sahibiz, bu sınıfın adı verilen bir alanı

var bu, print line adlı bir yöntemi olan bir nesnedir,

bu,

satırı yazmak için konsol gibidir  c-sharp şimdi

burada bu ismi kullanıcıya geçirebiliriz ve sonra

bu programı ctrl + R kullanarak çalıştırabiliriz,

işte gidiyorsunuz, işte benim adım

terminalde güzel şimdi

yeni bir kullanıcı oluştururken adı belirtebiliriz, böylece

geri dönelim  user sınıfı bir

kurucu ekliyoruz bir kurucu, bir sınıfın

yeni bir örneğini oluşturduğumuzda çağrılan bir yöntemdir,



bu yüzden burada public yazarız

, sonra sınıfın adını

yazarız ve sonra parantezlerimiz vardı,

burada parametreleri bildirebiliriz

sonra kaşlı ayraçlarımızı ekleyeceğiz, bu yüzden

buraya string name adında bir parametre ekleyelim,

şimdi name alanını

name parametresinin değerine ayarlayabiliriz, ancak

hem parametre hem de alan aynı tanımlayıcıya sahiptir,

bu nedenle name

equals name yazarsak Java derleyicisi

bu name parametresine atıfta bulunduğumuzu düşünüyor, bu

nedenle sol tarafta bunu bu noktayla öneklememiz gerekiyor

, bu

nedenle

geçerli nesnenin ad alanını

name parametresinin değerine ayarla diyoruz, böylece bu, geçerli nesneye bir referanstır

bu noktayı

yazarsak, bu sınıftaki tüm alanları ve yöntemleri görebiliriz

tamam

şimdi

yeni bir kullanıcı nesnesi oluştururken ana

yönteme geri dönebiliriz, açıkça ayarlamamız gerekmiyor

ve sonra yazdırabiliriz.  bir

terminal yani çalıştır, öncekiyle aynı

sonucu elde edelim güzel şimdi

bu sınıfa bir yöntem ekleyelim, böylece public ile başlıyoruz,

bir değer döndürmek istemiyoruz, bu

yüzden void kullanıyoruz, bu yöntemi merhaba



diyoruz ve burada yazdıracağız

merhaba benim adım gibi bir mesaj  ve sonra

bu dizgiyi

name alanının değeriyle birleştirebiliriz, şimdi bu bağlamda

bir name parametremiz yok

, bu yüzden bu anahtar kelimeyi kullanmak zorunda değiliz,

sadece name alanına doğrudan başvurabiliriz

tamam şimdi geri  main yöntemi

bir kullanıcının adını yazdırmak yerine

user diyebileceğimiz nokta merhaba deyin ve çalıştırın ve

bu mesajı alıyoruz, bu yüzden

Java'da sınıfları bu şekilde oluşturabilir ve kullanabiliriz



nesne yönelimli sistemlerdeki önemli kavramlardan

biri belirleyen kuplajdır.



örneğin burada ana



sınıfta bir



sınıfın başka bir sınıfa

ne kadar bağlı veya bağlı olduğu  değiştirmeliyiz veya en

azından yeniden derlemeli ve yeniden konuşlandırmalıyız, size göstermeme izin verin,

bu yüzden kullanıcı sınıfına geri döneceğim

ve bu yapıcıda yeni bir parametre tanıtacağım,

diyelim ki tamsayı H, böylece

kullanıcı sınıfını şimdi değiştirdik

ana c  lass bozuk

, bu kodu

derleyemeyiz, bu argümanı buraya iletmeliyiz, bu yüzden

birleştirme ile ilgili sorun bu,

size kullanıcı sınıfında başka bir örnek göstereyim,

hadi bu mesajdan önce bir tire ekleyelim,

şimdi ana sınıfa geri

dönmüyoruz'

Kod derleyicimiz çok iyi ama

kullanıcı sınıfındaki kodu değiştirdiğimiz için

bu sınıfın yeniden derlenmesi gerekiyor ve bu,

bu sınıfa bağımlı olan tüm sınıfların

da yeniden derlenmesi

gerektiği anlamına geliyor.  çok basit bir

program sadece iki sınıfımız var ama

ya yüzlerce veya binlerce sınıfımız olsaydı ve

birçoğu

böyle bir uygulamada birbirine oldukça bağımlı

olsaydı, eğer sınıfı

değiştirirse çok sayıda basamaklı değişiklikle sonuçlanabilirdik bir

uygulama oluşturulmuş  bu

şekilde değiştirmek gerçekten zor genişletmek zor

size bir metafor vereyim

arabanız patlarsa sadece

o lastiği

değiştirmeniz yeterli bu direksiyon simidini veya  e

motor sağ arabanız gevşek bağlı bir sisteme bir örnektir arabanızdaki

bileşenler

birlikte çalışır ancak

sıkı bir şekilde bağlı veya birbirine bağımlı değildir,

bu nedenle tek tek

parçaları bağımsız olarak değiştirebilirsiniz uygulamalarımız

aynı şekilde olmalıdır ama nasıl

yapabiliriz  Arayüzleri kullanan gevşek bağlı uygulamalar

ve

sonraki

arayüzleri ele alacağım şey bu,

Java'daki ve

diğer birçok programlama dilindeki en yanlış anlaşılan yapılardan biridir,

bundan yaklaşık 4 olan

nihai Java kursumun ikinci bölümünde ayrıntılı olarak konuştum.

saatler uzun ama

çok kısaca açıklamama izin verin bir arayüz bir sınıfın sağlaması

gereken yetenekleri belirten bir sözleşmedir



size bir metafor vermeme izin verin bir restoran açmak istediğinizi hayal edin

bir şefe ihtiyacınız var

şefin kim olduğu önemli değil yani siz  '

belirli bir şefe bağımlı değilsiniz,

sadece

şef rolünü yerine getirebilecek

birine bağımlısınız, belirli yeteneklere sahip birine

bu bir örnektir  gevşek bağlı bir

sistem şimdi size arayüzün

bir sınıfın sağlaması gereken yetenekleri belirten bir sözleşme olduğunu söyledim



, bu örnekte

bir şefin rolünü arayüzle ve

gerçek şefin rolünü

şefin arayüzünü uygulayan sınıflarla temsil edebiliriz.

arayüzlü arayüzlerin arkasındaki fikir bu,

gevşek bağlı

uygulamalar geliştirebiliriz, bunu size

kodda göstermeme izin verin, diyelim ki bir

vergi hesaplayıcısı oluşturmak istiyorsunuz vergi hesaplaması

karmaşıktır ve kurallar

bir yıldan diğerine değişebilir bir

hesap makinemiz olabilir  2019 yılı için ve 2020 yılı için bir başkası,

tıpkı bir restoranda şef rolünü dolduran farklı insanlara sahip olabileceğimiz gibi,



ancak

tüm vergi hesaplayıcılarının ortak noktası,

muhtemelen vergi hesaplama adı verilen bir yöntemi vardır

, bunu bir arayüz ile temsil edebiliriz,

yani  bu pakette

önce yeni bir sınıf ekleyelim, önce tür

arayüzünü değiştirelim ve buna vergi hesaplayıcı adını verelim, bu yüzden

bu sadece yöntemi belirten bir sözleşmedir.

Hesaplayıcı sınıflarımızın

uygulaması gerektiği için, burada bir yöntem

float hesaplama vergi notumuz vardı,

yalnızca bir yöntem bildirimimiz var, bu nedenle

ifadeyi

noktalı virgülle sonlandırıyoruz bu yöntemin bir

gövdesi yok, varsa uygulaması

yok  burada küme parantezleri bir

derleme hatası alıyoruz bu yüzden bu arayüz

hey diyor ki bir vergi

hesaplayıcı sınıfı oluşturmak istiyorsanız o sınıfın

bu imza ile bir yöntemi olması gerekir tamam

hadi bu projeye gerçek bir vergi hesaplayıcı

ekleyelim o yüzden dediğimiz yeni bir sınıf ekleyelim

bu vergi hesaplayıcı 2019

şimdi buraya yazıyoruz vergi

hesaplayıcıyı uyguluyor şimdi derleme

hatası var çünkü

bu sınıfta





vergi hesaplama yöntemini uygulamadık

bizim sınıfımızda ama bunun

üzerine yazma konusunda endişelenmeyin buna ek açıklama denir.





bu sınıfın bu imzaya sahip bir yöntemi olduğu

, burada bir tane döndürebiliriz,

şimdi başka bir hesap makinesi oluşturalım,

böylece bir kez daha yeni bir sınıf ekledik

ona vergi hesaplayıcı 2020 diyoruz bir kez daha

vergi hesaplayıcıyı

uygular, sonra alternatör yöntemleri uygular

şimdi yılda güzel  2020'ye dönebiliriz ve şimdi

bu arayüzün iki farklı uygulamasına sahibiz



, bu somut

uygulamalarla çalışmak yerine bu

arayüzle çalışmalıyız, buna bir arayüze programlama denir, bu

yüzden bu programda her yerde bir vergi hesaplayıcısına ihtiyacımız var.

'

bu arayüzle çalışacağız, örneğin

ana sınıfa geri dönebiliriz, hadi

genel bir statik yöntem ekleyelim, statik yaptım,

böylece onu doğrudan ana yöntemden çağırabiliriz,

tamam şimdi bu yöntem

bir vergi hesaplayıcısı döndürmeli, işte buradayız'

Arayüzümüzü yeniden kullanarak, buna şimdilik

hesap makinesi diyelim

, yeni bir vergi

hesaplayıcı 2019 döndüreceğiz, şimdi ana

yöntemimizde get ca'yı arayacağız  lculator

yöntemi ve sonucu

hesaplayıcı adı verilen bir değişkende saklayın, bu nedenle bu

yöntemde bu arabirime bir bağımlılığımız veya bağlantımız var

, şimdi bu arabirim

çok basit, çok hafif,

sahip olduğu tek şey, imzasını tuttuğumuz sürece vergiyi hesapla adlı bir yöntem

.  bu

yöntem tam olarak bunlar

gibi bir kırılma değişikliğine sahip olmayacağız bu şekilde

gevşek bağlantı elde ederiz, bu yüzden bu

programlama stiliyle

2019 vergi hesaplayıcımıza gidersek ve diyelim ki buraya yeni bir yöntem ekleyelim,

genel şamandıra hesapla

sigorta değiştirdik  bu sınıf, ancak

bu değişiklik

buradaki ana yöntemimizi etkilemeyecek çünkü şimdi somut bir uygulama

değil bir arayüze programlıyoruz,

eğer

yakından dikkat ettiyseniz ve

burada bataklık diyebilirsiniz,

2019 vergi hesaplayıcısını yeniliyoruz.  bu nedenle

, bu sınıfta herhangi bir değişiklik yaparsanız, bu

sınıfın yeniden derlenmesi gerekir ve bu

, ana sınıfın da yeniden derlenmesi gerektiği anlamına gelir,

bu doğrudur, ancak bu

çok basit bir örnektir.  e bu

kavramı gerçek bir kurumsal uygulamada

göstermek için şimdi bunun gibi bir kod yazacağız



, bize

bir arayüzün gerçek uygulamalarını veren bir bağımlılık enjeksiyon çerçevesi dediğimiz şeyi kullanıyoruz, bu yüzden

kodumuzda eğer bu kavram ise arayüzlerle çalışıyoruz.

merak etmeyin



, kurs boyunca bunun hakkında daha fazla konuşacağız,

böylece önümüzdeki birkaç videoda arayüzler üzerine sınıfların temellerini öğreneceksiniz,







nesne yönelimli programlamanın dört temel ilkesinden bahsedeceğiz  bunu

gerçek bir örnek kullanarak açıklamak daha kolay,

bu yüzden bu projede

hesap adında yeni bir sınıf ekleyeceğim bu bir

banka hesabını temsil ediyor bir insan

bu hesabın bakiyesini depolamak için bir alandır, yani

halka açık dalgalanma bakiyesi şimdi bu

uygulama ile  ana

sınıfa gidebilir ve yeni bir hesap oluşturabilir,

şimdi sınıf adını iki kez tekrarladık,

bu nedenle VAR

anahtar kelimesini burada kullanmak daha iyidir, bu

uygulama ile bakiyeyi

herhangi bir miktara ayarlayabiliriz  bunu pozitif

veya negatif bir değere ayarlayabiliriz

ama ya uygulamamızda eksi bakiyelere izin verilmiyorsa



bu şekilde kod

yazamamalıyız yani ana sınıf gibi diğer sınıfların değişmesine izin vermemeliyiz



bu nesnenin durumu doğrudan bu nesnedeki

verileri değiştirememeliler,

bu sorunu çözmek

için hesap sınıfımıza geri dönüyoruz ve

bu genel anahtar kelimeyi private ile değiştiriyoruz public

ve private erişim

değiştiricilerinin örnekleri diğer birçok nesne-  yönelimli

diller şimdi aynı konsepte sahipler

artık ana sınıfta bir derleme

hatası var çünkü

dengeli alana bu sınıfın dışından erişemiyoruz çünkü bu

sınıfın içinde gizli yani

bu sınıf içinde her yerde kullanabiliriz

ama dışarıdan erişemiyoruz

ama ya gerçekten

dengeyi değiştirmeniz gerekiyorsa,

bunu burada hesap sınıfında nasıl iyi bir şekilde yapabileceğiz,

bir yöntem ekleyebiliriz public

void set bakiyesi

ona bir pa veririz  denge denilen ramer

ve burada bu dengeyi şimdi dengeye ayarladık

çünkü burada bir yöntemimiz

var bu yöntemde bir

çeşit doğrulama yapabiliriz, böylece dengeyi ayarlamadan önce

bunun pozitif bir değer olduğundan emin olabiliriz,

böylece denge sıfırdan büyükse

o zaman  şimdi ayarlayabiliriz daha iyi bir

uygulama,

eğer bakiye geçersiz bir değerse bir istisna veya hata atmak

ama endişelenmeyelim

, bu kursta çok fazla Java yapmak istemiyoruz

, temellere bağlı kalacağız

buna ayarlayıcı diyoruz, aynı belirteçle

bir alanın değerini ayarlamak için kullanılan bir yöntem,

bir alıcıya sahip olabiliriz,

bu nedenle bakiye alanının değerini okumak istiyorsanız

, dengeyi al adlı bir yöntemi çağırabiliriz

so public

float dengeyi alır

ve burada afiş alanının değerini döndürürüz,

bu

eylemdeki kapsülleme ilkesidir, bu nedenle kapsülleme

gerçekten veriler

üzerinde çalışan verileri ve yöntemleri

bir birim veya bir sınıf içinde gruplamak ve

değerleri veya değerleri gizlemekle ilgilidir.  sınıf içindeki bir nesnenin durumu,

bununla sağlam

uygulamalar oluşturabiliriz,

nesnelerimizin geçersiz bir duruma gitmesini önleyebiliriz, bu

yüzden kapsülleme ilkesi bu, şimdi bunu bir

sonraki seviyeye götürebiliriz

, bu yöntem kümesi yerine dengeli olur

para çekme ve para yatırma gibi yöntemleriniz varsa daha iyi,

bu nedenle

bakiyeyi rastgele bir değere göndermek yerine

bir tür işlemi kaydetmek daha iyidir,

böylece bu hesaba ne zaman para yatırdığımızı

veya çektiğimizi biliyoruz, bu yüzden

yeni bir yöntem ekleyelim genel geçersiz

para yatırma  ona miktar adında bir parametre

veriyoruz ve sonra bunu şu

bakiyeye ayarlayabiliriz, bu bakiye artı miktar

veya Java'da Artırılmış atama operatörünü kullanabiliriz, böylece



ifadeyi bu şekilde yeniden yazabiliriz, bakiye

artı eşittir miktar bu iki ifade

aynıdır  bu durumda

disk anahtar kelimesine bile ihtiyacımız yok

çünkü parametremiz miktar olarak adlandırılıyor, bu yüzden

elbette burada daha iyi,

bir çeşit val yapmamız gerekiyor.  idation da

bu miktarın pozitif bir değer olduğundan emin olmak istiyorsunuz, bu

yüzden eğer miktar sıfırdan

büyükse, balaları benzer şekilde güncelleriz,



bu hesaptan para çekmek için bir



kez daha çekme adlı bir yöntem ekleyeceğiz, bir kez daha doğrulamamızı ekleyeceğiz.  mantık

, tutar sıfırdan büyükse

, bakiyeyi bu miktar

kadar düşürürüz, bu daha iyi bir uygulamadır, bu yüzden





bakiyeyi

rastgele bir değere ayarlamak yerine ana yöntemden şimdi ayarlanmış bakiye yönteminden kurtulalım, para yatırma veya

çekme kullanabiliriz  yarattığımız yöntemler,

başlangıçta bu hesaba 10$ yatırıyoruz,

sonra

5$ çekiyoruz, sonunda bakiyeyi alıyoruz ve

yazdırıyoruz, bu bizim baskı

satırı ifademiz ve burada

bakiye alan hesabı çağırabiliriz, hadi

programı çalıştıralım ve bakiye  beş dolar

güzel yani bu tamamen

kapsülleme ile

ilgili şimdi soyutlama hakkında konuşacağız

şimdi

nesne yönelimli programlamanın ikinci ilkesi hakkında konuşalım

soyutlama abs  çekiş



, sınıflarımızda gereksiz ayrıntıları gizleyerek karmaşıklığı azaltmamız gerektiği anlamına gelir, size TV'nizin uzaktan kumandası

hakkında bir metafor düşünmeme izin verin,

bu uzaktan

kumanda, sahip olduğunuz uzaktan kumandanın

içinde TV'nizle çalışmanıza izin veren bir dizi

düğmeye sahiptir.  bir

elektronik kart ve bir grup

transistör ve benzeri şimdi

bu transistörlerle doğrudan çalışmıyoruz

onların uygulama detayı o kadar

çok karmaşıklık var ki

bu karmaşıklık hakkında endişelenmek istemiyoruz

o uzaktan kumandanın içinde ne olduğu umursamıyoruz ne

zaman  aç düğmesine basıyoruz

bu soyutlama ilkesi

eylemde bu yüzden soyutlama ilkesi sınıflarımızda

gereksiz ayrıntıları gizlememiz gerektiğini söylüyor

ve bu

karmaşıklığı azaltmamıza yardımcı oluyor hadi bunu kodda söyleyelim



e-posta göndermek için bir sınıf uygulamak istediğimizi varsayalım  kullanıcılarımıza bu yüzden

yeni bir sınıf ekleyelim

, bu sınıfta bu posta hizmetini diyoruz,

bir e-posta göndermek için bir yönteme ihtiyacımız var, bu nedenle genel geçersiz

e-postayı şimdi bir  burada gerçek uygulamada

e-posta türünde bir parametreye sahip olmalıyız ama e-



posta göndermenin bir parçası olan



bu demoda bunun için endişelenmeyelim.



e-postayı göndermeli ve sonra

bağlantıyı kesmeliyiz, böylece bu yöntemde connect gibi bir yöntemimiz olabilir,

basitçe

connect gibi bir mesaj yazdırırız,

benzer şekilde bağlantı kesme adında bir yöntemimiz olabilir

ve burada bu

mesajı yazdırırız ve bir yöntem daha ekleyelim

public void Authenticate  burada

kullanıcı adımızı ve

şifremizi posta sunucusuna göndereceğiz, diyelim ki

şimdi e-posta gönderme yöntemimizde kimlik doğrulaması

yapacağım, bu yöntemleri

birer birer arayacağız, önce bağlanacağız,

sonra kimlik doğrulaması yapacağız.

asıl e-postayı tekrar göndereceğiz ve sonunda

bağlantıyı keseceğiz şimdi bunu ana sınıfımızda kullanalım,

bu yüzden burada

bir posta servisi oluşturalım ve onu yeni bir posta servisine ayarlayalım

şimdi

arayüzüne bakalım  bu sınıf ve arayüz



ile Java'daki arayüz yapısından bahsetmiyorum, sadece



bir uzaktan kumandanın arayüzü gibi bir sınıfın arayüzünden bahsediyorum

, o uzaktan kumandada gördüğümüz veya

bu sınıfta gördüğümüz şey burada  dört

yöntemi var ama ilk üçü

uygulama detayı

bunu umursamıyoruz sen

bir posta sunucusuna bağlanmayı umursamıyoruz

biz kimlik doğrulamayı umursamıyoruz tek

umursadığımız şey bir e-posta gönderebilmek yani

bu üç yöntem  bu sınıfa ekstra

karmaşıklık katıyorlar, bu sınıfın tüketicilerinin bu sınıfı

kullanmasını zorlaştırıyorlar, bu

yüzden

soyutlama ilkesini uyguladık,

posta servisimize gidiyoruz ve bu yöntemleri

özel yapıyoruz şimdi uygulama

detayları var ve gizliler

bu sınıfın dışından bir kez daha bunu

özel yapıyoruz ve son

kez ana sınıfa geri dönüyoruz

bu sınıfın arayüzüne bakın

tek bir yöntemi var kullanımı çok daha kolay

uzaktan kumanda gibi  sadece

dört düğme, 50 düğmeli uzaktan kumandalardan birini kullanmanın ne kadar zor olduğunu gördünüz mü, nasıl

kullanacağınızı

gerçekten

bilmiyorsunuz, eğer

ses seviyesini değiştirmek istiyorsanız, şimdi her yere bakmanız gerekiyor

bu posta  hizmet

sınıfının tek bir yöntemi vardır, ifadesinin

kullanımı kolaydır ve daha da önemlisi

, bu özel yöntemlerden herhangi birini değiştirirsek

ana sınıf etkilenmeyecektir,

bu nedenle bu yöntemde bir parametre

tanıtırsam

, sahip olduğumuz tek kırılma değişikliğine zaman aşımı diyelim.

burada ana sınıf etkilenmez

çünkü ana sınıf

connect yöntemini göremez bu

soyutlama ilkesini uygulamanın yararıdır uygulamamızda



diğer sınıfları etkilemeden uygulama detayını değiştirebiliriz

şimdi

kalıtım hakkında

konuşalım hadi

nesne yönelimli programlama kalıtım

mirasının üçüncü ilkesinden bahsedin, kodu yeniden kullanmak için bir mekanizma

diyelim, bir Glee çerçevesi oluşturmak istiyoruz

bir grafik kullanıcı arabirimi  ce

çerçevesinde bu çerçevede

metin kutusu düğmesi onay kutusu gibi sınıflara sahip olmak istiyoruz

ve şimdi Onis sınıflarının

bazı ortak davranışları olmalı,

örneğin onları etkinleştirebilmeliyiz veya

devre dışı bırakabilmeliyiz odaklarını ayarlayabilmeliyiz



konumları vb.

şimdi bu sınıfı

uygularken, bu davranışları

çok fazla

kod çoğaltma mirası olan her bir sınıfta uygulamak istemiyoruz, tüm bu ortakları uygulayabilmemiz için

kodu sınıflarımız arasında yeniden kullanmamıza izin veren bir mekanizmadır.



bir ebeveyn

veya temel sınıftaki davranışları ve ardından diğer tüm

sınıfların bu davranışları devralmasını

sağlayın, size göstermeme izin verin, yeni bir sınıf ekleyelim





, şimdi kullanıcı arabirimindeki tüm widget'lar için temel veya üst sınıf olan bu UI kontrolünü arayacağız

bu sınıfta bir kontrolü etkinleştirme veya devre dışı bırakma yeteneğine sahip olmak istiyoruz, bu



nedenle etkinleştirme adı verilen bir yöntem ve burada

sadece etkinleştir adlı bir mesaj yazdıralım

şimdi bir metin kutusu sınıfı oluşturalım, böylece elimizde

textbox adında yeni bir sınıf, UI kontrol sınıfında

yazdığımız kodu miras almak için bu sınıfı çalıştırıyoruz, bu



yüzden buraya UI kontrolünü genişletiyoruz,

şimdi ana sınıfa gidebilir ve

bir metin kutusu nesnesi oluşturabilirsiniz, böylece VAR metin kutusu

onu bir  yeni metin kutusu

Burada bir göz atacağım, etkinleştirme yöntemine sahibiz

, onu metin kutusu

sınıfında uygulamadık, onu UI kontrol sınıfında uyguladık,

ancak metin kutusu bu

kodu şimdi

bu programı çalıştırdığımızda ebeveyninden devraldı.  etkinleştirilmiş

mesaja bakın güzel şimdi

kalıtımla ilgili bu

videoda ele alabileceğimizden daha fazlası var Nihai Java'mın

ikinci bölümünde kalıtımla ilgili tam bir bölüm ayırdım, bu

yüzden

daha fazla bilgi edinmek istiyorsanız gidip o kursu izleyin

'  polimorfizm hakkında konuşacağız

hadi

nesne yönelimli programlamanın dördüncü ilkesinden bahsedelim polimorfizm

poli, çok daha fazla kanat formu

anlamına gelir, yani polimorfizm birçok form anlamına gelir ve

temel olarak bir

nesnenin birçok form alma yeteneğidir.  Bunu size kodda göstermeme izin verin, bu

yüzden bir GUI çerçevesi ile devam ederek



her bir parçacığı ekranda çizme yeteneğine sahip olmak istiyoruz, bu nedenle bir

UI kontrol sınıfında bir yöntem ekleyelim

public void draw şimdi bu yöntemin

bir uygulaması olmayacak çünkü biz



Bir UI kontrolünün nasıl çizileceğini bilmiyorum çünkü

bir widget'ı çizme algoritması widget'ın

tipine özgüdür

bir metin kutusu

çizmek bir onay kutusu çizmekten farklıdır, bu yüzden

uygulamayı boş bırakabiliriz veya daha iyisi bunu şöyle ilan edebiliriz:

soyut yani public

abstract void draw şimdi

birkaç derleme hatası var, ilki

burada çünkü soyut bir yöntemin

bir gövdesi olamaz, bu yüzden parantezleri kaldırır ve

bunu noktalı virgülle sonlandırıyoruz, bu

bir arabirimde bildirdiğimiz bir yöntem gibidir.

sadece bir yöntem bildirimi

, şimdi uygulaması yok

çünkü bu sınıfta soyut bir yöntemimiz var,

bu sınıfı da soyut olarak ilan etmeliyiz, bu



yarı pişmiş bir kek gibi, onu kullanamayız

doğrudan somutlaştıramıyoruz

, UI kontrolünün yeni bir

örneğini oluşturamıyoruz, sadece şimdi

metin kutusu sınıfımıza giderseniz genişletebiliriz, bir

derleme hatası görüyoruz çünkü bu sınıf UI kontrolünün

çizim yöntemini uygulamadı,

bu yüzden koyduk  Buradaki düzeltme işareti,

alt + enter' tuşlarına basın ve yöntemleri

tıpkı bir arabirimde nasıl uyguladığımız gibi yöntemleri uygulayın,

yani şimdi

burada bu genel geçersiz çizim yöntemine sahibiz, şimdi

bir metin kutusu çizimini yazdıralım,

şimdi bu projeye başka bir sınıf ekleyelim

yeni sınıf  ' bu onay kutusunu arayacağız,



bu sınıf

UI kontrolünden tüm kodu devralır, bu yüzden UI kontrolünü genişletir,

sonra IntelliJ'e

bu sınıfın soyut yöntemlerini uygularız,



şimdi bir onay kutusu yazdırıyoruz, böylece her

widget nasıl çizileceğini bilir  kendisi tamam

şimdi ana sınıfımızda ortak bir

statik yöntem ekleyelim public static void draw UI

kontrolü ona UI kontrolü türünde bir parametre

veriyoruz ve bu yöntemde

control dot draw şimdi ou olarak adlandırıyoruz  r ana yöntemi

bu yöntemi arayacağız, bu yüzden

göz kontrolünüzü şimdi çizin UI kontrol

sınıfı metin kutusunun ebeveyni veya temelidir

ve onay kutusu sınıfları, böylece her

metin kutusu bir UI kontrolü ve her onay

kutusu bir UI kontrolü olur  ayrıca

biz bu metodu çağırıyoruz

, textbox sınıfının yeni bir örneğini geçirebiliriz ve

programı burada çalıştırabiliriz,

eğer geçersek bir metin kutusu

çizdiğini görüyoruz ve siz onay

kutusunu çiziyoruz, bu yüzden bu yöntemde olsak bile bir onay kutusu çiziyoruz.

çalışma zamanında bir UI kontrol nesnesi ile çalışmak,



bu nesne birçok farklı

form alabilir, bir onay kutusu veya

bir metin kutusu veya bir düğme gibi davranabilir ve bu nedenle, bu çok

biçimlilik eylem halindedir, böylece bir nesne

birçok farklı form alabilir.

polimorfizm bu yüzden

tüm temel nesne yönelimli

ilkeleri ele aldık

, sonra bu ders boyunca kullanacağımız grafik notasyon olan um L hakkında konuşacağız,





şimdi Java'nın temellerini ele aldık,

hadi UML hakkında konuşalım yeoman is

ş  birleşik modelleme dili için ort ve sistemlerimizi modellemek

için kullandığımız görsel bir dildir ve



bu kurs boyunca sınıflarımızı temsil etmek için kullanacağız

ve buradaki ilişki

birkaç örnektir

UML'de bir sınıfı bu şekilde temsil edebiliriz.

üstte bu dikdörtgen var

orta kısımda sınıfın adı

var alanlar ve aşağıda

yöntemlerimiz var yani burada şekil adında bir

sınıfımız var bu sınıfta

X pozisyonunda bir alanımız ve tipimiz var  bu

alanın tamsayı olduğu için iki nokta üst üste işaretinden sonra

bir alanın veya

parametrenin türünü veya bir yöntemin dönüş türünü belirtiriz,

bu nedenle burada render adında bir yöntemimiz

var, herhangi bir parametresi yok, bu

yüzden boş bir çiftimiz var.  parantez

ve herhangi bir değer döndürmez, bu

nedenle yöntemin adından sonra iki nokta üst üste işaretimiz yoktur

, bu, bu yöntemin dönüş türünün geçersiz olduğu anlamına gelir,

bu eksi işareti

, bu alanın özel olarak bildirildiği

anlamına gelir.  burada ve açıkçası

artı işareti bunun genel olarak bildirildiği anlamına gelir

, bu kursta

tüm alanlarımızın özel olduğunu ve

tüm yöntemlerimizin genel

olduğunu varsayıyoruz, bu nedenle gelecekteki diyagramlarda

eksi ve artı işaretlerini saklamayacağım  işler

basit yani UML'de bir sınıfı bu şekilde temsil edebiliriz

şimdi sınıflar

arasındaki üç tür ilişki hakkında konuşalım

buna

kalıtım ilişkisi

diyoruz yani bu diyagram dikdörtgen

sınıfının şekil sınıfından miras aldığını veya genişlettiğini söylüyor.

burada doğrulayın, böylece sınıf

dikdörtgeni şekli genişletir, şimdi

doğru bir şekilde UML'deyiz, kalıtım

ilişkisinin

boş bir üçgene sahip bir okla gösterildiğini ancak

kullandığım yazılımda böyle bir okumuz yok,

bu yüzden göstereceğim



içi dolu üçgenli bir okla kalıtım ilişkilerim tamam şimdi sınıflar arasındaki

ikinci tür ilişki hakkında konuşalım

buna kompozisyon ilişkisi denir ve



diamolu bir okla gösterilir  nd





, pratik anlamda şekil sınıfının boyut sınıfından oluştuğu anlamına gelir, yani

şekil sınıfında bir yazı boyutu alanımız olduğu anlamına gelir, bu

nedenle şekil sınıfı bu

boyut sınıfından oluşur, başka bir örnek olarak

araba sınıfının oluştuğunu söyleyebilirsiniz.

çünkü artık UML'de her arabanın dört

tekerleği var

, toplama adı verilen

ve kompozisyona biraz benzeyen başka bir ilişki türü var ama ben

bu kursta çok fazla UML

getirmek istemiyorum, her şeyi basit tutmak

ve odaklanmak istiyorsunuz.  tasarım kalıpları hakkında bu nedenle,

eğer UML'de biraz geçmişiniz varsa

, burada kompozisyon yerine bir toplama ilişkisi kullanmamız gerektiğini tartışabilirsiniz,



bu ince ayrıntılar hakkında endişelenmeyelim, bu

yüzden bu

kompozisyon ilişkisi şimdi sınıflar arasındaki

üçüncü tür ilişki hakkında konuşalım.

bizim bağımlılık ilişkisi dediğimiz şeydir



, kesikli okla gösterilir, bu

da şekil sınıfında bir yerde

belge sınıfına bir referansımız olduğu anlamına gelir.  örnek

olarak şekil sınıfında render adında bir yöntemimiz var

ve bu yöntemin

belge türünde bir parametresi var, bu nedenle belge

bu sınıfta bir alan değil ama bu sınıfta bir

yerde kullanılıyor bu

durumda bir parametre ama aynı zamanda

yerel bir değişken de olabilir  render yönteminde tanımlandı, bu

nedenle şekil

sınıfında bir yerde belge sınıfına bir referansımız veya

bağımlılığımız var tamam,

işte bu kursta kullanacağımız üç tür

ilişki var

kalıtım kompozisyonu ve

bağımlılık

hey millet maj burada sadece  İzlediğiniz

bu videonun



nihai tasarım kalıpları kursumun ilk saati olduğunu bildirmek istedim bu

youtube videosunda iki tasarım

kalıbından bahsettik ama nihai tasarım kalıpları

kursum 20'den fazla tasarım kalıbı içeriyor

bunlar tasarım kalıpları  her

yazılım mühendisinin ustalaşması gerekir, bu yüzden

daha fazlasını öğrenmek istiyorsanız,

nihai tasarım kalıpları kursuma kaydolmanızı şiddetle tavsiye ediyorum

, ilk 200 öğrenci

,  kurs büyük bir indirim

ile ilgilenirseniz, bağlantıyı aşağıya koyacağım, bahsedeceğimiz

ilk tasarım

modeli, momento

modelidir, bu modeli

geri alma mekanizmalarını uygulamak için kullanıyoruz

, her şeyden önce size göstermeme izin verin.  Bu projeye yeni bir

paket ekleyeceğim, bu yüzden

paketinizde buna momentum diyoruz

, bu model için tüm kodu yazacağız

şimdi diyelim ki geri alma mekanizmasını

destekleyen bir kod editörü oluşturmak istiyoruz,

bu yüzden bir ekliyoruz.

bu paketteki yeni sınıf biz buna editör diyoruz bu

sınıfta editörün mevcut içeriğini saklamak için bir hisse ihtiyacımız var, bu

yüzden özel

dizgi içeriğine de

bu alan için bir alıcı ve ayarlayıcıya ihtiyacımız

var artık bunları elle yazmamız gerekmiyor

Elimizde IntelliJ'in bunları bizim için oluşturmasını sağlayabiliriz, böylece

alan adının üzerine havucu koyarız

alt' + enter' tuşlarına basın

ve içerik için alıcı ve ayarlayıcı oluştur'u seçin, işte

gidiyorsunuz, işte şimdi editör sınıfımız

, momento kalıbı hakkında konuşmadan önce sizi istiyorum.

10'a 1 harcamak  5 dakika ve bu sınıfta

geri alma özelliğini uygulamak için bir çözüm düşünün

, bu yüzden ana

sınıfımızda yeni bir editör oluşturabilmeliyiz,

diyelim ki editör eşittir yeni

editör, sonra zamanınızın içeriğini ayarlayabilmeliyiz,

diyelim ki bir  ve B

ve C ve sonra içeriği geri alabilmeliyiz

,

böylece 10 ila 15 dakika harcamış olmalı ve

bu özelliği uygulamak için bir çözüm düşünmeliyiz

bu son derece önemli

çünkü size diğer derslerden farklı olarak problem çözme sanatını öğretmek istiyorum.





Size bunun bir kalıp anı olduğunu söyleyen bir UML diyagramı vermeyeceğim

ve bu böyle

çalışır, sizi

Gang of Four'un yaşadığı aynı düşünce

sürecinden geçirmek istiyorum, böylece nasıl

ve neden bir momento ile ortaya çıktıklarını anlarsınız.

desen bu yüzden 10 ila 15 dakika harcayın ve

bir çözüm önerin işiniz bittiğinde geri gelin bir

sonraki derse bakın

işte burada

içerik alanı olan editör sınıfımız ekranı

temiz tutmamak için alıcı ve

ayarlayıcıyı eklemedim  şimdi son videoda oluşturulan

bu sorunu çözmenin en basit yolu,

önceki içerik adı verilen yeni bir alan tanıtmaktır,

bu nedenle

içerik alanının değerini her değiştirmek istediğimizde

, mevcut değeri

önceki içerik alanında saklarız ve

ardından içeriği değiştiririz.  alan çok basit bir

çözümdür ve işe

yarar, ancak bu yaklaşımla yalnızca bir kez geri alabiliriz, eğer

birden çok kez geri alabilmek

istiyorsanız bir listeye ihtiyacımız var, bu yüzden bu

alanı önceki içerikle yeniden adlandırmalıyız,

çoğul adını ve türünü not edin.  alan

şimdi makul bir çözüm olan bir liste olacak

, ya

gelecekte bir süre sonra başlık gibi yeni bir alan

tanıtırsak, böylece editör penceremizin şimdi geri alma mekanizmasını

desteklemek için bir içeriği ve bir başlığı olacak,



önceki başlıklar gibi başka bir alana ihtiyacımız var

başlık alanındaki tüm değişiklikleri şimdi takip etmek için

, gördüğünüz gibi bu çözüm çok genişletilebilir değil,

her yeni

alan tanıttığımızda, tüm verileri depolamak için fazladan bir alan eklememiz gerekiyor.

o alana geçiyor, bu yüzden

daha iyi bir çözüm bulmamız gerekiyor,

şimdi bu iki alanı kaldırmama izin verin

tamam bu daha iyi bu yüzden

bu sınıfta birden fazla alana sahip olmak yerine

editör gibi ayrı bir sınıfa ihtiyacımız var,

bu sınıf depolamadan tamamen sorumlu olacak

editörümüzün

belirli bir zamandaki durumu doğru bir şekilde

bu sınıfta içerik olarak adlandırılan sadece bir

alanımız var gelecekte başlık ve diğer

alanları ekleyebiliriz tüm bu alanlar

tek bir sınıfta olacak tamam yani editör

sınıfımızda saklamamız gerekiyor  editör Durumlarının bir listesi,

bu yüzden bu iki sınıf arasında bir kompozisyon ilişkisine ihtiyacımız var



ve bu, bu alanı önceki içeriklerden önceki Durumlara yeniden adlandırmamız gerektiği anlamına gelir

,

böylece alan sınıfı içindeki editör Durumlarının bir listesine sahip olursunuz

güzel

şimdi bu daha iyi bir çözüm çünkü

birden çok kez geri almamıza izin veriyor

ve editör

sınıfını çok fazla alanla kirletmeyeceğiz tamam ancak bu

çözüm nesne yönelimli çok önemli bir ilkeyi ihlal ediyor

ed tasarımı

, tek sorumluluk

durulanabilir, temelde her

sınıfın tek bir sorumluluğu olması gerektiği anlamına gelir

, size bir

metafor vereyim bir restoranda bir restoran düşünün,



her insanın belirli bir rolü vardır

, tek bir şey yaparlar, garson

sipariş almaktan tamamen sorumludur  onlar

sizin için yemek yapmıyorlar şimdi bir restoran

hayal edin garson siparişinizi alıyor

sizin için yemek yapıyor o alışverişe gidiyor o da

vergi yapıyor mantıklı değil

böyle bir restoran çok

yönetilemez olacak yazılımda da aynı durum var

bakımı yapılabilir bir

yazılım oluşturmak için sınıflarımızı

tek bir

sorumluluğu olacak şekilde tasarlamalıyız şimdi tasarımımıza geri

döndük editör sınıfımızın doğru iki

sorumluluğu var bunlardan biri durum

yönetimi diğeri

ihtiyacımız olan özellikleri bir editörden sağlamak

tüm devlet yönetimi

işlerini bu sınıfın dışında almalı ve

başka bir yere koymalıyız ki bu

alanı bu sınıfın içinde tutmayalım.  Eyaletler

hadi bunu silelim bu demek oluyor ki state

sınıfının editörü ile bir ilişkimiz olmayacak bu

kadar gecikmiş bu

daha

iyi tarih adında yeni bir sınıf tanıtmamız gerekiyor

bu sınıfın tek bir

sorumluluğu olacak ve bu devlet

yönetimi olacak yani

editörün durumundaki değişiklikleri takip et tamam

şimdi bu sınıfta Devletler adında bir alana ihtiyacımız var

bu daha

önce editör sınıfımızda

sahip olduğumuz alandır tamam bu yüzden burada bu alanımız var ve bu

da bir

editör durumuyla kompozisyon ilişkisi,

geçmiş sınıfı bir listede 0 veya daha fazla

editör durumu nesnesi depolayacak tamam

ayrıca iki yönteme ihtiyacımız var push ve push ile pop

, geçmişe yeni bir durum

ekleriz ve pop'u kaldırırız ve son

durumu döndürürüz  şimdi teknik olarak

burada bir liste yerine bir stat kullanabiliriz ama bu

uygulama detayı

bu aşamada bu konuda çok fazla endişelenmeyelim

şimdi alan sınıfı artık durum

nesnelerini dahili olarak saklamasın  ona iki

yeni yöntem verin, durum yarat ve durumu geri

yükle, durum oluştur yöntemi

, düzenleyicinin mevcut durumunu

bir durum nesnesi içinde saklar ve döndürür, bu nedenle

bu yöntemi çağırırız ve hey

, mevcut durumunuzu kaydedin ve bana verin,

bir  editör durum nesnesi sonra biz

tarih sınıfının Push yöntemini çağırırız



hey geçmiş bu durumu kaydedin

bu sınıflar bu şekilde işbirliği yapar tamam

geri yükleme yöntemi bir durum nesnesini alır

ve bu düzenleyiciyi bu

duruma geri getirir, böylece alanlarını

neye göre sıfırlar  şimdi bu durum nesnesinde

var

, editör ve editör durum sınıfları arasındaki ilişkinin türüne bakıyoruz, bu



, editör sınıfının durum editörünü kullandığı anlamına gelen bir bağımlılık ilişkimiz var,

çünkü

durum yöntemi oluşturmak için bir editöre bir

durum nesnesi döndürür tamam  peki

tebrikler ilk modelinizi buldunuz

buna momento modeli deniyor biz

momentum modelini sınıflarımızda geri alma

mekanizmalarını uygulamak için kullanıyoruz şimdi bizim

temsilcimiz  Momentum modelinin kızgınlığı

ama Dörtlü Çete kitabına

veya bu konuyla ilgili ders veya kitaplardan herhangi birine

bakarsanız, bu sınıflar için farklı isimler göreceksiniz

, editöre yaratıcı denir

, editör durumuna

momentum denir ve tarih

bekçi olarak adlandırılanlar bunlar sadece

Gang of

Four'un kavramı göstermek için bulduğu bazı soyut isimler, sınıflarınızı adlandırmak için

onları kullanmanız gerektiği anlamına gelmez

, her zaman sınıflarınız için anlamlı

isimler kullanın, bu yüzden bu işte

kalıp anı  desen

üç katılımcımız veya üç oyuncumuz var

yaratıcı momentum ve bekçi şimdi

bu kalıbı anladığınıza göre

devam edelim ve kodda uygulayalım

tamam her şeyden önce bir

paket yeni bir sınıf ekleyelim

buna editör durumu diyoruz şu anda sadece

bir  bu sınıftaki tek bir alan bu nedenle özel

dize içeriği

bu alanı kurucudan başlatmak güzel olurdu,

böylece alt + enter' tuşlarına basabilir

ve bir kurucu ekleyebiliriz.  bir parametre

var, bu yüzden bir kurucumuz var,

bu kurucunun tek bir parametresi var

ve bu kurucunun gövdesinde

bu alanı

bu parametrenin değeri ile başlatıyoruz oldukça basit şimdi

bu alanı final olarak ilan etmeyi tercih ederim,

bu emin olacaktır

Bu alanı bir kez başlattığımızda,

onu programımızda yanlışlıkla değiştiremeyiz, bu nedenle

bu, kodumuza sağlamlık katacaktır,

şimdi ayrıca

bu alanın değerini daha sonra okumak için burada bir alıcıya ihtiyacımız var, bu yüzden

enter'u çevireceğim ve içerik için alıcı oluşturacağım

bu kadar  şimdi bu sınıfla işimiz bitti, şimdi

editör sınıfımıza gidelim,

iki yeni metoda ihtiyacımız var, durum yarat ve

geri yükle, böylece genel editör durumu,

bu metodu çağırdığımızda durum yaratacak,

editör mevcut durumunu

bir editör durum nesnesi içinde kaydedecek ve

döndürecek  bu yüzden yeni editör Durumu döndür ve

burada içerik alanının değerini

geçelim şimdi geri yükleme yöntemini oluşturalım bu

oldukça kolay

public void restore ona bir durum

nesnesi

veriyoruz ve burada ayarladık  içerik alanı olarak

kalsın, ancak içerik olsun

, yapbozun son parçasının

tarih sınıfı olduğu kadar basit, bu yüzden bu pakette

sınıfınıza ekleyelim, buna tarih diyoruz,

burada istemediğim bir yığın veya liste kullanabiliriz

bu kurs

Java'ya özeldir, bu yüzden bir liste ile gideceğim

özel editörün özel listesi Şimdi burada neler



oluyor bu liste Java'da bildirilen bir arayüzdür,

bu

yüzden önce onu içe aktarmamız gerekir.  aksi takdirde

derleyici onu tanımıyor

alt' + enter' tuşlarına basabiliriz ve intellij

onu üstte içe aktarabilir, bu nedenle

java.util'i bu listeyi içe aktarın şimdi bu liste

arayüzü genel bir arayüzdür,

yani onu farklı bir liste oluşturmak için kullanabiliriz

nesne türleri bir

dizi listesine sahip olabiliriz bir

tamsayı listesine sahip olabiliriz bir editör durumları listesine

sahip olabiliriz bu yüzden bu açılı ayraçlarla bu listede

saklamak istediğimiz nesnelerin türünü belirtiriz

bu durumda

editör durum nesnelerini saklamak istiyoruz  tamam

şimdi bu alan durumuna bir diyelim  d

onu yeni dizi listesine ayarla

, burada neler oluyor sana

bu listenin

java.util

paketinde bildirilen bir

arayüz

olduğunu söyledim.  bir arabirim,

çünkü ArrayList sınıfı

ilgilenmediğimiz başka yöntemlere sahip olabilir,

yalnızca liste arabiriminde bildirilen işlevselliğe ihtiyacımız var

tamam

şimdi burada iki yönteme ihtiyacımız var pub

public void push push bir editör

durumu nesnesi alıyor ve burada biz  Durumları ara

sonra durumu ekle bu durum

nesnesini listenin sonuna ekleyecek tamam

şimdi genel düzenleyici durum burada açılır bu listedeki

son öğenin dizinini hesaplamamız gerekiyor

şimdiye kadar çok kolay olan

son dizin şimdi liste arayüzünün sahip olduğu

size adında bir yöntem

bu listedeki öğelerin sayısını döndürür şimdi

listedeki ilk öğenin dizini 0

yani son öğenin dizinini

almak için boyutu almalı ve 1'e

indirmeliyiz şimdi sonuncuyu alıyoruz  item son item ya da

son durum bu daha iyi

durumlar bununla olsun

belirli bir dizinde bir öğe alabiliriz o halde bu

öğeyi alalım o zaman onu bu listeden çıkarmamız gerekiyor,

böylece States done diyoruz

son durum nesnesini kaldır ve ilet ve sonunda

bu yöntemden son tarihi döndürüyoruz,

bu bizim tarih sınıfımız şimdi

hepsini bir araya getirelim ve geri alma mekanizmasını çalışırken görelim,

bu yüzden burada ana

yöntemde önce bir editör

nesnesi yaratıyoruz, sonra bir geçmiş nesnesi yaratıyoruz, böylece

geçmişimiz eşittir  burada yeni tarihçe

içeriği a olarak ayarlıyoruz aynı

zamanda siz bu tarihi geçmişe kaydetmek istiyorsanız bu tarihi

oluşturan editör diyoruz

bu mevcut durumu döndürecek

ve bunu geçmişimize ekleyeceğiz bu yüzden

geçmişi iten tarih diyoruz  bu nesne

ile basit bir yığın bir kez

daha içeriği olacak şekilde ayarlıyoruz ve bundan hemen sonra

bu tarihi geçmişe kaydediyoruz

sonra içeriği şimdi görmek için ayarlıyoruz burada

geri alabiliriz böylece geçmişi çağırırız ama pop bu

Prima'yı döndürür  devlet ve th  tr

bunu editörümüze vereceğiz, bu yüzden

hey daha önce diyoruz ki, bu tarihle kendinizi

şimdi böyle

eski haline getirin, eğer editörün mevcut durumunu yazdırırsanız,

bir göz atın,

böylece editör yazdırın, ancak içerik alın bir

göz atın B olsun  eğer bir kez daha geri

alırsanız a göreceksiniz bu yüzden hadi

bu satırı çoğaltalım şimdi oraya koşun yani



bu bölümde momento modelini bu şekilde uyguluyoruz

durum kalıbı hakkında konuşacağım diyelim

inşa etmek istediğinizi varsayalım  Photoshop'ta Photoshop gibi bir çizim uygulaması

ve diğer birçok

uygulamada burada bir araç paletimiz

var ve bu tuval seçtiğimiz

araca bağlı olarak farklı davranıyor

, örneğin

seçim aracını seçerseniz

imleç simgesinin şimdi değiştiğini görebilirsiniz.  tıklayıp

sürüklediğimizde şunu söyleriz - dikdörtgen benzer

şekilde fırça aracını seçer ve tıklayıp

sürüklerseniz bu turuncu çizgiyi görürüz, bu nedenle

temelde bu tuval nesnesi

Fare yukarı ve fare aşağı gibi Fare olaylarına yanıt verir,

ancak ne yapar

Mevcut seçili araca bağlı olarak değişir,

hadi bunu kodda simüle edelim

, bu yüzden bu projede önce

yeni bir paket durumu ekleyeceğim

bu bölüm için tüm kodu bu

pakette yazacağız

şimdi burada canvas adında yeni bir sınıfa ihtiyacımız var

bu sınıf

Mouse down ve mouse up gibi Mouse olaylarına yanıt vermelidir, bu

nedenle burada iki yöntem public

void Mouse down ve ben bunu çoğaltacağım

ve ikincisini Mouse

up

olarak yeniden adlandıracağım bu iki yöntemde de

bağlı olarak farklı şeyler yapmalıyız.

şu anda seçili olan araç, şu anda seçili olan aracın

ne olduğunu bulmak için ilk dakika



, Java'da bir enum kullanmanın bir

sabitler kümesi gibi olduğunu temsil edebiliriz, size göstermeme izin verin,

bu pakette önce yeni bir sınıf ekleyelim, önce

değiştirelim  sınıftan numaralandırmaya bir tür ve

sonra onu araç türü olarak adlandırın,



seçim notu gibi birkaç sabit tanımlamamız gerektiğini duydum,

bu sabiti adlandırmak için büyük harfler kullanıyorum

bu Java'da bir kural, yani bu

bizim seçimimiz  ayrıca bir fırçaya

ve bir silgiye ihtiyacımız var şimdi tuval sınıfımıza geri döndük

burada şu anda seçili olan aracı saklamak için bir alana ihtiyacımız olabilir

, bu gerçekten

çok kolay özel araç türü akımı -

ayrıca bu alan için bir alıcı ve ayarlayıcıya ihtiyacımız var, bu

yüzden koyduk  buradaki havuç

alt' + enter' e basın

ve şimdi fare aşağı yöntemimizde güzel bir alıcı ve ayarlayıcı oluşturun,



eğer mevcut 2 eşittir araç tipi nokta

seçimi burada böyle bir kod yazmalıyız, burada

imlecin simgesini seçim simgesine değiştirmeliyiz bu yüzden



şimdi terminal seçim simgesine bir şey yazdırarak simüle ediyoruz, aksi

takdirde mevcut araç o fırçanın araç tipine eşitse,

o



zaman bir kez daha farklı bir mesaj fırçası simgesi yazdıracağız, eğer mevcut toplam

o silginin türüne eşitse, o zaman

yazdıracağız  silgi simgesi şimdi

fare yukarı yönteminde benzer kod olduğunda, zaman kazanmak

için bunu kopyalayacağım ve

sonra buraya yapıştıracağım ve

sonra terminalde yazdırdığımız şeyi değiştireceğim, böylece

kullanıcı fareyi bıraktığı anda b  utton

geçerli araç bir seçim

aracıysa kesikli bir dikdörtgen çizeceksiniz, bu nedenle kesikli dikdörtgen çizin

mevcut araç

fırça ise bir çizgi çizeceğiz ve eğer

bu bir silgiyse bir şeyi sileceğiz

tamam biz de uygulayabiliriz

bu şimdi bir switch and case ifadesi kullanıyorsa,

bir süredir programlanmışsanız



, kodunuzda muhtemelen bunun gibi kalıplar gördünüz, uzun

bir if LS veya Sushant vaka

ifadeleri listeniz var ve muhtemelen

bu ifadeleri farklı

yerlerde tekrarladınız.  bu örnekte, bu iki yöntemde

bu karar verme ifadelerine sahibiz,



gerçek bir uygulamada, gerçek bir çizim

uygulamasında,

e up ve key down gibi klavye olaylarına da yanıt

vermeliyiz ve muhtemelen tüm bu kararları tekrarlamamız gerekiyor-

bu yöntemlerin içinde de yapıyoruz,

bu yüzden aldığımız yaklaşım

sürdürülebilir değil, destekle daha fazla araç,

bu karar verme

ifadeleri daha uzun olacak ve

bunu sürdürmek.  kod gerçekten zor olacak

burada da

genişletilebilirlik eksikliğimiz var bu uygulamayı genişletmek kolay değil

diyelim

ki yarın bir daire çizmek için yeni bir araç ekleyeceğiz

kodumuzun farklı bölümlerine gitmemiz gerekiyor

ve

örneğin fare aşağı

yöntemimizde değişiklik yaparsak başka bir else--

if ifadesi mevcut aracın daire aracı olup olmadığını görmek

için

simgeyi daire simgesine

değiştirirsek, fare yukarı yönteminde benzer bir değişiklik yapmamız gerekir.

bu uygulamayı genişletmek artık kolay değil,

burada gerçekten ihtiyacımız olan şey

, tuvale mevcut seçili araca göre farklı davranma yeteneği verildi,



bu nedenle bu iki yöntemde de seçili araca

bağlı olarak farklı kod yürütüyoruz

,

bu yöntemin davranmasını istiyoruz  derste

mevcut araca bağlı olarak farklı şekilde



nesne yönelimli programlamanın dört temel ilkesinden bahsettik,

kapsülleme soyutlama

kalıtım ve polimorfizm bunlardan

biri.  bu ilkeleri

burada bu problemi çözmek için oynayamayacağımızı mı düşünüyorsun

Bu alıştırmaya on dakika

ayırmanı ve bu problemi çözmenin bir yolunu bulmanı

istiyorum işin bittiğinde geri gel



konuştuğumuz kursun başlarında bir sonraki dersi izle

polimorfizm Size

polimorfizmin bir nesnenin birçok farklı form almasına izin veren bir mekanizma olduğunu söylemiştim, bu



yüzden daha önce bu UI

kontrol sınıfını oluşturduk, bunu tek bir soyut yönteme sahip olduğu için soyut olarak ilan ettik



soyut

yöntemler, uygulaması olmayan yöntemlerdir, bu yüzden

burada biz  bir çizim yöntemimiz var ama

bir UI kontrolünün nasıl çizileceğini bilmiyoruz,

çizim algoritması

UI kontrolünün türüne bağlı olacaktır, bu yüzden

iki özel UI kontrolü oluşturduk, bunlardan

biri UI kontrolünü genişleten metin kutusu sınıfıydı

ve bu  şimdi ana sınıfımızda

bir metin kutusu çizme mantığını burada uyguluyoruz,



bunun gibi bir kodumuz vardı



, bir UI kontrolü alan ve basitçe UI kontrolü çizen statik bir yöntem ilan ettik.



Bu metoda ilettiğimiz nesnenin tipine bağlı olarak



uygulamamızın farklı

davrandığını çizen kontrolü çağırır, bu işlemdeki polimorfizmdir, bu yüzden eğer

metin kutusu sınıfının bir örneğine sahipse, biz olsak bile

metin kutusu sınıfının çizim yöntemi

çağrılır.  '

burada UI kontrol sınıfı ile çalışıyoruz, böylece bu

kontrol nesnesi birçok farklı form alabilir,



bu polimorfizmdir, işte

bu sınıfların UML diyagramı, yani ana sınıfımız



bu iki sınıfın ebeveyni veya temeli olan UI kontrolü ile konuşur

metin  UI kontrolünde kutu ve onay kutusu



Draw adında soyut bir yöntemimiz var ve bu

yöntemi alt sınıflarımızda uyguladık şimdi

aynı tekniği tuval sınıfımızdaki

çirkin if ve else ifadelerinden kurtulmak için kullanabiliriz,

işte tuval

sınıfımız  mevcut araç alanına ve bu iki yönteme sahip olmak,

bu yöntemlerin mevcut araca bağlı olarak farklı davranmasını istiyoruz, bu



nedenle araç adında yeni bir sınıf tanıtıyoruz,

bu b olacak  e bu

sınıftaki UI kontrolümüz gibi soyut bir sınıf,

iki

soyut yöntem bildireceğiz fareyi yukarı ve fareyi aşağı indir

, kullanıcı

fare düğmesini bıraktığında ne olacağı alt sınıflarda belirlenecek,

bu nedenle seçim ve fırça gibi yeni sınıflar tanıtacağız



.  bu sınıflar

, fare yukarı ve fare aşağı olayları için mantığı uygulayacağız

şimdi tuval sınıfımız

soyut araç sınıfıyla çalışacak,

belirli herhangi bir araçla ilgilenmiyor ancak bu özel araca

bağlı olarak farklı davranacak.

bunu

çalışma zamanında verin ve biz buna

durum kalıbı diyoruz çünkü durum kalıbı

, şimdi durum değiştiğinde bir nesnenin farklı davranmasına izin veriyor,

eğer



Dörtlü Çete kitabında veya

kurslarla ilgili diğer kitaplarda durum kalıbının klasik tanımına bakarsanız  farklı etiketler oturacaksınız,

böylece tuval yerine

bağlamımız var ve araç



yerine fare yukarı ve fare aşağı yöntemi yerine iki somut uygulama ile durumumuz var

s durum sınıfı tarafından ele alınan request yöntemine sahibiz, bu

yüzden

size daha önce de söylediğim gibi bu sadece soyut bir

kavramdır bu, sınıflarınızın bağlamını adlandırmanız gerektiği veya iki soyut olduğunu belirtmeniz gerektiği anlamına gelmez

,

her zaman

etki alanına uyan anlamlı adlar kullanın  Uygulamanızın bir

sonraki adımında size

bu durum modelini kodda nasıl uygulayacağınızı göstereceğim, bu

yüzden burada durum paketinde hadi

bu sınıfa yeni bir sınıf aracı ekleyelim, soyut yöntemlere ihtiyacımız var,

böylece genel soyut

fareyi aşağı ve fareyi yukarı kaldıralım çünkü

bu yöntemler soyuttur

, sınıfı da soyut olarak işaretlemeliyiz, şimdi

burada bir arabirim de kullanabiliriz

çünkü bir arabirim basitçe



bir sınıfın sağlaması gereken yetenekleri belirleyen bir sözleşmedir,

daha önce bir arabirimdeki metallerin olmadığını gördünüz

bir uygulamaya

sahipler, burada tam olarak bizim soyut yöntemlerimiz gibiler,

şimdi

bir arayüz ile soyut bir

sınıf arasındaki fark nedir, ikisi de soyut

kavramlardır, somutlaştıramayız  em

, bu araç sınıfının veya araç arayüzünün yeni bir örneğini oluşturamıyoruz, bu

nedenle

soyut oldukları ve

fazla kodları olmadığı için gevşek bağlı uygulamalar oluşturmamıza izin veriyorlar



, bazı ortak sağlamak istiyorsanız soyut bir sınıf kullanmayı tercih ediyoruz.



bu durumda

araçlarımıza herhangi bir ortak kod

sağlamıyoruz, bu yüzden bu soyut sınıfı

bu arayüzle değiştireceğim,

şimdi arayüzlerde genel arayüze bir göz atalım

, soyut anahtar kelimeye ihtiyacımız yok çünkü

bunlar  yöntemler varsayılan olarak soyut olarak kabul edilir,

bu nedenle soyut

anahtar sözcüğünü kaldırırız ayrıca bu yöntemler genel olarak

kabul edilir, bu nedenle

kodumuzu daha temiz yapan public anahtar sözcüğüne de ihtiyacımız yoktur, bu

nedenle bir kişi için bir arabirimimiz var

bir araç alalım şimdi

özel uygulayalım  araçlar,

buraya seçim aracı adında bir sınıf ekleyelim, buraya

uygularız aracı yazıyoruz, burada

aynı ada sahip iki arabirimimiz

olduğunu unutmayın, ilki az önce

oluşturduğumuz, ayrıca şurada da var

Java X paketindeki ool interface hiç merak etmeyin oluşturduğumuz

interface'i import edelim

tamam şimdi

bu interface'i uygulayalım ki alt' + enter'a basalım

ve bu yöntemleri uygulayalım ki seçim aracıyla

mantığı burada uygulamış oluyoruz

kullanıcı

fare düğmesine

bastığında simgeyi seçim simgesine değiştirmeliyiz

ve fare düğmesini bıraktıklarında

kesikli bir dikdörtgen çizmeliyiz tamam

şimdi bir sınıf daha ekleyelim bu

bizim fırça aracımız olacak fırça aracı

da uygular  burada tool interface

farklı bir mantığımız var, bu

yüzden kullanıcı fare düğmesine

bastığında fırça simgesini göstermeliyiz ve

fare düğmesini bıraktıklarında

bir çizgi çizmeliyiz şimdi

bunları tuval sınıfımıza nasıl dahil edebileceğimize

bakalım o yüzden açalım  tuval sınıfını önce

bu

alanın türünü araç türünden araca değiştirmeliyiz, bu yüzden

bir arayüze programlama yapıyoruz tamam

şimdi bir sürü derleme hatası var

, önemli değil  r

bu yöntemlerdeki tüm kodu sileceğiz, tüm bu iğrenç

iğrenç kodu, şimdi



aracı kullanacağımız araç türü yerine alıcımızın dönüş türünü değiştirmeliyiz

ve benzer şekilde ayarlayıcımız

için bir  tool nesnesi

şimdi mouse down metada

güzel, mevcut tool dot mouse

down olarak adlandıracağız ve benzer şekilde burada da şu anki

aracı dot mouse up olarak adlandıracağız, tek

yapmamız gereken bu kod güzel değil yani

canvas sınıfı sizin için delege

ediyor

kullanıcı

bu uygulama ile fare düğmesini işlediğinde veya serbest

bıraktığında ne olacağını belirlemek için özel bir araç, uzun bir

karar verme ifadeleri listemiz yok, bu nedenle

uygulamamız daha sürdürülebilir ve

ayrıca kolayca genişletebiliriz size göstermeme izin verin

şu anda sadece iki

tür aracımız var bir seçim aracı ve bir fırça

aracı bunu kullanalım ve sonra

size bu uygulamayı

yeni bir aracı destekleyecek şekilde nasıl genişleteceğinizi göstereceğim, bu yüzden

ilk önce ana sınıfımıza gidiyoruz bir tuval nesnesi oluşturuyoruz  o

Camus's şimdi şu anki araç setini ayarlıyoruz

şu anki aracı burada

araç arayüzünü uygulayan bir nesneyi geçmeliyiz,

böylece bir seçim aracını geçebiliriz,

sonra fareyi aşağı çağırırız ve son olarak

fareyi yukarı çağırırız, bakalım ne olacak,

böylece simge

seçim ikonuna dönüşecektir.  ve sonra

güzel bir dikdörtgen çizeriz

brush tool sınıfının bir örneğini geçersek

farklı sonuç alırız orda

şimdi diyelim ki yarın

yeni bir aracı destekleyeceğiz gerçekten çok kolay

tek yapmamız gereken yeni bir tane eklemek

araç arayüzünü uygulayan sınıfa

bir göz atın, burada yeni bir sınıf ekleyeceğim,

diyelim ki silgi aracı bu

sınıfa sahipsiniz, araç arayüzünü uyguluyoruz

ve burada mantığımızı uyguluyoruz, bu yüzden

simgenizi silin ve burada bir şeyi silin

şimdi geri dönüyoruz  ana sınıfımıza ve

basitçe silgi aracı sınıfının yeni bir örneğini geçirin

bir göz atın farklı

sonuçlar alıyoruz ve bu bizi

nesne yönelimli programlamada çok önemli bir ilkeye getiriyor

açık-kapalı ilkesi

temel olan  ly, sınıflarımızın

genişlemeye açık, ancak değişiklik için kapalı olması gerektiği anlamına gelir,

bu

yüzden sınıflarımızda kodu değiştirmemize izin verilmiyor,

sadece şimdi bu ilke ile genişletebiliriz



, mevcut kodu değiştirmeden yeni işlevler ekleyebiliriz

yeni işlevleri destekleyebiliriz

şimdi yeni sınıflar ekleyerek bu neden önemli ki

kaç kez

kendinizi bir sınıftaki kodu değiştirirken

ve ardından

uygulamanızı bozarken buldunuz açık kapalı ilkesi

böyle durumları her

yeni bir özelliği desteklemek istediğimizde

önleriz sadece yenilerini ekleriz  sınıflar ve biz bu gözlükleri test ediyoruz

tamam bu yüzden bu ilkeyi takip

etmek uygulamalarımızı genişletilebilir ve

sağlam kılar eğer bu konsept

sizin için yeniyse endişelenmeyin kursun ilerleyen bölümlerinde bununla ilgili daha fazla örnek göreceksiniz bu



yüzden tasarım planlayıcılar harika bize yardımcı

oluyorlar  bakımı yapılabilir, genişletilebilir ve

yeniden kullanılabilir nesneler oluşturun, ancak

bazen kötüye kullanılırlar işte bir örnek:

bu adam burada, adı John

Smith.  Oldukça kibirli bir

geliştirici muhtemelen onu diğer kurslarımda görmüşsünüzdür,

yakın zamanda tasarım kalıpları hakkında öğrendi

ve

bu kalıpları uygulamak için mevcut bazı kodları yeniden düzenlemeye başladı, şimdi

iş arkadaşlarından daha üstün

hissediyor, sırf bu tarihi öğrendiği için kendini süperstar bir geliştirici gibi hissediyor



kalıp ve onu kodda uyguladım, buna

kalıpları kötüye kullanma diyorum, bunu hatırla

her kalıbın bir bağlamı

vardır, belirli bir sorunu çözmek için oradadır ve

bu yüzden bu kursta sorun odaklı bir

yaklaşım benimsedim, böylece ne

zaman ve nasıl yapılacağını öğrenip anlarsınız  bu kalıpları uygulayın,

eğer bu

kalıpları kodunuza körü körüne uygularsanız,

karmaşıklığı artıracaksınız çünkü

daha fazla hareketli parçaya sahip olacaksınız, bu yüzden

sadece sorunu çözmediniz, aynı

zamanda yeni bir problem

yarattınız, ne yarattınız  Uygulamanızda tasarım kokusu diyoruz



, bu aşırı karmaşık bir tasarıma sahip bir uygulama, bazı

insanlar buna aşırı mühendislik

diyor. Kullanmayı sevmiyorum.  terimde, çünkü gerçek bir

mühendis her zaman önce bir sorunu anlamaya çalışır

ve sonra

çeşitli çözümler düşünür

ve soruna en uygun





olanı seçer.  Leonardo da Vinci'nin dediği



gibi, çözmeye çalıştıkları sorunu anlamadan doğru kodu suçlayacaklar, çünkü

basitlik

nihai gelişmişliktir,

bu yüzden işleri basit ve pragmatik tutun



, bir

sonraki çözmeye çalıştığınız sorunu anlamadan bu tasarım modellerini körü körüne uygulamayın  Size



durum düzenini kötüye kullanmanın gerçek bir örneğini göstereceğim, pekâlâ, durum



düzeninin nasıl kolayca kötüye kullanılabileceğini göstermeme izin verin, diyelim

ki bu uygulamada bir kronometre

uygulaması uygulamak istiyorsunuz, bir tıklama yöntemiyle bir kronometre sınıfına ihtiyacımız var

.  tıklıyoruz

ya saymaya başlıyor ya da duruyor yani

durum paketimize bir alt

paket

ekleyelim şimdi buna suistimal diyeceğim bu pakete bir

stop watch adında yeni sınıf burada

şimdi bu nesnenin durumuna bağlı olarak tıklama yöntemine ihtiyacımız

var

farklı şeyler yapmalıyız

durumu iki durumlu bir enum ile temsil edebiliriz veya

bir boole kullanabiliriz bence bir boole daha

kolay o yüzden gidelim  bir boolean ile,

özel boolean şimdi çalışıyor

, kronometreyi tıkladığımızda çalışıyorsa,

o zaman durduracağız, bu yüzden

çalışmayı false olarak ayarladık ve sonra yazdırmayı

durdurduk, aksi takdirde

çalışmayı doğru olarak ayarlayacağız ve ardından çalışan yazdıracağız

bu noktadan sonra uygulamamızı test edelim, bu

yüzden ana sınıfta bir

kronometre oluşturuyoruz ve

ardından başlangıçta tıklatıyoruz,

bu uygulamayı çalıştırdığımızda çalışan mesajını görmeliyiz,



şimdi bir kez daha tıklarsanız güzel gidiyorsunuz

iki tane görüyoruz.  mesajlar

çalışıyor ve sonra bir

kez daha tıklarsak

durur, koşmanın güzelce durduğunu görürüz

, bu yüzden bu çok basit ve basit bir

uygulamadır, şimdi John Smith

bu kodu alıyor ve ofiste oturuyor  ce ve

o, tıklama yönteminin kronometrenin durumuna

bağlı olarak farklı davrandığını düşünüyor

, bu nedenle

durum deseni için durum

bu, önce bu kodu bu şekilde yeniden değerlendirecek

, yeni bir sınıf veya durum adında bir arabirim oluşturacak,





bu yüzden ihtiyacımız var  burada bir arabirim, bu

arabirimde bir yöntem

tıklaması olacak ve bu arabirimi uygulayan iki sınıfınız olacak,

böylece John

iki sınıf ekler, bunlardan biri durdurulmuş

durumda, diğeri çalışır durumda durumda çalışır

durumda şimdi bu gözlüklerin her ikisi

de durumu uygulamalıdır  arayüz, eğer

kronometre çalışıyorsa, onu durdurmalıyız

ve sonra bir mesaj yazdırmalıyız, ancak

bu kronometreyi nasıl durduracağız

, burada kronometre nesnesine erişimimiz yok,

bir kurucu ekleyebiliriz,

böylece halka açık çalışma durumu

veririz  bu yapıcı,

kronometre türünde bir parametredir ve ardından bir alanda saklar,



böylece burada özel bir alan ilan ederiz

özel kronometre,

ona kronometre adını veririz ve

onu konstrüksiyonda başlatırız.  bu durumda kronometre

eşittir kronometre şimdi tıklama

yönteminde kronometrenin durumunu değiştirmeliyiz,

bu nedenle önce bu nesnenin



mevcut durumunu saklamak için kronometre sınıfına bir alan dışı gitmeliyiz,

böylece artık bu alanda değiliz





Şimdi mevcut durum adında özel bir durum türü ilan edelim şimdi

bu alan için bir alıcı ve ayarlayıcı üretelim,

bu çok kolay, orada yukarı çıkıyorsunuz,

bu yüzden

tıklama yöntemini çağırdığımızda çalışan Duruma geri dönüyoruz

, kronometrenin durumunu değiştirmeliyiz  bu yüzden

bu durumu ayarlayan kronometre diyoruz

ve burada durmuş durum olan bir sonraki tarihi

geçiyoruz yani yeni durdurulmuş Durum

şimdi burada bir derleme hatası var

çünkü bu sınıf durum arayüzünü uygulamıyor bu

yüzden onu gerçekten

hızlı bir şekilde ekleyelim durumu tamamlar

çalışan State sınıfında arkada

sorun güzelleşti, bu yüzden

durumu değiştiriyoruz ve ardından şimdi durdu diyen bir mesaj yazdırıyoruz



, durdurulan durum sınıfında benzer bir yaklaşıma ihtiyacımız var, bu yüzden

burada genelliyoruz  te a yapıcı Mac'teyseniz

size bir kısayol göstereceğim,

komut + n Windows kullanıyorsanız

ctrl + n tuşlarına basın bununla

, oluşturma paletini getirebilir ve bir

kurucu oluşturabiliriz şimdi buraya ekleyebiliriz

kronometre olan bir parametre

ve aynı zamanda özel bir alan oluşturabilir ve başlatabiliriz, böylece



havucu parametre adının üzerine koyarız alt'

+ enter' tuşlarına basın ve parametre kronometresi için alan oluştur'u seçin,

işte oraya gidiyorsunuz, böylece

özel bir alanımız var ve  bu alan

burada başlatıldı güzel

şimdi tıklama yönteminde kronometrenin durumunu değiştirmeliyiz bu yüzden



kronometreyi çağırmalıyız bu şu anki durum

durmuşsa onu

çalışır duruma ayarlamalıyız yani yeni çalışma durumu şimdi

buraya bir referans geçmeliyiz



bu sınıfta sahip olduğumuz kronometre alanı olan kronometreye tamam o zaman

hazır tamam diyen bir mesaj yazdırıyoruz şimdi

bir derleme hatası ve çalışma

durumu sınıfımız var çünkü

kronometrenin durumunu değiştirmeye çalıştığımızda  e

stop state sınıfının yeni bir örneğini geçerken,

stop state sınıfının yapıcısı

bir kronometre nesnesi bekliyor, bu

yüzden bu nesneyi buraya aktarıyoruz, bu

yüzden sınıfları ve

son kısmı belirtmeniz gerekiyor ve kronometreye gidip

bu uygulamayı şununla değiştiriyorsunuz.  mevcut

durum nokta tıklaması, bu yüzden

kronometreyi durum nesnesine tıklama görevini devrediyoruz

ve bu arada başlangıçta

bunu durmuş duruma ayarlamalıyız, bu yüzden

Neil durma durumu şimdi burada

bir kronometre nesnesine bir referans

iletmeliyiz.  bu mevcut nesneyi temsil ediyor olsun,

şimdi yaptığımız

ana yönteme geri döndük, bu yüzden dahili

olarak kronometrenin uygulamasını değiştirdik ama

aynı şeyi yapıyor programı çalıştıralım



öncekiyle aynı sonucu görüyoruz

güzel ancak

bu uygulama yol  daha önce

sahip olduğumuz bir tırnak ifadesinden daha karmaşıktır, bu

yüzden birkaç kararınız varsa

bile else veya Sushant vaka ifadelerinde kesinlikle yanlış bir şey



yoktur.  iyon oluşturma

dallarını kronometre sınıfında yaptığımız gibi tek bir yöntemle



tek bir yerde bu karar verme ifadeleri

vardı bu uygulamada kesinlikle yanlış bir şey yok

ama

tuval sınıfımızda önceki örneğimizde bu

karar verme ifadeleri vardı

fare aşağı ve fare op

yöntemlerinde birden fazla yerde ve daha da önemlisi,

yeni bir aracı desteklemek istiyorsanız

, kodumuzun farklı bölümlerini değiştirmek zorunda kaldık,

bu kodu yeniden düzenlememizin nedeni

bu yapıyı değiştiriyor ve bu

durum modelini kullanıyoruz.  kronometredeki kontrast,

tüm bu karar vermenin

tek bir yerde olduğunu biliyoruz ve bu

Dulwich'in gelecekte yeni bir duruma sahip olmayacağını



biliyoruz, ya durduruldu ya

da bu kadar basit bir şekilde çalışıyor, bu yüzden burada bir

sürdürülebilirlik sorunumuz yok

genişletilebilirlik sorunumuz yok,

bu kodu yeniden düzenlemeyi bitirdik,

bunu sorunsuz bir şekilde yapmadım, ancak

bu kodu herhangi bir fayda elde etmeden aşırı derecede karmaşık hale getirdi

şimdi daha fazlasına sahibiz

hareketli

parçalar bir arayüzümüz ve iki

uygulamamız var ve mantığımız bunun aksine

bu iki farklı sınıfa yayılıyor

ve önceki uygulamada

tüm bu mantık tek

bir yerdeydi yani işte sonuç

şu ki tasarım kalıplarını kötüye kullanmayın

Bunu tamamladığınız için tebrikler

Daha önce size söylediğim gibi YouTube öğreticisi,

bu video

nihai tasarım desenleri kursumun ilk saati,

daha fazla bilgi edinmek istiyorsanız, yirmi diğer tasarım deseninden

bahsettiğimiz kursuma kaydolmanızı şiddetle tavsiye ediyorum,



bunlar her insanın temel tasarım desenleridir.

yazılım mühendisi ilk 200'de ustalaşmalı,



büyük bir indirimle kursu alabilir, bu yüzden eğer

ilgileniyorsanız ve şimdi bu

teklif sona ermeden önce bu videonun altındaki bağlantıyı bulabilirsiniz,

teşekkür ederim ve

harika bir gün geçirin

[Müzik]



