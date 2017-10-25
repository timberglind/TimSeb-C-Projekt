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
            this.tbOm = new System.Windows.Forms.TextBox();
            this.clbAvsnitt = new System.Windows.Forms.CheckedListBox();
            this.lbVälkommen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 34);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(259, 20);
            this.txtURL.TabIndex = 0;
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(12, 73);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(259, 20);
            this.txtNamn.TabIndex = 1;
            // 
            // txtLäggTillKategori
            // 
            this.txtLäggTillKategori.Location = new System.Drawing.Point(12, 221);
            this.txtLäggTillKategori.Name = "txtLäggTillKategori";
            this.txtLäggTillKategori.Size = new System.Drawing.Size(259, 20);
            this.txtLäggTillKategori.TabIndex = 2;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(13, 18);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "URL";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(12, 57);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(35, 13);
            this.lblNamn.TabIndex = 4;
            this.lblNamn.Text = "Namn";
            // 
            // lblLäggTillKategori
            // 
            this.lblLäggTillKategori.AutoSize = true;
            this.lblLäggTillKategori.Location = new System.Drawing.Point(12, 205);
            this.lblLäggTillKategori.Name = "lblLäggTillKategori";
            this.lblLäggTillKategori.Size = new System.Drawing.Size(84, 13);
            this.lblLäggTillKategori.TabIndex = 5;
            this.lblLäggTillKategori.Text = "Lägg till kategori";
            // 
            // lblVäljKategori
            // 
            this.lblVäljKategori.AutoSize = true;
            this.lblVäljKategori.Location = new System.Drawing.Point(13, 96);
            this.lblVäljKategori.Name = "lblVäljKategori";
            this.lblVäljKategori.Size = new System.Drawing.Size(66, 13);
            this.lblVäljKategori.TabIndex = 6;
            this.lblVäljKategori.Text = "Välj Kategori";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(12, 112);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(259, 21);
            this.cbKategori.TabIndex = 7;
            // 
            // lblUppdatering
            // 
            this.lblUppdatering.AutoSize = true;
            this.lblUppdatering.Location = new System.Drawing.Point(13, 136);
            this.lblUppdatering.Name = "lblUppdatering";
            this.lblUppdatering.Size = new System.Drawing.Size(179, 13);
            this.lblUppdatering.TabIndex = 8;
            this.lblUppdatering.Text = "Välj Uppdateringsintervall (sekunder)";
            // 
            // cbUppdatering
            // 
            this.cbUppdatering.FormattingEnabled = true;
            this.cbUppdatering.Location = new System.Drawing.Point(12, 152);
            this.cbUppdatering.Name = "cbUppdatering";
            this.cbUppdatering.Size = new System.Drawing.Size(259, 21);
            this.cbUppdatering.TabIndex = 9;
            // 
            // btnLäggTillPod
            // 
            this.btnLäggTillPod.Location = new System.Drawing.Point(12, 179);
            this.btnLäggTillPod.Name = "btnLäggTillPod";
            this.btnLäggTillPod.Size = new System.Drawing.Size(259, 23);
            this.btnLäggTillPod.TabIndex = 10;
            this.btnLäggTillPod.Text = "Lägg till Podcast";
            this.btnLäggTillPod.UseVisualStyleBackColor = true;
            this.btnLäggTillPod.Click += new System.EventHandler(this.btnLäggTillPod_Click);
            // 
            // btnLäggTillKategori
            // 
            this.btnLäggTillKategori.Location = new System.Drawing.Point(12, 247);
            this.btnLäggTillKategori.Name = "btnLäggTillKategori";
            this.btnLäggTillKategori.Size = new System.Drawing.Size(259, 23);
            this.btnLäggTillKategori.TabIndex = 11;
            this.btnLäggTillKategori.Text = "Lägg till Kategori";
            this.btnLäggTillKategori.UseVisualStyleBackColor = true;
            this.btnLäggTillKategori.Click += new System.EventHandler(this.btnLäggTillKategori_Click_1);
            // 
            // lbKategori
            // 
            this.lbKategori.FormattingEnabled = true;
            this.lbKategori.Location = new System.Drawing.Point(304, 37);
            this.lbKategori.Name = "lbKategori";
            this.lbKategori.Size = new System.Drawing.Size(165, 394);
            this.lbKategori.TabIndex = 12;
            this.lbKategori.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbKategori_MouseClick);
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(298, 3);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(115, 31);
            this.lblKategorier.TabIndex = 13;
            this.lblKategorier.Text = "Kategori";
            // 
            // lbPodcast
            // 
            this.lbPodcast.FormattingEnabled = true;
            this.lbPodcast.Location = new System.Drawing.Point(475, 37);
            this.lbPodcast.Name = "lbPodcast";
            this.lbPodcast.Size = new System.Drawing.Size(165, 394);
            this.lbPodcast.TabIndex = 14;
            this.lbPodcast.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbPodcast_MouseClick);
            // 
            // lblPodcast
            // 
            this.lblPodcast.AutoSize = true;
            this.lblPodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcast.Location = new System.Drawing.Point(469, 3);
            this.lblPodcast.Name = "lblPodcast";
            this.lblPodcast.Size = new System.Drawing.Size(113, 31);
            this.lblPodcast.TabIndex = 15;
            this.lblPodcast.Text = "Podcast";
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnitt.Location = new System.Drawing.Point(640, 3);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(97, 31);
            this.lblAvsnitt.TabIndex = 17;
            this.lblAvsnitt.Text = "Avsnitt";
            // 
            // lblOm
            // 
            this.lblOm.AutoSize = true;
            this.lblOm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOm.Location = new System.Drawing.Point(642, 438);
            this.lblOm.Name = "lblOm";
            this.lblOm.Size = new System.Drawing.Size(115, 24);
            this.lblOm.TabIndex = 19;
            this.lblOm.Text = "Om Avsnittet";
            // 
            // btnÄndraPodKategori
            // 
            this.btnÄndraPodKategori.Location = new System.Drawing.Point(12, 311);
            this.btnÄndraPodKategori.Name = "btnÄndraPodKategori";
            this.btnÄndraPodKategori.Size = new System.Drawing.Size(259, 23);
            this.btnÄndraPodKategori.TabIndex = 20;
            this.btnÄndraPodKategori.Text = "Ändra Podcastens Kategori";
            this.btnÄndraPodKategori.UseVisualStyleBackColor = true;
            this.btnÄndraPodKategori.Click += new System.EventHandler(this.btnÄndraPodKategori_Click);
            // 
            // btnÄndraPodURL
            // 
            this.btnÄndraPodURL.Location = new System.Drawing.Point(12, 282);
            this.btnÄndraPodURL.Name = "btnÄndraPodURL";
            this.btnÄndraPodURL.Size = new System.Drawing.Size(259, 23);
            this.btnÄndraPodURL.TabIndex = 21;
            this.btnÄndraPodURL.Text = "Ändra Podcastens URL";
            this.btnÄndraPodURL.UseVisualStyleBackColor = true;
            this.btnÄndraPodURL.Click += new System.EventHandler(this.btnÄndraPodURL_Click);
            // 
            // btnÄndraPodUppdatering
            // 
            this.btnÄndraPodUppdatering.Location = new System.Drawing.Point(12, 340);
            this.btnÄndraPodUppdatering.Name = "btnÄndraPodUppdatering";
            this.btnÄndraPodUppdatering.Size = new System.Drawing.Size(259, 23);
            this.btnÄndraPodUppdatering.TabIndex = 22;
            this.btnÄndraPodUppdatering.Text = "Ändra Podcastens Uppdateringsintervall";
            this.btnÄndraPodUppdatering.UseVisualStyleBackColor = true;
            this.btnÄndraPodUppdatering.Click += new System.EventHandler(this.btnÄndraPodUppdatering_Click);
            // 
            // btnÄndraKategori
            // 
            this.btnÄndraKategori.Location = new System.Drawing.Point(12, 398);
            this.btnÄndraKategori.Name = "btnÄndraKategori";
            this.btnÄndraKategori.Size = new System.Drawing.Size(259, 23);
            this.btnÄndraKategori.TabIndex = 23;
            this.btnÄndraKategori.Text = "Ändra Namn på Kategori";
            this.btnÄndraKategori.UseVisualStyleBackColor = true;
            this.btnÄndraKategori.Click += new System.EventHandler(this.btnÄndraKategori_Click);
            // 
            // btnTabortKategori
            // 
            this.btnTabortKategori.Location = new System.Drawing.Point(12, 427);
            this.btnTabortKategori.Name = "btnTabortKategori";
            this.btnTabortKategori.Size = new System.Drawing.Size(259, 23);
            this.btnTabortKategori.TabIndex = 24;
            this.btnTabortKategori.Text = "Ta bort Kategori och allt innehåll";
            this.btnTabortKategori.UseVisualStyleBackColor = true;
            this.btnTabortKategori.Click += new System.EventHandler(this.btnTabortKategori_Click);
            // 
            // btnTabortPod
            // 
            this.btnTabortPod.Location = new System.Drawing.Point(12, 369);
            this.btnTabortPod.Name = "btnTabortPod";
            this.btnTabortPod.Size = new System.Drawing.Size(259, 23);
            this.btnTabortPod.TabIndex = 25;
            this.btnTabortPod.Text = "Ta bort Podcast";
            this.btnTabortPod.UseVisualStyleBackColor = true;
            this.btnTabortPod.Click += new System.EventHandler(this.btnTabortPod_Click);
            // 
            // btnSpelaPod
            // 
            this.btnSpelaPod.Location = new System.Drawing.Point(304, 465);
            this.btnSpelaPod.Name = "btnSpelaPod";
            this.btnSpelaPod.Size = new System.Drawing.Size(336, 134);
            this.btnSpelaPod.TabIndex = 26;
            this.btnSpelaPod.Text = "Spela Podcast";
            this.btnSpelaPod.UseVisualStyleBackColor = true;
            this.btnSpelaPod.Click += new System.EventHandler(this.btnSpelaPod_Click);
            // 
            // tbOm
            // 
            this.tbOm.Location = new System.Drawing.Point(646, 465);
            this.tbOm.Multiline = true;
            this.tbOm.Name = "tbOm";
            this.tbOm.Size = new System.Drawing.Size(465, 134);
            this.tbOm.TabIndex = 28;
            // 
            // clbAvsnitt
            // 
            this.clbAvsnitt.FormattingEnabled = true;
            this.clbAvsnitt.Location = new System.Drawing.Point(646, 37);
            this.clbAvsnitt.Name = "clbAvsnitt";
            this.clbAvsnitt.Size = new System.Drawing.Size(465, 394);
            this.clbAvsnitt.TabIndex = 29;
            this.clbAvsnitt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clbAvsnitt_MouseClick);
            // 
            // lbVälkommen
            // 
            this.lbVälkommen.BackColor = System.Drawing.Color.Blue;
            this.lbVälkommen.Font = new System.Drawing.Font("MS Office Symbol Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVälkommen.ForeColor = System.Drawing.Color.Yellow;
            this.lbVälkommen.FormattingEnabled = true;
            this.lbVälkommen.ItemHeight = 27;
            this.lbVälkommen.Location = new System.Drawing.Point(73, 474);
            this.lbVälkommen.Name = "lbVälkommen";
            this.lbVälkommen.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbVälkommen.Size = new System.Drawing.Size(138, 112);
            this.lbVälkommen.TabIndex = 30;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 611);
            this.Controls.Add(this.lbVälkommen);
            this.Controls.Add(this.clbAvsnitt);
            this.Controls.Add(this.tbOm);
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
            this.Name = "Window";
            this.Text = "P0DC4ST3R 4PP3N";
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
        private System.Windows.Forms.TextBox tbOm;
        private System.Windows.Forms.CheckedListBox clbAvsnitt;
        private System.Windows.Forms.ListBox lbVälkommen;
    }
}

