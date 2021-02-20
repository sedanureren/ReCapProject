using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Ürün eklendi.";
        public static string BrandAdded = "Brand eklendi.";
        public static string ColorAdded = "Color eklendi.";
        public static string CarDeleted = "Ürün silindi";
        public static string BrandDeleted = "Brand silindi";
        public static string ColorDeleted = "Color silindi";
        public static string CarUpdate = "Ürün güncellendi";
        public static string BrandUpdate = "Brand güncellendi";
        public static string ColorUpdate = "Color güncellendi";
        public static string CarNameInvalid = "Araba ismi min 2 karakter olmalıdır.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Ürünler listelendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string ColorsListed = "Renkler listelendi";
        public static string CarDailyPriceInvalid = "Araba ücreti 0 dan büyük bir sayı olmalıdır.";
        public static string BrandNameInvalid="Marka ismi min 2 karakter olmalıdır.";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserListed =" Kullanıcılar Listelendi";
        public static string ListedbyId ="Id ye Göre Listelendi";
        public static string RentalAdded ="Kiralama Kaydedildi";
        public static string ErrorRental ="Kiralamada hata oluştu";
        public static string RentalError = "Kiralamada hata oluştu";

        public static string RentalUpdate = "Kiralama güncellendi";
        public static string RentalListed = "Kiralamalar Listelendi";
    }
}
