using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.BackOffice.YapaySinirAğıMaaşTahmin
{

    public partial class yapaysinirağı : DevExpress.XtraEditors.XtraForm
    {
        public yapaysinirağı()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtDeneyim.Text = "";
            txtBolum.Text = "";
            txtNitelik.Text = "";
            txtCocukSayisi.Text = "";
            txtMedeniDurum.Text = "";
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            double s1 = double.Parse(txtDeneyim.Text);
            double s2 = double.Parse(txtBolum.Text);
            double s3 = double.Parse(txtNitelik.Text);
            double s4 = double.Parse(txtCocukSayisi.Text);
            double s5 = double.Parse(txtMedeniDurum.Text);

            double G1 = 0.8 * ((s1 - 1) / (4 - 1)) + 0.1;
            double G2 = 0.8 * ((s2 - 12) / (17 - 12)) + 0.1;
            double G3 = 0.8 * ((s3 - 18) / (23 - 18)) + 0.1;
            double G4 = 0.8 * ((s4 - 5) / (7 - 5)) + 0.1;
            double G5 = 0.8 * ((s4 - 10) / (11 - 10)) + 0.1;

            double E1 = G1 * 2.0673 + G2 * 3.2061 + G3 * (-0.5862) + G4 * 1.1636 + G5 * (-1.5289) + (-4.1173);
            double E2 = G1 * 1.8284 + G2 * 2.1515 + G3 * 1.8464 + G4 * 1.2055 + G5 * (-2.1305) + (-3.1307);
            double E3 = G1 * (-1.9535) + G2 * (-1.6943) + G3 * 1.4225 + G4 * 1.6398 + G5 * (-2.1305) + 2.133;
            double E4 = G1 * 2.5168 + G2 * 2.2673 + G3 * (-0.14768) + G4 * (-0.12317) + G5 * (-0.25751) + (-0.09185);
            double E5 = G1 * 0.91283 + G2 * 3.3467 + G3 * 1.7472 + G4 * 0.93245 + G5 * 1.531 + 0.45509;
            double E6 = G1 * (-2.3059) + G2 * (-0.3581) + G3 * (-2.3215) + G4 * (-2.1604) + G5 * (-1.3388) + (-1.7989);
            double E7 = G1 * (-1.4566) + G2 * 2.3007 + G3 * 2.1573 + G4 * 0.55643 + G5 * 2.7434 + (-3.0043);
            double E8 = G1 * 0.46174 + G2 * (-1.5004) + G3 * 2.1608 + G4 * (-2.2425) + G5 * (-2.4817) + 4.0186;

            double F1 = 1 / (1 + Math.Exp((-1) * E1));
            double F2 = 1 / (1 + Math.Exp((-1) * E2));
            double F3 = 1 / (1 + Math.Exp((-1) * E3));
            double F4 = 1 / (1 + Math.Exp((-1) * E4));
            double F5 = 1 / (1 + Math.Exp((-1) * E5));
            double F6 = 1 / (1 + Math.Exp((-1) * E6));
            double F7 = 1 / (1 + Math.Exp((-1) * E7));
            double F8 = 1 / (1 + Math.Exp((-1) * E8));

            double E9 = F1 * (0.74603) + F2 * 0.10321 + F3 * (-0.18974) + F4 * 1.4324 + F5 * 0.081669 + F6 * (-0.51008) + F7 * 0.64809 + F8 * (-0.33215) - 0.55939;
            double F9 = 1 / (1 + Math.Exp(-E9));

            double E = ((F9 - 0.1) / 0.8) * (28 - 24) + 24;

            if (E >= 24 && E < 25)
            {
                MessageBox.Show("Tahmin: En Az 8.500 TL teklif edilmedir.Üstünüze eklenecek olan miktar şirketin finans durummu ve şirketin finans politikaları göz önünde bulundurularak eklenmelidir.");
            }
            else if (E >= 25 && E < 26)
            {
                MessageBox.Show("Tahmin: En Az 12.500 TL teklif edilmedir.Üstünüze eklenecek olan miktar şirketin finans durummu ve şirketin finans politikaları göz önünde bulundurularak eklenmelidir.");
            }
            else if (E >= 26 && E < 27)
            {

                MessageBox.Show("Tahmin: En Az 15.500 TL teklif edilmedir.Üstünüze eklenecek olan miktar şirketin finans durummu ve şirketin finans politikaları göz önünde bulundurularak eklenmelidir.");
            }
            else if (E >= 27 && E < 28)
            {

                MessageBox.Show("Tahmin: En Az 18.500 TL teklif edilmedir.Üstünüze eklenecek olan miktar şirketin finans durummu ve şirketin finans politikaları göz önünde bulundurularak eklenmelidir.");
            }
            else if (E >= 28)
            {

                MessageBox.Show("Tahmin: En Az 24.500 TL teklif edilmedir.Üstünüze eklenecek olan miktar şirketin finans durummu ve şirketin finans politikaları göz önünde bulundurularak eklenmelidir.");
            }
            else
            {
                MessageBox.Show("Yanlış Değerler Girdiniz");
            }
        }

        private void lblBasvurulanBolum_Click(object sender, EventArgs e)
        {

        }

        private void lblNitelik_Click(object sender, EventArgs e)
        {

        }

        private void lblCocukSayisi_Click(object sender, EventArgs e)
        {

        }

        private void lblMedeniDurum_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



