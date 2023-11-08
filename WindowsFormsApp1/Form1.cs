using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        WMPLib.IWMPPlaylist playlist;
        private void Player_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void abrir_Click(object sender, EventArgs e)
        {
            ofdAbrir.Title = "Abrir mídia";
            ofdAbrir.Filter = "Arquivo mp4|*.mp4|Arquivo mp3|*.mp3";
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("Lista");

                foreach (var arquivo in ofdAbrir.FileNames)
                {
                    playlist.appendItem(axWindowsMediaPlayer1.newMedia(arquivo));
                    op.Items.Add(arquivo);


                    axWindowsMediaPlayer1.currentPlaylist = playlist;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
        }
    }
}


   

