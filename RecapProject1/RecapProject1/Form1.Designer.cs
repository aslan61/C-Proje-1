
namespace RecapProject1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxkategori = new System.Windows.Forms.GroupBox();
            this.lblkategori = new System.Windows.Forms.Label();
            this.cbxkategori = new System.Windows.Forms.ComboBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxkategori.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxkategori
            // 
            this.gbxkategori.Controls.Add(this.lblkategori);
            this.gbxkategori.Controls.Add(this.cbxkategori);
            this.gbxkategori.Location = new System.Drawing.Point(12, 12);
            this.gbxkategori.Name = "gbxkategori";
            this.gbxkategori.Size = new System.Drawing.Size(776, 77);
            this.gbxkategori.TabIndex = 0;
            this.gbxkategori.TabStop = false;
            this.gbxkategori.Text = "Kategoriye Göre Listele";
            // 
            // lblkategori
            // 
            this.lblkategori.AutoSize = true;
            this.lblkategori.Location = new System.Drawing.Point(6, 34);
            this.lblkategori.Name = "lblkategori";
            this.lblkategori.Size = new System.Drawing.Size(49, 13);
            this.lblkategori.TabIndex = 1;
            this.lblkategori.Text = "Kategori:";
            // 
            // cbxkategori
            // 
            this.cbxkategori.FormattingEnabled = true;
            this.cbxkategori.Location = new System.Drawing.Point(58, 31);
            this.cbxkategori.Name = "cbxkategori";
            this.cbxkategori.Size = new System.Drawing.Size(221, 21);
            this.cbxkategori.TabIndex = 0;
            this.cbxkategori.SelectedIndexChanged += new System.EventHandler(this.cbxkategori_SelectedIndexChanged);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxsearch);
            this.gbxSearch.Controls.Add(this.lblsearch);
            this.gbxSearch.Location = new System.Drawing.Point(12, 95);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(775, 92);
            this.gbxSearch.TabIndex = 1;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürün İsmine Göre Ara";
            // 
            // tbxsearch
            // 
            this.tbxsearch.Location = new System.Drawing.Point(57, 36);
            this.tbxsearch.Name = "tbxsearch";
            this.tbxsearch.Size = new System.Drawing.Size(221, 20);
            this.tbxsearch.TabIndex = 3;
            this.tbxsearch.TextChanged += new System.EventHandler(this.tbxsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(6, 39);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(26, 13);
            this.lblsearch.TabIndex = 2;
            this.lblsearch.Text = "Ara:";
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 193);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(775, 245);
            this.dgwProduct.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxkategori);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxkategori.ResumeLayout(false);
            this.gbxkategori.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxkategori;
        private System.Windows.Forms.Label lblkategori;
        private System.Windows.Forms.ComboBox cbxkategori;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.DataGridView dgwProduct;
    }
}

