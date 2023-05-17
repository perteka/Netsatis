
namespace NetSatis.BackOffice.İndirim
{
    partial class FrmIndirimIslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIndirimIslem));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dateBaslangic = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.dateBitis = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.checkButton3 = new DevExpress.XtraEditors.CheckButton();
            this.btnSuresiz = new DevExpress.XtraEditors.CheckButton();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.wizardPage2 = new DevExpress.XtraWizard.WizardPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridcontIndirimler = new DevExpress.XtraGrid.GridControl();
            this.gridIndirimler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBitisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            this.wizardPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontIndirimler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIndirimler)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.CancelText = "Kapat";
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage2);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextText = "&İleri >";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.wizardPage2,
            this.completionWizardPage1});
            this.wizardControl1.PreviousText = "< &Geri";
            this.wizardControl1.Size = new System.Drawing.Size(1239, 917);
            this.wizardControl1.Text = "İndirim Sihirbazı";
            this.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(1165, 706);
            this.welcomeWizardPage1.Text = "İndirim Sihirbazına Hoşgeldiniz";
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.splitContainerControl1);
            this.wizardPage1.Controls.Add(this.checkButton3);
            this.wizardPage1.Controls.Add(this.btnSuresiz);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(1165, 706);
            this.wizardPage1.Text = "İndirim Türünü Seçin";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 287);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl4);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1165, 419);
            this.splitContainerControl1.SplitterPosition = 577;
            this.splitContainerControl1.TabIndex = 8;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.dateBaslangic);
            this.groupControl4.Controls.Add(this.dateBitis);
            this.groupControl4.Controls.Add(this.labelControl2);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(577, 419);
            this.groupControl4.TabIndex = 7;
            this.groupControl4.Text = "Tarih Bilgisi";
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBaslangic.Location = new System.Drawing.Point(0, 96);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(283, 282);
            this.dateBaslangic.TabIndex = 36;
            // 
            // dateBitis
            // 
            this.dateBitis.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBitis.Location = new System.Drawing.Point(286, 96);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(283, 282);
            this.dateBitis.TabIndex = 36;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(286, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(283, 24);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Bitiş Tarihi";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(6, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(277, 24);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Başlangıç Tarihi";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtAciklama);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(576, 419);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAciklama.Location = new System.Drawing.Point(2, 28);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(572, 389);
            this.txtAciklama.TabIndex = 28;
            // 
            // checkButton3
            // 
            this.checkButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkButton3.Appearance.Options.UseFont = true;
            this.checkButton3.GroupIndex = 1;
            this.checkButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("checkButton3.ImageOptions.Image")));
            this.checkButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.checkButton3.Location = new System.Drawing.Point(583, 31);
            this.checkButton3.Name = "checkButton3";
            this.checkButton3.Size = new System.Drawing.Size(257, 234);
            this.checkButton3.TabIndex = 5;
            this.checkButton3.TabStop = false;
            this.checkButton3.Text = "Belirli Tarihler Arasında";
            // 
            // btnSuresiz
            // 
            this.btnSuresiz.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSuresiz.Appearance.Options.UseFont = true;
            this.btnSuresiz.GroupIndex = 1;
            this.btnSuresiz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuresiz.ImageOptions.Image")));
            this.btnSuresiz.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSuresiz.Location = new System.Drawing.Point(320, 31);
            this.btnSuresiz.Name = "btnSuresiz";
            this.btnSuresiz.Size = new System.Drawing.Size(257, 234);
            this.btnSuresiz.TabIndex = 4;
            this.btnSuresiz.TabStop = false;
            this.btnSuresiz.Text = "Süresiz";
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(1165, 706);
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.groupControl1);
            this.wizardPage2.Controls.Add(this.gridcontIndirimler);
            this.wizardPage2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(1165, 706);
            this.wizardPage2.Text = "Lütfen İndirim Yapacağınız Ürünleri Seçiniz";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnAra);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnCikar);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 596);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1165, 110);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Menü";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 2;
            this.btnAra.ImageOptions.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(390, 39);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(118, 64);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "refresh - Kopya.png");
            this.ımageList1.Images.SetKeyName(2, "view - Kopya.png");
            this.ımageList1.Images.SetKeyName(3, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(4, "money2_edit.png");
            this.ımageList1.Images.SetKeyName(5, "stok çıkar.png");
            this.ımageList1.Images.SetKeyName(6, "Stok Ekle.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(264, 39);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(118, 64);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            // 
            // btnCikar
            // 
            this.btnCikar.ImageOptions.ImageIndex = 5;
            this.btnCikar.ImageOptions.ImageList = this.ımageList1;
            this.btnCikar.Location = new System.Drawing.Point(140, 39);
            this.btnCikar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(118, 64);
            this.btnCikar.TabIndex = 2;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 6;
            this.btnEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(15, 39);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(118, 64);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // gridcontIndirimler
            // 
            this.gridcontIndirimler.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridcontIndirimler.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridcontIndirimler.Location = new System.Drawing.Point(0, 0);
            this.gridcontIndirimler.MainView = this.gridIndirimler;
            this.gridcontIndirimler.Margin = new System.Windows.Forms.Padding(4);
            this.gridcontIndirimler.Name = "gridcontIndirimler";
            this.gridcontIndirimler.Size = new System.Drawing.Size(1165, 595);
            this.gridcontIndirimler.TabIndex = 7;
            this.gridcontIndirimler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridIndirimler});
            // 
            // gridIndirimler
            // 
            this.gridIndirimler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDurumu,
            this.colStokKodu,
            this.colBarkod,
            this.colStokAdi,
            this.colIndirimTuru,
            this.colBaslangicTarihi,
            this.colBitisTarihi,
            this.colIndirimOrani,
            this.colAciklama});
            this.gridIndirimler.CustomizationFormBounds = new System.Drawing.Rectangle(782, 365, 392, 331);
            this.gridIndirimler.DetailHeight = 437;
            this.gridIndirimler.GridControl = this.gridcontIndirimler;
            this.gridIndirimler.Name = "gridIndirimler";
            this.gridIndirimler.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.Width = 94;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.MinWidth = 25;
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.OptionsColumn.AllowEdit = false;
            this.colDurumu.OptionsColumn.ShowInCustomizationForm = false;
            this.colDurumu.Width = 94;
            // 
            // colStokKodu
            // 
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.MinWidth = 25;
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 0;
            this.colStokKodu.Width = 94;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.MinWidth = 25;
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.OptionsColumn.ShowInCustomizationForm = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 1;
            this.colBarkod.Width = 94;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.MinWidth = 25;
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 2;
            this.colStokAdi.Width = 94;
            // 
            // colIndirimTuru
            // 
            this.colIndirimTuru.FieldName = "IndirimTuru";
            this.colIndirimTuru.MinWidth = 25;
            this.colIndirimTuru.Name = "colIndirimTuru";
            this.colIndirimTuru.OptionsColumn.AllowEdit = false;
            this.colIndirimTuru.OptionsColumn.ShowInCustomizationForm = false;
            this.colIndirimTuru.Width = 94;
            // 
            // colBaslangicTarihi
            // 
            this.colBaslangicTarihi.FieldName = "BaslangicTarihi";
            this.colBaslangicTarihi.MinWidth = 25;
            this.colBaslangicTarihi.Name = "colBaslangicTarihi";
            this.colBaslangicTarihi.OptionsColumn.AllowEdit = false;
            this.colBaslangicTarihi.OptionsColumn.ShowInCustomizationForm = false;
            this.colBaslangicTarihi.Width = 94;
            // 
            // colBitisTarihi
            // 
            this.colBitisTarihi.FieldName = "BitisTarihi";
            this.colBitisTarihi.MinWidth = 25;
            this.colBitisTarihi.Name = "colBitisTarihi";
            this.colBitisTarihi.OptionsColumn.AllowEdit = false;
            this.colBitisTarihi.OptionsColumn.ShowInCustomizationForm = false;
            this.colBitisTarihi.Width = 94;
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.MinWidth = 25;
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.OptionsColumn.ShowInCustomizationForm = false;
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 3;
            this.colIndirimOrani.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.ShowInCustomizationForm = false;
            this.colAciklama.Width = 94;
            // 
            // FrmIndirimIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 917);
            this.ControlBox = false;
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIndirimIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBaslangic.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBitis.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.wizardPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontIndirimler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIndirimler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraEditors.CheckButton checkButton3;
        private DevExpress.XtraEditors.CheckButton btnSuresiz;
        private DevExpress.XtraWizard.WizardPage wizardPage2;
        private DevExpress.XtraGrid.GridControl gridcontIndirimler;
        public DevExpress.XtraGrid.Views.Grid.GridView gridIndirimler;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBaslangicTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colBitisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        public DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnCikar;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.Controls.CalendarControl dateBaslangic;
        private DevExpress.XtraEditors.Controls.CalendarControl dateBitis;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private System.Windows.Forms.ImageList ımageList1;
    }
}