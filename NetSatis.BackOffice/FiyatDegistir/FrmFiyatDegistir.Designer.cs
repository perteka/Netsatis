
namespace NetSatis.BackOffice.FiyatDegistir
{
    partial class FrmFiyatDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiyatDegistir));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFiyatTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolonAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegisimTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegisimYonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDegistir = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.repositoryDegisimTuru = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryDegisimYonu = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryDegisimMiktari = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupMenu)).BeginInit();
            this.groupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegistir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimYonu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimMiktari)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.ImageOptions.Image")));
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(5);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(676, 65);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Toplu Fiyat Değiştir";
            // 
            // groupMenu
            // 
            this.groupMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.groupMenu.Controls.Add(this.btnKaydet);
            this.groupMenu.Controls.Add(this.btnKapat);
            this.groupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupMenu.Location = new System.Drawing.Point(0, 411);
            this.groupMenu.Margin = new System.Windows.Forms.Padding(15);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(676, 92);
            this.groupMenu.TabIndex = 6;
            this.groupMenu.Text = "Menü";
            this.groupMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.groupMenu_Paint);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.Location = new System.Drawing.Point(429, 38);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(19);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(110, 50);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.Location = new System.Drawing.Point(549, 38);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(15);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(110, 50);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 65);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryDegistir,
            this.repositoryDegisimTuru,
            this.repositoryDegisimYonu,
            this.repositoryDegisimMiktari});
            this.gridControl1.Size = new System.Drawing.Size(676, 346);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFiyatTuru,
            this.colKolonAdi,
            this.colDegistir,
            this.colDegisimTuru,
            this.colDegisimYonu,
            this.colDegeri});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(782, 365, 392, 331);
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFiyatTuru
            // 
            this.colFiyatTuru.Caption = "Fiyat Türü";
            this.colFiyatTuru.FieldName = "FiyatTuru";
            this.colFiyatTuru.MinWidth = 25;
            this.colFiyatTuru.Name = "colFiyatTuru";
            this.colFiyatTuru.OptionsColumn.AllowEdit = false;
            this.colFiyatTuru.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFiyatTuru.Visible = true;
            this.colFiyatTuru.VisibleIndex = 0;
            this.colFiyatTuru.Width = 94;
            // 
            // colKolonAdi
            // 
            this.colKolonAdi.Caption = "Kolon Adı";
            this.colKolonAdi.FieldName = "KolonAdi";
            this.colKolonAdi.MinWidth = 25;
            this.colKolonAdi.Name = "colKolonAdi";
            this.colKolonAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKolonAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colKolonAdi.Width = 94;
            // 
            // colDegistir
            // 
            this.colDegistir.Caption = "Fiyat Değiştirilecek mi ?";
            this.colDegistir.ColumnEdit = this.repositoryDegistir;
            this.colDegistir.FieldName = "Degistir";
            this.colDegistir.MinWidth = 25;
            this.colDegistir.Name = "colDegistir";
            this.colDegistir.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDegistir.Visible = true;
            this.colDegistir.VisibleIndex = 1;
            this.colDegistir.Width = 94;
            // 
            // colDegisimTuru
            // 
            this.colDegisimTuru.Caption = "Değişim Türü";
            this.colDegisimTuru.ColumnEdit = this.repositoryDegisimTuru;
            this.colDegisimTuru.FieldName = "DegisimTuru";
            this.colDegisimTuru.MinWidth = 25;
            this.colDegisimTuru.Name = "colDegisimTuru";
            this.colDegisimTuru.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDegisimTuru.Visible = true;
            this.colDegisimTuru.VisibleIndex = 2;
            this.colDegisimTuru.Width = 94;
            // 
            // colDegisimYonu
            // 
            this.colDegisimYonu.Caption = "Değişim Yönü";
            this.colDegisimYonu.ColumnEdit = this.repositoryDegisimYonu;
            this.colDegisimYonu.FieldName = "DegisimYonu";
            this.colDegisimYonu.MinWidth = 25;
            this.colDegisimYonu.Name = "colDegisimYonu";
            this.colDegisimYonu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDegisimYonu.Visible = true;
            this.colDegisimYonu.VisibleIndex = 3;
            this.colDegisimYonu.Width = 94;
            // 
            // colDegeri
            // 
            this.colDegeri.Caption = "Değişim Miktarı";
            this.colDegeri.ColumnEdit = this.repositoryDegisimMiktari;
            this.colDegeri.FieldName = "Degeri";
            this.colDegeri.MinWidth = 25;
            this.colDegeri.Name = "colDegeri";
            this.colDegeri.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDegeri.Visible = true;
            this.colDegeri.VisibleIndex = 4;
            this.colDegeri.Width = 94;
            // 
            // repositoryDegistir
            // 
            this.repositoryDegistir.AutoHeight = false;
            this.repositoryDegistir.Name = "repositoryDegistir";
            this.repositoryDegistir.OffText = "Off";
            this.repositoryDegistir.OnText = "On";
            // 
            // repositoryDegisimTuru
            // 
            this.repositoryDegisimTuru.AutoHeight = false;
            this.repositoryDegisimTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDegisimTuru.Items.AddRange(new object[] {
            "Yüzde",
            "Tutar"});
            this.repositoryDegisimTuru.Name = "repositoryDegisimTuru";
            this.repositoryDegisimTuru.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryDegisimYonu
            // 
            this.repositoryDegisimYonu.AutoHeight = false;
            this.repositoryDegisimYonu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDegisimYonu.Items.AddRange(new object[] {
            "Arttır",
            "Azalt"});
            this.repositoryDegisimYonu.Name = "repositoryDegisimYonu";
            this.repositoryDegisimYonu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryDegisimMiktari
            // 
            this.repositoryDegisimMiktari.AutoHeight = false;
            this.repositoryDegisimMiktari.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDegisimMiktari.DisplayFormat.FormatString = "N2";
            this.repositoryDegisimMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDegisimMiktari.Name = "repositoryDegisimMiktari";
            // 
            // FrmFiyatDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 503);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupMenu);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmFiyatDegistir";
            this.Text = "Toplu Fiyat Değiştir";
            ((System.ComponentModel.ISupportInitialize)(this.groupMenu)).EndInit();
            this.groupMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegistir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimYonu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimMiktari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        public DevExpress.XtraEditors.GroupControl groupMenu;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyatTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colKolonAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistir;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisimTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisimYonu;
        private DevExpress.XtraGrid.Columns.GridColumn colDegeri;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryDegistir;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryDegisimTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryDegisimYonu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDegisimMiktari;
    }
}