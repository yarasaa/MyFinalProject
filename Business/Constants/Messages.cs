using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MainTenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string UnitPriceInvalid = "Fiyat sıfırdan az olamaz";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla on ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün var";
        public static string CategoryLimitExceded = "KAtegori Limiti aşıldığı için ürün eklenemiyor";
    }
}
