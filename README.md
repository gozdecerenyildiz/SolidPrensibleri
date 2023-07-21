# SolidPrensibleri


**1.S ingle Responsibility Principle (Her sınıfın veya methodun tek bir amacı olmalı)SRP- Tek Sorumluluk İlkesi**

Projenin içerisindeki her bir yapı, diğer yapılara o kadar bağımlıdır ve yapılan işler o kadar iç içe geçmiştir ki; küçük bir değişikliğin neleri etkileyeceğini kestirmeniz çok zordur ve genelde böyle projeler çöp proje olarak görülür. İçerisindeki class’ları methodları alıp başka bir projede kullanamazsınız.*

**2.O pen / Closed Principle (OCP)- Açık/Kapalı İlkesi**

Açık kapalı prensibi, yazılım geliştirirken kullandığımız varlıkların (class, method vs.) gelişime açık, kodların ise değişime kapalı olması ilkesidir. Örneğin; bir loglama altyapısı oluşturduğunuzu düşünün, Veritabanına ve XML’e kayıt tutuyorsunuz. Daha sonradan Eventloglara da log tutma ihtiyacı hissettiğinizde, sadece Eventloglara kayıt tutan kodları yazmanız yetecek, kodunuzda hiçbir değişiklik yapmadan bu yapı sisteme entegre olacak.

**3.L iskov‘s Substitution Principle-Liskov'un İkame İlkesi**

Liskov’un yerine geçme prensibi alt sınıflardan oluşturulan nesnelerin üst sınıfların nesneleriyle yer değiştirdiklerinde aynı davranışı göstermek zorunda olduklarını söyler. Yani; türetilen sınıflar, türeyen sınıfların tüm özelliklerini kullanmak zorundadır. Eğer kullanmaz ise ortaya işlevsiz, dummy kodlar çıkacaktır. Bu durumda üst sınıfta if else blokları kullanarak tip kontrolü yapmamız gerekebilir ve böylelikle Açık Kapalı prensibine de ters düşmüş oluruz.
LSP’nin avantajı, aynı türdeki tüm alt sınıfların tutarlı bir kullanımı paylaştığı için yeni alt sınıfların geliştirilmesini hızlandırmasıdır. Yeni oluşturulan tüm alt sınıfların mevcut kodla çalışabilir. Yeni bir alt sınıfa ihtiyacınız olduğu zaman mevcut kodu yeniden çalışmadan oluşturabilmenize olanak sağlar.

**4.I nterface Segregation Principle- Arayüz Ayırma Prensibi**

Arayüz ayırım prensibi, bir arayüze gerektiğinden fazla yetenek eklemememiz gerektiği söyler.İsteme özel birçok arayüz, tek bir genel amaçlı arayüzden daha iyidir. ISP’de sınıflar kullanmadıkları davranışları içermesi istenmez. Aslında, bu durum ilk SOLID ilkemizle de ilgilidir. Çünkü, bu ilke programa doğrudan katkıda bulunmayan tüm değişkenleri, metotları veya davranışları bir sınıftan çıkarır. ISP ise metotların daha spesifik metotlara dönüştürülmesidir. Bu sayede,

*-Daha az kod taşıyan metotlar elde edilir. Kodun ihtiyaç durumunda güncellemesi hızlanır.*
*-Davranıştan bir metot sorumlu olduğu için davranışta karşılaşılan problem hızlı çözülür.*

**5.D ependency Inversion Principle-Bağımlılık Tersine Çevirme İlkesi**

Bağımlılığın ters çevirilmesi ilkesine göre üst seviye sınıflar, modüller, methodlar vs. alt seviyeli sınıflara bağımlı olmamalıdır. Alt sınıflarda yapılan değişiklikler üst sınıfları etkilememelidir.Abstraction (Soyutlama) konusu sınıf ve doğru özelliklerin sınıfa eklenmesi açısından Nesneye Yönelik Programlamanın en önemli konularından biridir. DIP iki kısma sahiptir:

*-Yüksek seviyeli modüller, düşük seviyeli modüllere bağlı olmamalıdır. Bunun yerine, her ikisi de soyutlamalara (Interface) bağlı olmalıdır.*
*-Soyutlamalar ayrıntılara bağlı olmamalıdır. Ayrıntılar (somut uygulamalar gibi) soyutlamalara bağlı olmalıdır.*

Yazılımcılar, konuyu parça parça öğrendikleri için sınıflarını yüklenirler. Bir anlamda yüksek seviyeli bileşenlere sahip programlar yazarlar. DIP ilkesinin amacı düşük ve yüksek seviyeli bileşenleri ayırıp her ikisini de soyutlamalara bağlamaktır. Bu durumda, yüksek ve düşük seviyeli bileşenler birbirinden yararlanabilir ama birindeki değişiklik doğrudan diğerini etkilememelidir. Konuyu bir örnek üzerinden inceleyelim.
