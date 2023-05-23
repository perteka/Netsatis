using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Data_Access
{
    public class OdemeTuruDAL : EntityRepositoryBase<NetSatisContext, OdemeTuru, OdemeTuruValidator>
    {
        public object OdemeTuruListele(NetSatisContext context)
        {
            var result = context.OdemeTurleri.GroupJoin(context.KasaHareketleri, c => c.OdemeTuruKodu, c => c.OdemeTuruKodu, (OdemeTuru, kasahareket) => new
            {
                OdemeTuru.Id,
                OdemeTuru.OdemeTuruKodu,
                OdemeTuru.OdemeTuruAdi,
                OdemeTuru.Aciklama,
                KasaGiris = (kasahareket.Where(c => c.OdemeTuruKodu == OdemeTuru.OdemeTuruKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                KasaCikis = (kasahareket.Where(c => c.OdemeTuruKodu == OdemeTuru.OdemeTuruKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                Bakiye = (kasahareket.Where(c => c.OdemeTuruKodu == OdemeTuru.OdemeTuruKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) -
                          (kasahareket.Where(c => c.OdemeTuruKodu == OdemeTuru.OdemeTuruKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
            }).ToList();
            return result;
        }

    }
}
