# UnluCo .net Bitirme Projesi
--------------------------------------------------------------------



* Web Api 
  
* Projemde Generic Repository Pattern ve UnitOfWork Pattern Kullandım.

* Giriş yapma ve kayıt olma işlemlerini UserControllerda yapıyorum. Kullanıcıdan kayıt işlemlerinde alınan bilgiler eksiksiz bir şekilde alınmakta rules sınıfımızı kullanarak user bilgilerini kontrol ediyorum. İstendiği şekilde ise Kayıt işlemi gerçekleşiyor ve kullanıcının girmiş olduğu maile hoşgeldiniz maili gönderiliyor Mail işlemi için EmailSender sınıfım mevcut bu sınıf sayesinde smtp kullanarak girilen mail adresine mesaj gönderme işlemlerini gerçekleştirebiliyorum. Eğer kullanıcının girmiş olduğu bilgiler kurallara uymuyorsa o zaman Tanımladığın Responsa'ta ona göre status code 500 ve kurallara uymadığı için kayıt yapılamadı mesajını gönderiyorum.

* Üye Girişi için verilen bilgiler mevcut mu diye öncelikle veri tabanında kontrol ediyorum eğer mevcut ise ona göre bir access token ve refresh token üretiyorum . Bu üretme işlemlerini Busines katmanındaki UserService sınıfımda gerçekleştiriyorum.Requestlerin header'ına ekleme işlemini ise blazor tarafında gerçekleştiriyorum kişi başarılı giriş yaptığında dönen acces tokeni ve refresh tokenı local storage'e kayıt ediyorum sonrasında diğer authorize gerektiren alanlarda local storage'da token mevcut mu diye kontrol ediyorum logout işlemi yapıldığında localstorage'dan bu tokenlerı silerek authorize işlemlerini yapıyorum. Aynı zamanda veri tabanında her kullanıcı için failedlogin değeri tutuyorum her başarısız girişte bu değer artıyor veri tabanına yazdığım trigger sayesinde bu değer 3 olduğunda kullanıcı pasif duruma çekilip kullanıcıya bu konu ile ilgili mail atıyorum.

* Email gönderme konusunda Emailsender sınıfımı kullanarak bu işlemi gerçekleştiriyorum içerisinde 2 tane method mevcut bir hoşgeldiniz methodu her kayıtta kullanıcının emailine gönderilen bir'de emaili konuyu ve içeriği kendim girdiğim bir method mevcut bloke durumunda gönderilen maili bunu kullanarak gerçekledim.

* kategori işlemleri için kategori kontroller'ım mevcut istenilen Tüm kategorileri listeleme seçilen kategoriye göre ürünleri listeleme işlemlerini bu controller'dan gerçekleştiriyorum . Default olarak tüm ürünler çekme konusunda bu controller yerine productcontroller'ı kullanırken kullandığım ProductService sınıfını kullanıyorum. Tüm ürünleri çekme konusu kategori ile pek ilgili olmadığı için CategoryService içerisine bu methodu ekleyerek Kafa karışıklığına neden olmak istemedim. Yeni kategori ekleme ve güncelleme işlemleride CategoryService sınıfından yapıyorum.

* Offer Controller'da Teklif verme satın alma ve teklifi geri çekme işlemleri mevcut kullanıcı istediği bir ürüne teklif verebilmekte verdiği teklifi string olarak alıyorum başında % işareti varsa bunu %delik bir teklif olduğunu anlayıp veri tabanından o ürünün fiyatını çekip vermiş olduğu % delik teklife göre vermiş olduğu teklifi fiyata çevirip ona göre automap işlemlerini gerçekleştiriyorum . Her teklif'te teklif geçerlimi alanı var eğer kullanıcının teklifi kabul yada red görürse yada teklifini geri çekerse teklif geçersiz hale düşmekte teklifi geri çek'te zaten veri tabanındaki bu alanı pasif hale getirmekte eğer kullanıcı direk satın alırsa o zaman ürünün issold alanını aktif hale getirip bunu bir teklif olarak algılayıp pasif bir teklif olarak kaydediyorum.

* Hesabım alanı için bir controller yapmadım . Bunun yerine AccountService yazıp istenilen işlemleri bu service'te gerçekleştirdim. İstenilen tüm hesap methodları burada gerçekleştirildi.

* Ürün için yapmış olduğum ProductController mevcut bu controller sayesinde ekleme silme listeleme gibi işlemleri gerçekleştiriyorum.Kullanıcıdan aldığım ürün bilgilerinde resim alanını Ifile tipinde alıp ardından bunu byte dizisine çevirip veri tabanında saklıyorum . veri tabanında çektiğimde'de tekrar resime çeviriyorum. İstenildiği şekilde olabildiğince solid prensiblerine uygun Generic Repository pattern ve UnitOfWork patterni kullanarak gerçekleştirdim. Eksikleri mevcut ama umarım beğenirsiniz.


