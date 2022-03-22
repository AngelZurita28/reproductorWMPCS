using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace reproductorWMPCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] rutas, archivos;
        private void bntAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio o Video|*.mp3;*.mp4;*.mov;*.mkv;" +
                                    "*.wmv;*.wav;*.flac;*.m4a";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivos = openFileDialog.SafeFileNames;
                rutas = openFileDialog.FileNames;
                for (int x = 0; x < archivos.Length; x++)
                {
                    trackList.Items.Add(archivos[x]);
                }
            }
        }
        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediaPlayer.URL = rutas[trackList.SelectedIndex];
            mediaPlayer.Ctlcontrols.play();
            timer1.Start();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.play();
        }        
        private void btnPausa_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.pause();
        }
        private void btnDetener_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.stop(); 
        }
        
        
        private void sbTime_Scroll(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.currentPosition = sbTime.Value;
        }

        private void sbVolumen_Scroll(object sender, ScrollEventArgs e)
        {
            mediaPlayer.settings.volume = sbVolumen.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                sbTime.Maximum = (int)mediaPlayer.Ctlcontrols.currentItem.duration;
                sbTime.Value = (int)mediaPlayer.Ctlcontrols.currentPosition;
            }
            lbTime.Text = mediaPlayer.Ctlcontrols.currentPositionString;
            lbTotalTime.Text = mediaPlayer.Ctlcontrols.currentItem.durationString;
        }

    }
}
