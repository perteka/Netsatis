using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Context;
using NetSatis.Entities.Interfaces;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Validations;

namespace NetSatis.Entities.Data_Access
{
    public class CariDAL : EntityRepositoryBase<NetSatisContext, Cari, CariValidator>
    {
        /*Carileri getirebileceğimiz nesne döndüreceğiz*/
        /*Fis ve Kasa hareket ortak group join*/
        public object GetCariler(NetSatisContext context)
        {
            /*group join bağlayacağımız tablo adı,bağlayacağımız kolon adı carilerin cari kodu,2.tablonun içinde alan onunda cari kodu
             daha sonra iki tabloya da isim vericez lamda işareti koyduktan sonra yeni bir tablo oluşturucaz*/
            var result = context.Cariler.GroupJoin(context.Fisler, c => c.CariKodu, c => c.CariKodu, (cariler, fisler) => new
            {
                cariler.Id,
                cariler.Durumu,
                cariler.CariKodu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.CepTelefonu,
                cariler.Telefon,
                cariler.Fax,
                cariler.EMail,
                cariler.Web,
                cariler.Il,
                cariler.Ilce,
                cariler.Semt,
                cariler.Adres,
                cariler.CariGrubu,
                cariler.CariAltGrubu,
                cariler.OzelKod1,
                cariler.OzelKod2,
                cariler.OzelKod3,
                cariler.OzelKod4,
                cariler.VergiNo,
                cariler.VergiDairesi,
                cariler.IskontoOrani,
                cariler.RiskLimiti,
                cariler.AlisOzelFiyati,
                cariler.SatisOzelFiyati,
                cariler.Aciklama,
                /*Fişler tablosuna git,fis türü alış fişi olanları topla,hangi alanı toplayacak toplam tutar alanını
                 boş dönme ihtimaline karşı değilse 0 döndür*/
                AlisToplam = fisler.Where(c => c.FisTuru == "Alış Faturası").Sum(c => c.ToplamTutar) ?? 0,
                SatisToplam = fisler.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0,
                /*Git satış fişi olanları al,satış fişi olanları listele,toplam tutar alanını satış fişi olanalr için topla */
                /*Burda yeni tablo oluştu,bu taployu artık yeni grup joine bağlayacağım*/
                /*hangi tabloyu bağlayacağım bu sefer kasa hareketlerini bağlayacağım */
            }).GroupJoin(context.KasaHareketleri, c => c.CariKodu, c => c.CariKodu, (cariler, kasahareket) => new
            {
                cariler.Id,
                cariler.Durumu,
                cariler.CariKodu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.CepTelefonu,
                cariler.Telefon,
                cariler.Fax,
                cariler.EMail,
                cariler.Web,
                cariler.Il,
                cariler.Ilce,
                cariler.Semt,
                cariler.Adres,
                cariler.CariGrubu,
                cariler.CariAltGrubu,
                cariler.OzelKod1,
                cariler.OzelKod2,
                cariler.OzelKod3,
                cariler.OzelKod4,
                cariler.VergiNo,
                cariler.VergiDairesi,
                cariler.IskontoOrani,
                cariler.RiskLimiti,
                cariler.AlisOzelFiyati,
                cariler.SatisOzelFiyati,
                cariler.Aciklama,
                Alacak = cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                Borc = cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                Bakiye = (cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0)) - (cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0))
            }).ToList();
            return result;
        }
    }
}
