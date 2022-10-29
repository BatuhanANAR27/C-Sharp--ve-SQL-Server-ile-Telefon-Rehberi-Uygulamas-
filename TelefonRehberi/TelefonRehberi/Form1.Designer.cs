
namespace TelefonRehberi
{
    partial class formTel
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
            this.components = new System.ComponentModel.Container();
            this.textAra = new System.Windows.Forms.TextBox();
            this.dataGrivKisiler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textKayıt = new System.Windows.Forms.TextBox();
            this.textTelTür = new System.Windows.Forms.TextBox();
            this.textCinsiyet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.silbutonu = new System.Windows.Forms.Button();
            this.kaydetbutonu = new System.Windows.Forms.Button();
            this.güncellebutonu = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.seçtiğinÖğeyiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçtiğinÖğeyiKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçtiğinÖğeyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçtiğinÖğeyiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rEHBERDataSet1 = new TelefonRehberi.REHBERDataSet1();
            this.telefonRehberiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayıtTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonRehberiTableAdapter1 = new TelefonRehberi.REHBERDataSet1TableAdapters.TelefonRehberiTableAdapter();
            this.telefonRehberiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrivKisiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rEHBERDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonRehberiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonRehberiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textAra
            // 
            this.textAra.Location = new System.Drawing.Point(194, 61);
            this.textAra.Multiline = true;
            this.textAra.Name = "textAra";
            this.textAra.Size = new System.Drawing.Size(404, 38);
            this.textAra.TabIndex = 0;
            this.textAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGrivKisiler
            // 
            this.dataGrivKisiler.BackgroundColor = System.Drawing.Color.White;
            this.dataGrivKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrivKisiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.kayıtTürüDataGridViewTextBoxColumn,
            this.telefonTürüDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn});
            this.dataGrivKisiler.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGrivKisiler.Location = new System.Drawing.Point(1, 105);
            this.dataGrivKisiler.Name = "dataGrivKisiler";
            this.dataGrivKisiler.Size = new System.Drawing.Size(751, 520);
            this.dataGrivKisiler.TabIndex = 2;
            this.dataGrivKisiler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrivKisiler_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(776, 165);
            this.label1.MaximumSize = new System.Drawing.Size(400, 250);
            this.label1.MinimumSize = new System.Drawing.Size(80, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(776, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(781, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(893, 165);
            this.textAd.Multiline = true;
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(190, 32);
            this.textAd.TabIndex = 6;
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(893, 220);
            this.textSoyad.Multiline = true;
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(190, 32);
            this.textSoyad.TabIndex = 7;
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(893, 382);
            this.textTelefon.Multiline = true;
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(190, 32);
            this.textTelefon.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(776, 105);
            this.label4.MaximumSize = new System.Drawing.Size(400, 250);
            this.label4.MinimumSize = new System.Drawing.Size(80, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(893, 117);
            this.textId.Multiline = true;
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(190, 32);
            this.textId.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(77, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 38);
            this.label5.TabIndex = 15;
            this.label5.Text = "Arama\r\n";
            // 
            // textKayıt
            // 
            this.textKayıt.Location = new System.Drawing.Point(893, 281);
            this.textKayıt.Multiline = true;
            this.textKayıt.Name = "textKayıt";
            this.textKayıt.Size = new System.Drawing.Size(190, 32);
            this.textKayıt.TabIndex = 16;
            // 
            // textTelTür
            // 
            this.textTelTür.Location = new System.Drawing.Point(893, 332);
            this.textTelTür.Multiline = true;
            this.textTelTür.Name = "textTelTür";
            this.textTelTür.Size = new System.Drawing.Size(190, 32);
            this.textTelTür.TabIndex = 17;
            // 
            // textCinsiyet
            // 
            this.textCinsiyet.Location = new System.Drawing.Point(893, 425);
            this.textCinsiyet.Multiline = true;
            this.textCinsiyet.Name = "textCinsiyet";
            this.textCinsiyet.Size = new System.Drawing.Size(190, 32);
            this.textCinsiyet.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(765, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 37);
            this.label6.TabIndex = 19;
            this.label6.Text = "KayıtTürü";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(754, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 37);
            this.label7.TabIndex = 20;
            this.label7.Text = "TelefonTürü";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(782, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 37);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cinsiyet";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::TelefonRehberi.Properties.Resources.logout;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(881, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 74);
            this.button1.TabIndex = 22;
            this.button1.Text = "\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // silbutonu
            // 
            this.silbutonu.BackColor = System.Drawing.Color.White;
            this.silbutonu.BackgroundImage = global::TelefonRehberi.Properties.Resources._3669361_delete_ic_icon;
            this.silbutonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.silbutonu.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbutonu.Location = new System.Drawing.Point(989, 463);
            this.silbutonu.Name = "silbutonu";
            this.silbutonu.Size = new System.Drawing.Size(106, 78);
            this.silbutonu.TabIndex = 11;
            this.silbutonu.UseVisualStyleBackColor = false;
            this.silbutonu.Click += new System.EventHandler(this.silbutonu_Click);
            // 
            // kaydetbutonu
            // 
            this.kaydetbutonu.BackColor = System.Drawing.Color.White;
            this.kaydetbutonu.BackgroundImage = global::TelefonRehberi.Properties.Resources._2931176_diskette_guardar_save_disk_drive_icon;
            this.kaydetbutonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kaydetbutonu.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetbutonu.Location = new System.Drawing.Point(881, 467);
            this.kaydetbutonu.Name = "kaydetbutonu";
            this.kaydetbutonu.Size = new System.Drawing.Size(105, 78);
            this.kaydetbutonu.TabIndex = 10;
            this.kaydetbutonu.UseVisualStyleBackColor = false;
            this.kaydetbutonu.Click += new System.EventHandler(this.kaydetbutonu_Click);
            // 
            // güncellebutonu
            // 
            this.güncellebutonu.BackColor = System.Drawing.Color.White;
            this.güncellebutonu.BackgroundImage = global::TelefonRehberi.Properties.Resources._8111405_reset_reload_refresh_sync_arrow_icon;
            this.güncellebutonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.güncellebutonu.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncellebutonu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.güncellebutonu.Location = new System.Drawing.Point(758, 467);
            this.güncellebutonu.Name = "güncellebutonu";
            this.güncellebutonu.Size = new System.Drawing.Size(111, 78);
            this.güncellebutonu.TabIndex = 9;
            this.güncellebutonu.UseVisualStyleBackColor = false;
            this.güncellebutonu.Click += new System.EventHandler(this.güncellebutonu_Click);
            // 
            // seçtiğinÖğeyiGüncelleToolStripMenuItem
            // 
            this.seçtiğinÖğeyiGüncelleToolStripMenuItem.Name = "seçtiğinÖğeyiGüncelleToolStripMenuItem";
            this.seçtiğinÖğeyiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.seçtiğinÖğeyiGüncelleToolStripMenuItem.Text = "seçtiğin öğeyi güncelle";
            // 
            // seçtiğinÖğeyiKaydetToolStripMenuItem
            // 
            this.seçtiğinÖğeyiKaydetToolStripMenuItem.Name = "seçtiğinÖğeyiKaydetToolStripMenuItem";
            this.seçtiğinÖğeyiKaydetToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.seçtiğinÖğeyiKaydetToolStripMenuItem.Text = "seçtiğin öğeyi kaydet";
            // 
            // seçtiğinÖğeyiSilToolStripMenuItem
            // 
            this.seçtiğinÖğeyiSilToolStripMenuItem.Name = "seçtiğinÖğeyiSilToolStripMenuItem";
            this.seçtiğinÖğeyiSilToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.seçtiğinÖğeyiSilToolStripMenuItem.Text = "seçtiğin öğeyi sil";
            // 
            // seçtiğinÖğeyiEkleToolStripMenuItem
            // 
            this.seçtiğinÖğeyiEkleToolStripMenuItem.Name = "seçtiğinÖğeyiEkleToolStripMenuItem";
            this.seçtiğinÖğeyiEkleToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.seçtiğinÖğeyiEkleToolStripMenuItem.Text = "seçtiğin öğeyi ekle";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçtiğinÖğeyiGüncelleToolStripMenuItem,
            this.seçtiğinÖğeyiKaydetToolStripMenuItem,
            this.seçtiğinÖğeyiSilToolStripMenuItem,
            this.seçtiğinÖğeyiEkleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 92);
            // 
            // rEHBERDataSet1
            // 
            this.rEHBERDataSet1.DataSetName = "REHBERDataSet1";
            this.rEHBERDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telefonRehberiBindingSource1
            // 
            this.telefonRehberiBindingSource1.DataMember = "TelefonRehberi";
            this.telefonRehberiBindingSource1.DataSource = this.rEHBERDataSet1;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // telefonTürüDataGridViewTextBoxColumn
            // 
            this.telefonTürüDataGridViewTextBoxColumn.DataPropertyName = "TelefonTürü";
            this.telefonTürüDataGridViewTextBoxColumn.HeaderText = "TelefonTürü";
            this.telefonTürüDataGridViewTextBoxColumn.Name = "telefonTürüDataGridViewTextBoxColumn";
            // 
            // kayıtTürüDataGridViewTextBoxColumn
            // 
            this.kayıtTürüDataGridViewTextBoxColumn.DataPropertyName = "KayıtTürü";
            this.kayıtTürüDataGridViewTextBoxColumn.HeaderText = "KayıtTürü";
            this.kayıtTürüDataGridViewTextBoxColumn.Name = "kayıtTürüDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonRehberiTableAdapter1
            // 
            this.telefonRehberiTableAdapter1.ClearBeforeFill = true;
            // 
            // formTel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1095, 625);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textCinsiyet);
            this.Controls.Add(this.textTelTür);
            this.Controls.Add(this.textKayıt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.silbutonu);
            this.Controls.Add(this.kaydetbutonu);
            this.Controls.Add(this.güncellebutonu);
            this.Controls.Add(this.textTelefon);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrivKisiler);
            this.Controls.Add(this.textAra);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "formTel";
            this.Text = "Telefon Rehberi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrivKisiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rEHBERDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonRehberiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonRehberiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAra;
        private System.Windows.Forms.DataGridView dataGrivKisiler;
       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.Button güncellebutonu;
        private System.Windows.Forms.Button kaydetbutonu;
        private System.Windows.Forms.Button silbutonu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textKayıt;
        private System.Windows.Forms.TextBox textTelTür;
        private System.Windows.Forms.TextBox textCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayıtTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçtiğinÖğeyiGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçtiğinÖğeyiKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçtiğinÖğeyiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçtiğinÖğeyiEkleToolStripMenuItem;
        private REHBERDataSet1 rEHBERDataSet1;
        private System.Windows.Forms.BindingSource telefonRehberiBindingSource1;
        private REHBERDataSet1TableAdapters.TelefonRehberiTableAdapter telefonRehberiTableAdapter1;
        private System.Windows.Forms.BindingSource telefonRehberiBindingSource;
    }
}

