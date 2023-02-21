GÖREVLER 

BÖLÜM A

1. TurkiyeBolgelerSehirler adında bir ASP.NET projesi oluştur.

2. https://github.com/yigith/Bloggie/blob/2115a16706d4d68e65e48f7071e6311e5b5f21a6/Bloggie/Helpers/UrlUtilities.cs adresindeki sınıfları projeye dahil et

3. Aşağıdaki modellere uygun entity framework dbcontext'ini oluştur
Bolge
int Id
strign Slug
string BolgeAd


Sehir
int Id
int BolgeId
string Slug
string SehirAd
int Nufus

* Bire Çok İlişki


4. https://github.com/yigith/TurkiyeSehirlerBolgeler/blob/master/csharp/bolgelersehirler.txt adresinden yararlanarak ve GEREKLİ EKLEMELERİ yaparak seed datasını oluştur.

SORU: Slug alanına ne gireceğiz?
Doğu Anadolu Bölgesi için dogu-anadolu-bolgesi
Iğdır için igdir
girilecek.. (Url Friendly Versiyonu yani)

5. Migration'ları yap ve veritabanını hazır hale getir.

BÖLÜM B

6. HomeController içinde BolgeBilgi adında bir action oluştur.

Bu action'a şu adresle ulaşılsın:

bolge/guneydogu-anadolu-bolgesi

Bu action bolge'nin slug'ını alabilmeli ve ilgili bölgenin şehirlerini
view içinde gösterebilmeli.

7. HomeController içinde SehirBilgi adında bir action oluştur.

Bu action'a şu adresle ulaşılsın:

sehir/igdir

Bu action şehrin slug'ını alabilmeli ve ilgili şehrin bilgilerini
view içinde gösterebilmeli.

8. Anasayfa (Home/Index) tüm bölgelerin adları liste halinde sunulmalı ve bir bölgeye 
tıklanırsa o bölgenin şehirlerini gösteren sayfaya gitsin

9. BolgeBilgi sayfasında altıncı adımda şehirleri listelemeniz istenmişti. Sadece
listelemekle kalmayın, aynı zamanda bir şehre tıklandığında o şehrin bilgilerini
gösteren sayfaya gitmesini sağlayın.



































