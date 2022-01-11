# Veritabanı Yönetim Sistemleri

## İlişkisel ve NoSql Veritabanları
- SQL(Structured Query Language)
- Data Consistency
    - MySql(Ücretsiz)
    - PostgreSql (Ücretsiz)
    - MysSql
    - IBM DB2
    - Oracle

### RDMS (Relational Database Management System) - İlişkisel VeriTabanı Yönetim Sistemleri

İlişkisel Veri Tabanları veriyi birbiri ile ilişkili bir şekilde tutmaya yarar. Tablolar aracılığıyla veriler hem kendi içlerinde hem tablolar arasında ilişkili bir şekilde saklanır. Tablolar satırlar ve sütunlardan oluşur. Bu satır ve sütunlar verileri daha anlamlı tutmamızı ve okumamızı sağlar.

Uzun bir paragraf ile yazılmış karşılaştırma makalelerini düşünün. Bir de onu özetleyen karşılaştırmalı bir tablo düşününün. Mantıksal olarak veriler yanyana koyulmuş ve neye göre bir karşılaştırma yapılacağı çok açıktır. Tabloya kısa bir göz attığınızda verilmek istenen mesajı çok rahat olarak alabilirsiniz. İlişkisel veritabanı da insana aynı hissi verir :)

İlişkisel veri tabanı yönetim sistemleri ise, veritabanı oluşturma, verileri yönetme ve saklama gibi işlemleri kolayca yapmanıza olanak sağlayan yazılımlardır. Çoğu veri tabanına erişim için SQL(Structured Query Language) kullanılır.

Veriler tablolarda birbiri ile ilişkili şekilde saklanırken tablolar arasında da ilişkiler olabileceğinden bahsettik. Bu tablolar arası ilişki bize Data Consistency yani veri tutarlılığını sağlar. Dolayısıyla bu ilişkilerin doğru kurulması oldukça kritiktir.

<u>Bazı popüler veri tabanları:</u>

    - MySql (Ücretsiz)
    - PostgreSQL (Ücretsiz)
    - MsSql
    - IBM DB2
    - Oracle

Bu veri tabanlarında kullanılan diller de kendi aralarından değişiklik gösterebiliyor. Örneğin MsSQL ile TSQL dilini kullanırken, Oracle ile PLSQL dilini kullanırız. Birbirinden çok büyük farklar olmasa da kendilerine özel dil yapı farkları vardır.

NoSql - İlişkisel Olmayan Veri Tabanı Yönetim Sistemleri

İlişkisel veri tabanı yönetim sistemlerinin doğuşu bundan 40 sene öncesine dayanır. Yıllar içerisinde olgunluk seviyesi çok artmıştır. Ama günümüzde bile hala büyük verileri saklama ve işleme konusunda yetersiz kalmaktadır. Tam da bu noktada yaşanan sıkıntılara karşılık NoSql veritabanları 1998 yılında ortaya çıkmıştır.

NoSql Veritabanları yüksek trafik ile yüksek miktarda verinin yönetimine odaklandı. Immediate Data Consistency yani anlık veri tutarlılığından feragat ederek, yüksek performansa ve hıza odaklandı.

İlişkisel veri tabanlarındaki Immediate Data Consistency burda yerini Eventual Data Consistency yani nihai veri tutarlılığına bırakır.

NoSQl veritabanlarında CAP Teorimi denen önemli bir teorem vardır.

Aşağıdaki görsel CAP Teoremini çok iyi açıklıyor.

- Cap Teoremi
    - Consistency // Verilerin tutarlılığı
    - Availability // Sisteme yapılan her isteğin yanıt alabilmesi durumu
    - Partition Tolerance // Mevcut modlardan bir kısmında network veya başka bir sebepten ötürü sorun olduğunda sistemin çalışabilmesine devam edebilmesi durumu

![ortak yanları](https://raw.githubusercontent.com/devrimmehmet/Patika.Dev/master/Orta%20Seviye%20.Net%20Core%20Patikas%C4%B1/.Net%20Core/Veritaban%C4%B1%20Y%C3%B6netim%20Sistemleri/ref-property-in-dbtable.png)

Bu görsel bize der ki; NoSql veri tabanı olarak Strong Consistency, Availability ve Partitioning kavramlarını aynı anda garanti edemem.

Bazı Popüler NoSql Veri Tabanları ve Özellikleri

- Document Based (MongoDB - CouchDB)
- Key/Value(Redis)
- Graph Based (Neo4J)
- Column Based (Cassandra, HBase)

![farklar](https://raw.githubusercontent.com/devrimmehmet/Patika.Dev/master/Orta%20Seviye%20.Net%20Core%20Patikas%C4%B1/.Net%20Core/Veritaban%C4%B1%20Y%C3%B6netim%20Sistemleri/2.png)

Okuma Önerisi: Veri tabanı yönetim sistemleri ile ilgili daha detay bilgiye sahip olmak için lütfen [tıklayınız.](https://medium.com/devopsturkiye/microservice-mimarilerde-veritaban%C4%B1-tasar%C4%B1m%C4%B1-d58371ec466)

---
---
---

## Table, Primary Key, Foreign Key Kavramları
### Primary Key (Birincil Anahtar)

Adından da anlaşılacağı üzere anahtar veridir. Tabloda her satır veriden sorumlu bir tane anahtar veri vardır. Bu her satır için aynı veridir. Dolayısısyla primary Key bilgisi kolona verilir. Primary key olarak işaretlenen veri tekil olmak zorundadır. Bir tabloda sadece bir kez bulunabilir. Aksi durumda veri tabanı hata fırlatır. Primary key tek bir kolon olabileceği gibi birden fazla kolonun birleşimi de olabilir.

Örneğin bir personel tablosu için Sicil Numarası bir primary keydir.

Kısaca **PK** olarak görebilirsiniz.

### Foreign Key (İkincil Anahtar)

Foreign Key tablo tasarlarken Primary Key kadar önemlidir. İlişkisel veritabanlarında data consistency foreign key'ler yardımıyla yapılır. Hem veri tekrarınını hem de tablolarda boş durumda olan kirli verilerin oluşmasını engellemek için kullanılır. Örneğin Product tablonuz ve ProductDetail tablonuz olsun. ProductDetail tablonuzda ilişkisi olan bir product'ı Product tablosundan silmeye calısıyorsunuz. Eğer ilişkiler doğru kurulduysa, veritabanı buna izin vermez. Ama arada Foreign Key ilişkisi kurulmamışsa, siz o product'ı silebilirsiniz. ProductDetail tablosundaysa Product tablosunda karşılığını olmayan bir kayıt kalır. Bu istenmeyen bir durumdur.

Kısaca **FK** olarak görebilirsiniz.

---

Okuma Önerisi: Database indexler ile ilgili bilgi sahibi olmak için [tıklayınız.](https://medium.com/trendyol-tech/sql-server-index-yap%C4%B1s%C4%B1-aba652828fe2)

---
---
---

## Tablo İlişkileri

İlişkisel bir veritabanı ile çalışırken veriyi olabildiğince atomik tutmak ve çoklanmasının önüne geçmemiz gerekir. Böylece bir veriyi güncellediğimizde ilişkili tüm bilgileri de güncellemiş ve veri bütünlüğünü sağlamış oluruz. Bunu sağlayabilmemiz için de tablolar arasında doğru ilişkileri kurmamız gereklidir. Dataları konumlandıracağımız tablolar, içerdikleri alanlar ve tablolar arası ilişkilerin tasarımı sürecine normalizasyon adı verilir.

Temel olarak 3 tip tablo ilişkisi bulunmaktadır.

### 1-1 İlişki

Bu ilişki tipinde tablolar arasında 1-1 bir ilişki bulunmaktadır. Genel olarak Temel Bilgi - Detay Bilgi şeklinde gruplanabilecek verileri 2 farklı tabloda konumlandırdığımızı ve ilişkilendirdiğimizi düşünebilirsiniz. 1-1 ilişkide temel olarak A tablosundaki PK, B tablosunda da PK'dır. Bu durumda B tablosunun PK'si aynı zamanda A tablosundaki PK ya işaret eden bir FK'dır.

Örnek verecek olursak; Books tablosunda bir kitap ile ilgili temel bilgilerin varolduğunu düşünelim. Kitaba ait daha fazla detay bilgiyi ise BookDetails tablosunda tuttuğumuzu düşünelim. Bu durumda kitap-kitap detayı için 1-1 ilişki mevcut denebilir. İlişkinin örnek görseli ise aşağıdaki gibi olacaktır.

Bu ilişkiye sahip bir veriyi aslında her iki tablonun kolonlarına sahip tek bir tablo içerisinde tutuluyor gibi düşünebiliriz. Bu nedenle bu ilişki tipine çok da sık rastlamayabilirsiniz. Uygulamamızın duyduğu ihtiyaca göre bu şekilde bir 1-1 ilişki kurup kurmama kararı vermemiz gerekebilir.

![1-1 Relation](https://raw.githubusercontent.com/devrimmehmet/Patika.Dev/master/Orta%20Seviye%20.Net%20Core%20Patikas%C4%B1/.Net%20Core/Veritaban%C4%B1%20Y%C3%B6netim%20Sistemleri/1-1-relation.png)


#### 1-N İlişki

Bu ilişki tipinde tablolar arasında 1-N bir ilişki bulunmaktadır. Temel olarak A tablosundaki PK'nın, B tablosunda bir FK karşılığı vardır. Fakat B tablosunun kendine ait ayrı bir PK tanımı vardır.

Örnek verecek olursak; Books tablosunda bir kitabın temel bilgilerini tuttuğumuzu düşünelim. Kitaba ait her bir baskıyla ilgili bilgileri ise BookEditions tablosunda tuttuğumuzu düşünelim. Bu durumda kitap-kitap baskısı için 1-N ilişiki mevcut diyebiliriz. İlişkinin örnek görseli ise aşağıdaki gibi olacaktır.

1-N ilişki en çok kullanılan ilişki tiplerinden birisidir. Günümüzde farkında olmadan sıkça kullandığımız 1-N ilişki türlerini aşağıda bulabilirsiniz :)

    - User -> Posts
    - Post -> Comments/Reactions
    - User -> PaymentMethods
    - User -> Addresses

![1-N Relation](https://raw.githubusercontent.com/devrimmehmet/Patika.Dev/master/Orta%20Seviye%20.Net%20Core%20Patikas%C4%B1/.Net%20Core/Veritaban%C4%B1%20Y%C3%B6netim%20Sistemleri/1-n-relation.png)

### N-N İlişki

Bu ilişki tipinde tablolar arasında N-N bir ilişki bulunmaktadır. Bu ilişkiyi 2 tablo arasında kurabilmek için 3. bir tabloya ihtiyacımız bulunmaktadır. Temel olarak A tablosundaki PK ile B tablosundaki PK'yı barındıran C tablosu üzerinden bu ilişki kurulur. C tablosunda hem A hem de B tablosuna işaret eden FK'lar vardır.

Books örneğimiz üzerinden devam edecek olursak; bir kitabın birden fazla yazarı olabileceği gibi, aynı yazar yada yazarların da birden fazla kitap yazabileceğini düşündüğümüzde yazar bilgisini direkt olarak Books tablosu ile ilişkilendirmemiz doğru olmayacaktır. Bu durumda yazar bilgileri için de Authors adında bir tablomuz olmalı ve kitap(lar)-yazar(lar) bilgisi için BookAuthors gibi ayrı bir tablo oluşturmamız gerekir. BookAuthors tablosu sayesinde kitap-yazar arasında N-N ilişkiyi sağlamış oluruz. İlişkinin örnek görseli ise aşağıdaki gibi olacaktır.

![N-N](https://raw.githubusercontent.com/devrimmehmet/Patika.Dev/master/Orta%20Seviye%20.Net%20Core%20Patikas%C4%B1/.Net%20Core/Veritaban%C4%B1%20Y%C3%B6netim%20Sistemleri/n-n-relation.png)

