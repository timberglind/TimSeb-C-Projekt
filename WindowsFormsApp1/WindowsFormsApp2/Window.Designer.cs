namespace WindowsFormsApp1
{
    partial class Window
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.txtLäggTillKategori = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblLäggTillKategori = new System.Windows.Forms.Label();
            this.lblVäljKategori = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.lblUppdatering = new System.Windows.Forms.Label();
            this.cbUppdatering = new System.Windows.Forms.ComboBox();
            this.btnLäggTillPod = new System.Windows.Forms.Button();
            this.btnLäggTillKategori = new System.Windows.Forms.Button();
            this.lbKategori = new System.Windows.Forms.ListBox();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.lbPodcast = new System.Windows.Forms.ListBox();
            this.lblPodcast = new System.Windows.Forms.Label();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.lblOm = new System.Windows.Forms.Label();
            this.btnÄndraPodKategori = new System.Windows.Forms.Button();
            this.btnÄndraPodURL = new System.Windows.Forms.Button();
            this.btnÄndraPodUppdatering = new System.Windows.Forms.Button();
            this.btnÄndraKategori = new System.Windows.Forms.Button();
            this.btnTabortKategori = new System.Windows.Forms.Button();
            this.btnTabortPod = new System.Windows.Forms.Button();
            this.btnSpelaPod = new System.Windows.Forms.Button();
            this.clbAvsnitt = new System.Windows.Forms.CheckedListBox();
            this.tbOm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(16, 42);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(344, 22);
            this.txtURL.TabIndex = 0;
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(16, 90);
            this.txtNamn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(344, 22);
            this.txtNamn.TabIndex = 1;
            // 
            // txtLäggTillKategori
            // 
            this.txtLäggTillKategori.Location = new System.Drawing.Point(16, 272);
            this.txtLäggTillKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLäggTillKategori.Name = "txtLäggTillKategori";
            this.txtLäggTillKategori.Size = new System.Drawing.Size(344, 22);
            this.txtLäggTillKategori.TabIndex = 2;
            this.txtLäggTillKategori.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(17, 22);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(36, 17);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "URL";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(16, 70);
            this.lblNamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(45, 17);
            this.lblNamn.TabIndex = 4;
            this.lblNamn.Text = "Namn";
            // 
            // lblLäggTillKategori
            // 
            this.lblLäggTillKategori.AutoSize = true;
            this.lblLäggTillKategori.Location = new System.Drawing.Point(16, 252);
            this.lblLäggTillKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLäggTillKategori.Name = "lblLäggTillKategori";
            this.lblLäggTillKategori.Size = new System.Drawing.Size(112, 17);
            this.lblLäggTillKategori.TabIndex = 5;
            this.lblLäggTillKategori.Text = "Lägg till kategori";
            // 
            // lblVäljKategori
            // 
            this.lblVäljKategori.AutoSize = true;
            this.lblVäljKategori.Location = new System.Drawing.Point(17, 118);
            this.lblVäljKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVäljKategori.Name = "lblVäljKategori";
            this.lblVäljKategori.Size = new System.Drawing.Size(88, 17);
            this.lblVäljKategori.TabIndex = 6;
            this.lblVäljKategori.Text = "Välj Kategori";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(16, 138);
            this.cbKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(344, 24);
            this.cbKategori.TabIndex = 7;
            // 
            // lblUppdatering
            // 
            this.lblUppdatering.AutoSize = true;
            this.lblUppdatering.Location = new System.Drawing.Point(17, 167);
            this.lblUppdatering.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUppdatering.Name = "lblUppdatering";
            this.lblUppdatering.Size = new System.Drawing.Size(169, 17);
            this.lblUppdatering.TabIndex = 8;
            this.lblUppdatering.Text = "Välj Uppdateringsintervall";
            this.lblUppdatering.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbUppdatering
            // 
            this.cbUppdatering.FormattingEnabled = true;
            this.cbUppdatering.Location = new System.Drawing.Point(16, 187);
            this.cbUppdatering.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUppdatering.Name = "cbUppdatering";
            this.cbUppdatering.Size = new System.Drawing.Size(344, 24);
            this.cbUppdatering.TabIndex = 9;
            // 
            // btnLäggTillPod
            // 
            this.btnLäggTillPod.Location = new System.Drawing.Point(16, 220);
            this.btnLäggTillPod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLäggTillPod.Name = "btnLäggTillPod";
            this.btnLäggTillPod.Size = new System.Drawing.Size(345, 28);
            this.btnLäggTillPod.TabIndex = 10;
            this.btnLäggTillPod.Text = "Lägg till Podcast";
            this.btnLäggTillPod.UseVisualStyleBackColor = true;
            this.btnLäggTillPod.Click += new System.EventHandler(this.btnLäggTillPod_Click);
            // 
            // btnLäggTillKategori
            // 
            this.btnLäggTillKategori.Location = new System.Drawing.Point(16, 304);
            this.btnLäggTillKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLäggTillKategori.Name = "btnLäggTillKategori";
            this.btnLäggTillKategori.Size = new System.Drawing.Size(345, 28);
            this.btnLäggTillKategori.TabIndex = 11;
            this.btnLäggTillKategori.Text = "Lägg till Kategori";
            this.btnLäggTillKategori.UseVisualStyleBackColor = true;
            this.btnLäggTillKategori.Click += new System.EventHandler(this.btnLäggTillKategori_Click_1);
            // 
            // lbKategori
            // 
            this.lbKategori.FormattingEnabled = true;
            this.lbKategori.ItemHeight = 16;
            this.lbKategori.Location = new System.Drawing.Point(405, 46);
            this.lbKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbKategori.Name = "lbKategori";
            this.lbKategori.Size = new System.Drawing.Size(219, 484);
            this.lbKategori.TabIndex = 12;
            this.lbKategori.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbKategori_MouseClick);
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(397, 4);
            this.lblKategorier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(144, 39);
            this.lblKategorier.TabIndex = 13;
            this.lblKategorier.Text = "Kategori";
            // 
            // lbPodcast
            // 
            this.lbPodcast.FormattingEnabled = true;
            this.lbPodcast.ItemHeight = 16;
            this.lbPodcast.Location = new System.Drawing.Point(633, 46);
            this.lbPodcast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPodcast.Name = "lbPodcast";
            this.lbPodcast.Size = new System.Drawing.Size(219, 484);
            this.lbPodcast.TabIndex = 14;
            this.lbPodcast.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbPodcast_MouseClick);
            // 
            // lblPodcast
            // 
            this.lblPodcast.AutoSize = true;
            this.lblPodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcast.Location = new System.Drawing.Point(625, 4);
            this.lblPodcast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodcast.Name = "lblPodcast";
            this.lblPodcast.Size = new System.Drawing.Size(140, 39);
            this.lblPodcast.TabIndex = 15;
            this.lblPodcast.Text = "Podcast";
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnitt.Location = new System.Drawing.Point(853, 4);
            this.lblAvsnitt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(119, 39);
            this.lblAvsnitt.TabIndex = 17;
            this.lblAvsnitt.Text = "Avsnitt";
            // 
            // lblOm
            // 
            this.lblOm.AutoSize = true;
            this.lblOm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOm.Location = new System.Drawing.Point(856, 539);
            this.lblOm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOm.Name = "lblOm";
            this.lblOm.Size = new System.Drawing.Size(147, 29);
            this.lblOm.TabIndex = 19;
            this.lblOm.Text = "Om Avsnittet";
            // 
            // btnÄndraPodKategori
            // 
            this.btnÄndraPodKategori.Location = new System.Drawing.Point(16, 383);
            this.btnÄndraPodKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnÄndraPodKategori.Name = "btnÄndraPodKategori";
            this.btnÄndraPodKategori.Size = new System.Drawing.Size(345, 28);
            this.btnÄndraPodKategori.TabIndex = 20;
            this.btnÄndraPodKategori.Text = "Ändra Podcastens Kategori";
            this.btnÄndraPodKategori.UseVisualStyleBackColor = true;
            this.btnÄndraPodKategori.Click += new System.EventHandler(this.btnÄndraPodKategori_Click);
            // 
            // btnÄndraPodURL
            // 
            this.btnÄndraPodURL.Location = new System.Drawing.Point(16, 347);
            this.btnÄndraPodURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnÄndraPodURL.Name = "btnÄndraPodURL";
            this.btnÄndraPodURL.Size = new System.Drawing.Size(345, 28);
            this.btnÄndraPodURL.TabIndex = 21;
            this.btnÄndraPodURL.Text = "Ändra Podcastens URL";
            this.btnÄndraPodURL.UseVisualStyleBackColor = true;
            this.btnÄndraPodURL.Click += new System.EventHandler(this.btnÄndraPodURL_Click);
            // 
            // btnÄndraPodUppdatering
            // 
            this.btnÄndraPodUppdatering.Location = new System.Drawing.Point(16, 418);
            this.btnÄndraPodUppdatering.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnÄndraPodUppdatering.Name = "btnÄndraPodUppdatering";
            this.btnÄndraPodUppdatering.Size = new System.Drawing.Size(345, 28);
            this.btnÄndraPodUppdatering.TabIndex = 22;
            this.btnÄndraPodUppdatering.Text = "Ändra Podcastens Uppdateringsintervall";
            this.btnÄndraPodUppdatering.UseVisualStyleBackColor = true;
            this.btnÄndraPodUppdatering.Click += new System.EventHandler(this.btnÄndraPodUppdatering_Click);
            // 
            // btnÄndraKategori
            // 
            this.btnÄndraKategori.Location = new System.Drawing.Point(16, 490);
            this.btnÄndraKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnÄndraKategori.Name = "btnÄndraKategori";
            this.btnÄndraKategori.Size = new System.Drawing.Size(345, 28);
            this.btnÄndraKategori.TabIndex = 23;
            this.btnÄndraKategori.Text = "Ändra Namn på Kategori";
            this.btnÄndraKategori.UseVisualStyleBackColor = true;
            this.btnÄndraKategori.Click += new System.EventHandler(this.btnÄndraKategori_Click);
            // 
            // btnTabortKategori
            // 
            this.btnTabortKategori.Location = new System.Drawing.Point(16, 526);
            this.btnTabortKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTabortKategori.Name = "btnTabortKategori";
            this.btnTabortKategori.Size = new System.Drawing.Size(345, 28);
            this.btnTabortKategori.TabIndex = 24;
            this.btnTabortKategori.Text = "Ta bort Kategori och allt innehåll";
            this.btnTabortKategori.UseVisualStyleBackColor = true;
            this.btnTabortKategori.Click += new System.EventHandler(this.btnTabortKategori_Click);
            // 
            // btnTabortPod
            // 
            this.btnTabortPod.Location = new System.Drawing.Point(16, 454);
            this.btnTabortPod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTabortPod.Name = "btnTabortPod";
            this.btnTabortPod.Size = new System.Drawing.Size(345, 28);
            this.btnTabortPod.TabIndex = 25;
            this.btnTabortPod.Text = "Ta bort Podcast";
            this.btnTabortPod.UseVisualStyleBackColor = true;
            this.btnTabortPod.Click += new System.EventHandler(this.btnTabortPod_Click);
            // 
            // btnSpelaPod
            // 
            this.btnSpelaPod.Location = new System.Drawing.Point(405, 572);
            this.btnSpelaPod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpelaPod.Name = "btnSpelaPod";
            this.btnSpelaPod.Size = new System.Drawing.Size(448, 165);
            this.btnSpelaPod.TabIndex = 26;
            this.btnSpelaPod.Text = "Spela Podcast";
            this.btnSpelaPod.UseVisualStyleBackColor = true;
            this.btnSpelaPod.Click += new System.EventHandler(this.btnSpelaPod_Click);
            // 
            // clbAvsnitt
            // 
            this.clbAvsnitt.FormattingEnabled = true;
            this.clbAvsnitt.Location = new System.Drawing.Point(861, 46);
            this.clbAvsnitt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbAvsnitt.Name = "clbAvsnitt";
            this.clbAvsnitt.Size = new System.Drawing.Size(619, 480);
            this.clbAvsnitt.TabIndex = 27;
            this.clbAvsnitt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clbAvsnitt_MouseClick);
            // 
            // tbOm
            // 
            this.tbOm.Location = new System.Drawing.Point(861, 572);
            this.tbOm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOm.Multiline = true;
            this.tbOm.Name = "tbOm";
            this.tbOm.Size = new System.Drawing.Size(619, 164);
            this.tbOm.TabIndex = 28;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 752);
            this.Controls.Add(this.tbOm);
            this.Controls.Add(this.clbAvsnitt);
            this.Controls.Add(this.btnSpelaPod);
            this.Controls.Add(this.btnTabortPod);
            this.Controls.Add(this.btnTabortKategori);
            this.Controls.Add(this.btnÄndraKategori);
            this.Controls.Add(this.btnÄndraPodUppdatering);
            this.Controls.Add(this.btnÄndraPodURL);
            this.Controls.Add(this.btnÄndraPodKategori);
            this.Controls.Add(this.lblOm);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.lblPodcast);
            this.Controls.Add(this.lbPodcast);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.lbKategori);
            this.Controls.Add(this.btnLäggTillKategori);
            this.Controls.Add(this.btnLäggTillPod);
            this.Controls.Add(this.cbUppdatering);
            this.Controls.Add(this.lblUppdatering);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.lblVäljKategori);
            this.Controls.Add(this.lblLäggTillKategori);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtLäggTillKategori);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.txtURL);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Window";
            this.Text = "P0DC4ST3R 4PP3N";
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.TextBox txtLäggTillKategori;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblLäggTillKategori;
        private System.Windows.Forms.Label lblVäljKategori;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label lblUppdatering;
        private System.Windows.Forms.ComboBox cbUppdatering;
        private System.Windows.Forms.Button btnLäggTillPod;
        private System.Windows.Forms.Button btnLäggTillKategori;
        private System.Windows.Forms.ListBox lbKategori;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.ListBox lbPodcast;
        private System.Windows.Forms.Label lblPodcast;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.Label lblOm;
        private System.Windows.Forms.Button btnÄndraPodKategori;
        private System.Windows.Forms.Button btnÄndraPodURL;
        private System.Windows.Forms.Button btnÄndraPodUppdatering;
        private System.Windows.Forms.Button btnÄndraKategori;
        private System.Windows.Forms.Button btnTabortKategori;
        private System.Windows.Forms.Button btnTabortPod;
        private System.Windows.Forms.Button btnSpelaPod;
        private System.Windows.Forms.CheckedListBox clbAvsnitt;
        private System.Windows.Forms.TextBox tbOm;
    }
}

