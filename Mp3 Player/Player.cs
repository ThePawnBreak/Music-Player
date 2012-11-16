using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace Mp3_Player
{
    public partial class Player : Form
    {
        protected IrrKlang.ISoundEngine irrKlangEngine;
        protected IrrKlang.ISound currentlyPlayingSound;

        protected string currentPathname;

        private Playlist playlist;

        Timer timer;

        public Player()
        {
            InitializeComponent();

            irrKlangEngine = new IrrKlang.ISoundEngine();

            tbarVolume.Value = 100;

            playlist = new Playlist(this);
            this.AddOwnedForm(playlist);
            playlist.Show();
            UpdatePlaylistPosition();

            timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 500;
            timer.Tick += new EventHandler(tbarProgress_Update);            
        }

        public void PlaySong(string pathname, string filename)
        {
            currentPathname = pathname;

            lblFilePath.Text = filename;

            tbarProgress.Value = 0;

            PlaySelectedFile();
        }

        private void PlaySelectedFile()
        {
            // stop currently playing sound

            if (currentlyPlayingSound != null)
                currentlyPlayingSound.Stop();

            // start new sound

            currentlyPlayingSound = irrKlangEngine.Play2D(currentPathname, true);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            currentlyPlayingSound.Paused = !currentlyPlayingSound.Paused;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (currentlyPlayingSound != null)
            {
                currentlyPlayingSound.Paused = false;
            }

            playlist.PlaySelectedFile();
        }

        private void tbarVolume_Scroll(object sender, EventArgs e)
        {
            if(currentlyPlayingSound != null)
                currentlyPlayingSound.Volume = tbarVolume.Value / 100.0f;
        }

        private void UpdatePlaylistPosition()
        {
            Point position = new Point(this.Right, this.Top);
            playlist.Location = position;
        }

        private void Player_LocationChanged(object sender, EventArgs e)
        {
            UpdatePlaylistPosition();
        }

        private void btnPlayPreviousFile_Click(object sender, EventArgs e)
        {
            try
            {
                playlist.PlayPreviousFile();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void btnPlayNextFile_Click(object sender, EventArgs e)
        {
            try
            {
                playlist.PlayNextFile();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                playlist.DisplayFolder(folderBrowser.SelectedPath);
            }
        }

        private void tbarProgress_MouseUp(object sender, MouseEventArgs e)
        {
            double dblValue;

            // Jump to the clicked location
            dblValue = ((double)e.X / (double)tbarProgress.Width) * (tbarProgress.Maximum - tbarProgress.Minimum);
            tbarProgress.Value = Convert.ToInt32(dblValue);

            // Jump to position in song
            float percent = (float)tbarProgress.Value / (float)tbarProgress.Maximum;
            currentlyPlayingSound.PlayPosition = (uint)(percent * currentlyPlayingSound.PlayLength);
        }

        private void tbarProgress_Update(object sender, EventArgs e)
        {
            if (currentlyPlayingSound != null)
            {
                float percent = (float)currentlyPlayingSound.PlayPosition / (float)currentlyPlayingSound.PlayLength;
                float progress_position = percent * tbarProgress.Maximum;
                tbarProgress.Value = (int)progress_position;
            }
        }

        private void tbarVolume_MouseDown(object sender, MouseEventArgs e)
        {
            double dblValue;

            // Jump to the clicked location
            dblValue = ((double)e.X / (double)tbarVolume.Width) * (tbarVolume.Maximum - tbarVolume.Minimum);
            tbarVolume.Value = Convert.ToInt32(dblValue);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Space)
            {
                playlist.OpenSearchForm();
                return true; //for the active control to see the keypress, return false
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }        
    }
}
