using DevExpress.XtraEditors;
using NetSatis.BackOffice.Stok;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.BackOffice.İndirim
{
    public partial class FrmIndirimIslem : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        IndirimDAL indirimDal = new IndirimDAL();
        public FrmIndirimIslem()
        {
            InitializeComponent();
            gridcontIndirimler.DataSource = context.Indirimler.Local.ToBindingList();
        }

        private Indirim StokEkle(Entities.Tables.Stok entity)
        {
            Indirim _entity = new Indirim();
            _entity.StokKodu = entity.StokKodu;
            _entity.Barkod = entity.Barkod;
            _entity.StokAdi = entity.StokAdi;
            return _entity;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec(true);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemStok in form.secilen)
                {
                    Indirim _entity = new Indirim();
                    _entity = StokEkle(itemStok);
                    var count = context.Indirimler.Count(c => c.StokKodu == itemStok.StokKodu);
                    if (count != 0)
                    {
                        if (MessageBox.Show("Bu ürüne ait bir indirim zaten var, İndirimi Güncellemek ister misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            var secilenId = context.Indirimler.SingleOrDefault(c => c.StokKodu == itemStok.StokKodu);
                            _entity.Id = secilenId.Id;
                            indirimDal.AddOrUpdate(context, _entity);
                        }
                    }
                    else
                    {
                        indirimDal.AddOrUpdate(context, _entity);
                    }
                }
            }
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            foreach (var itemIndirim in context.Indirimler.Local.ToList())
            {
                itemIndirim.Durumu = true;
                itemIndirim.Aciklama = txtAciklama.Text;
                if (btnSuresiz.Checked)
                {
                    itemIndirim.IndirimTuru = "Süresiz";
                }
                else
                {
                    itemIndirim.BaslangicTarihi = dateBaslangic.DateTime;
                    itemIndirim.BitisTarihi = dateBitis.DateTime;
                    itemIndirim.IndirimTuru = "Tarih Arasında";
                }
            }
            indirimDal.Save(context);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Listeden Çıkarmak İstediğinize Emin misniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var secilenStokKodu = gridIndirimler.GetFocusedRowCellValue(colStokKodu).ToString();
                var result = indirimDal.GetByFilter(context, c => c.StokKodu == secilenStokKodu);
                context.Entry(result).State = EntityState.Detached;
            }
        }
    }
}