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
    public partial class Playlist : Form
    {
        public List<Song> songs = new List<Song>();

        private Player player;

        public int index;
        public int currentlyPlayingIndex;

        public Playlist(Player new_player)
        {
            InitializeComponent();

            DisplayFolder("E:\\Music");

            player = new_player;

            listPlaylist.DrawItem += new DrawItemEventHandler(listPlaylist_DrawItem);
            listPlaylist.MouseWheel += new MouseEventHandler(listPlaylist_MouseWheel);
            this.DoubleBuffered = true;
            this.AllowDrop = true;
        }

        private void listPlaylist_MouseWheel(object sender, MouseEventArgs e)
        {
            int sign = (e.Delta > 0) ? 1 : -1;
            listPlaylist.TopIndex -= (int)(sign * 5);
            ((HandledMouseEventArgs)e).Handled = true;
        }        

        public void DisplayFolder(string folderPath)
        {
            GetPathnames(folderPath);
            RefreshData();
        }

        public void PlaySelectedFile()
        {
            player.PlaySong(songs[index].GetPathname(), songs[index].GetFilename());
            currentlyPlayingIndex = index;
            listPlaylist.Refresh();
        }

        public void PlayNextFile()
        {
            index = currentlyPlayingIndex + 1;
            PlaySelectedFile();
        }

        public void PlayPreviousFile()
        {
            index = currentlyPlayingIndex - 1;
            PlaySelectedFile();
        }

        private void RefreshData()
        {
            BindingList<string> files = new BindingList<string>();

            int i = 1;
            foreach (Song song in songs)
            {
                files.Add(i.ToString() + ". " + song.GetFilename());
                i++;
            }
            listPlaylist.DataSource = files;
        }

        private void GetPathnames(string folderPath)
        {
            foreach (string pathname in System.IO.Directory.GetFiles(folderPath, "*.mp3"))
            {
                songs.Add(new Song(pathname));
            }

            foreach (string directory in System.IO.Directory.GetDirectories(folderPath))
            {
                GetPathnames(directory);
            }
        }

        private void listPlaylist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PlaySelectedFile();
        }        

        private void listPlaylist_DragDrop(object sender, DragEventArgs e)
        {
            string directoryName = (string)e.Data.GetData(DataFormats.FileDrop);

            DisplayFolder(directoryName);
        }

        private void listPlaylist_Click(object sender, EventArgs e)
        {
            MouseEventArgs args = (MouseEventArgs)e;
            index = listPlaylist.IndexFromPoint(args.X, args.Y);
        }

        private void listPlaylist_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Choose selection color
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor, Color.DimGray);

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.OldLace;

            // Determine the color of the brush to draw each item based 
            // on the index of the item to draw.
            
            if (e.Index == currentlyPlayingIndex)
            {
                myBrush = Brushes.Orange;
            }
            
            string text = "";
            if (e.Index >= 0)
            {
                text = listPlaylist.Items[e.Index].ToString();
            }

            // Draw the current item text based on the current Font 
            // and the custom brush settings.
            e.Graphics.DrawString(text,
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void listPlaylist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                OpenSearchForm();
            }
        }

        public void OpenSearchForm()
        {
            SearchForm searchForm = new SearchForm(this);
            searchForm.Show();
        }        
    }
}
