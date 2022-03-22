namespace reproductorWMPCS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bntAbrir = new System.Windows.Forms.Button();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.sbVolumen = new System.Windows.Forms.HScrollBar();
            this.trackList = new System.Windows.Forms.ListBox();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTotalTime = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.sbTime = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTime)).BeginInit();
            this.SuspendLayout();
            // 
            // bntAbrir
            // 
            this.bntAbrir.Location = new System.Drawing.Point(5, 352);
            this.bntAbrir.Name = "bntAbrir";
            this.bntAbrir.Size = new System.Drawing.Size(75, 23);
            this.bntAbrir.TabIndex = 0;
            this.bntAbrir.Text = "Abrir";
            this.bntAbrir.UseVisualStyleBackColor = true;
            this.bntAbrir.Click += new System.EventHandler(this.bntAbrir_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Location = new System.Drawing.Point(86, 352);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(75, 23);
            this.btnReproducir.TabIndex = 1;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.Location = new System.Drawing.Point(168, 351);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(75, 23);
            this.btnPausa.TabIndex = 2;
            this.btnPausa.Text = "Pausa";
            this.btnPausa.UseVisualStyleBackColor = true;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(249, 351);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 3;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // sbVolumen
            // 
            this.sbVolumen.Location = new System.Drawing.Point(327, 353);
            this.sbVolumen.Name = "sbVolumen";
            this.sbVolumen.Size = new System.Drawing.Size(245, 18);
            this.sbVolumen.TabIndex = 4;
            this.sbVolumen.Value = 50;
            this.sbVolumen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbVolumen_Scroll);
            // 
            // trackList
            // 
            this.trackList.FormattingEnabled = true;
            this.trackList.Location = new System.Drawing.Point(5, 382);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(567, 82);
            this.trackList.TabIndex = 5;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(5, 10);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(567, 286);
            this.mediaPlayer.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTotalTime
            // 
            this.lbTotalTime.AutoSize = true;
            this.lbTotalTime.Location = new System.Drawing.Point(534, 302);
            this.lbTotalTime.Name = "lbTotalTime";
            this.lbTotalTime.Size = new System.Drawing.Size(34, 13);
            this.lbTotalTime.TabIndex = 8;
            this.lbTotalTime.Text = "00:00";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(10, 301);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(34, 13);
            this.lbTime.TabIndex = 9;
            this.lbTime.Text = "00:00";
            // 
            // sbTime
            // 
            this.sbTime.Location = new System.Drawing.Point(50, 301);
            this.sbTime.Name = "sbTime";
            this.sbTime.Size = new System.Drawing.Size(478, 45);
            this.sbTime.TabIndex = 10;
            this.sbTime.Scroll += new System.EventHandler(this.sbTime_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(581, 483);
            this.Controls.Add(this.sbTime);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbTotalTime);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.trackList);
            this.Controls.Add(this.sbVolumen);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.bntAbrir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAbrir;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.HScrollBar sbVolumen;
        private System.Windows.Forms.ListBox trackList;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTotalTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TrackBar sbTime;
    }
}

