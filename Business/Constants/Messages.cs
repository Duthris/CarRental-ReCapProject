using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        // General
        public static string MaintenanceTime = "Şuanda bakımdayız :(\n";
        public static string Listed = "Başarıyla Listelendi.";
        public static string NotListed = "Listeleme başarısız!";

        // Car Messages
        public static string CarsListed = "Araçlar Listelendi.\n";
        public static string CarAdded = "Araç başarıyla eklendi.\n";
        public static string CarUpdated = "Araç başarıyla güncellendi.\n";
        public static string CarDeleted = "Araç başarıyla silindi.\n";
        public static string CarNameInvalid = "Araç adı geçersiz.\n";
        public static string DailyPriceError = "Aracın Günlük ücreti '0 TL' olamaz!\n";
        public static string ShortCarName = "Aracın Marka & Model adı uzunluğu minimum 2 karakterden oluşmalı!\n";

        // Rental Messages
        public static string RentalAdded = "Başarıyla kiralandı.";
        public static string RentalDeleted = "Kiralama iptal edildi.";
        public static string RentalUpdated = "Kiralama bilgileri güncellendi.";
        public static string RentalNameInvalid = "Geçersiz kiralama bilgileri!";
        public static string RentalsListed = "Kiralamalar Listelendi.\n";

        // Color Messages
        public static string ColorAdded = "Renk başarıyla eklendi.";
        public static string ColorDeleted = "Renk sistemden silindi.";
        public static string ColorUpdated = "Belirtilen renk güncellendi.";
        public static string ColorNameInvalid = "Geçersiz renk ismi!";
        public static string ColorsListed = "Renkler Listelendi.\n";

        // Brand Messages
        public static string BrandAdded = "Marka başarıyla eklendi.";
        public static string BrandDeleted = "Marka sistemden silindi";
        public static string BrandUpdated = "Belirtilen marka güncellendi.";
        public static string BrandNameInvalid = "Geçerisz marka ismi!";
        public static string BrandsListed = "Markalar Listelendi.\n";

        // User Messages
        public static string UserAdded = "Kullanıcı başarıyla eklendi.";
        public static string UserDeleted = "Kullanıcı sistemden silindi.";
        public static string UserUpdated = "Belirtilen kullanıcı güncellendi.";
        public static string UserNameInvalid = "Geçersiz kullanıcı adı!";
        public static string UsersListed = "Kullanıcılar Listelendi.\n";

        // Customer Messages
        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerDeleted = "Müşteri sistemden silindi.";
        public static string CustomerUpdated = "Belirtilen müşteri güncellendi..";
        public static string CustomerNameInvalid = "Geçersiz müşteri ismi!";
        public static string CustomersListed = "Müşteriler Listelendi.\n";

        // CarImage Messages
        public static string CarImageLimitExceeded = "Maksimum 6 resim yüklenebilir!";
        public static string CarImageAdded = "Araç resimleri başarıyla eklendi.";
        public static string CarImageDeleted = "Araç resimleri başarıyla silindi.";
        public static string CarImageUpdated = "Araç resimleri başarıyla güncellendi.";
        public static string CarImagesListed = "Araç resimleri listelendi.";

        // User - JWT - Auth. Messages
        public static string AuthorizationDenied = "Doğrulama Reddedildi. YETKİNİZ YOK!";
        public static string UserRegistered = "Başarıyla kayıt olundu!";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Geçersiz şifre!";
        public static string SuccessfulLogin = "Giriş başarılı!";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut!";
        public static string AccessTokenCreated = "Access Token Oluşturuldu.";

    }
}
