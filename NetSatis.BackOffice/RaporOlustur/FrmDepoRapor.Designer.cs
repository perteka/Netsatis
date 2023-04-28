
namespace NetSatis.BackOffice.RaporOlustur
{
    partial class FrmDepoRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepoRapor));
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnWord = new DevExpress.XtraEditors.SimpleButton();
            this.btnPdf = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.ImageOptions.ImageIndex = 0;
            this.btnExcel.ImageOptions.ImageList = this.ımageList1;
            this.btnExcel.Location = new System.Drawing.Point(13, 13);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(134, 58);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excel Olarak \r\nRapor Oluştur\r\n";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnWord
            // 
            this.btnWord.ImageOptions.ImageIndex = 1;
            this.btnWord.ImageOptions.ImageList = this.ımageList1;
            this.btnWord.Location = new System.Drawing.Point(155, 13);
            this.btnWord.Margin = new System.Windows.Forms.Padding(4);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(131, 58);
            this.btnWord.TabIndex = 6;
            this.btnWord.Text = "Word Olarak \r\nRapor Oluştur";
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.ImageOptions.ImageIndex = 2;
            this.btnPdf.ImageOptions.ImageList = this.ımageList1;
            this.btnPdf.Location = new System.Drawing.Point(294, 13);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(4);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(124, 58);
            this.btnPdf.TabIndex = 7;
            this.btnPdf.Text = "Pdf Olarak \r\nRapor Oluştur";
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.ImageIndex = 3;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(426, 13);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(132, 58);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "excel.png");
            this.ımageList1.Images.SetKeyName(1, "word.png");
            this.ımageList1.Images.SetKeyName(2, "pdf.png");
            this.ımageList1.Images.SetKeyName(3, "folder_out.png");
            // 
            // FrmDepoRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 82);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnExcel);
            this.Name = "FrmDepoRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo Rapor Oluştur";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnWord;
        private DevExpress.XtraEditors.SimpleButton btnPdf;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}