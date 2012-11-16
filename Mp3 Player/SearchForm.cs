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
    public partial class SearchForm : Form
    {
        private List<Song> songList;
        private Playlist playlist;
        private Dictionary<int, int> indexDict;

        private int resultCount;

        public SearchForm(Playlist newPlaylist)
        {
            InitializeComponent();

            playlist = newPlaylist;
            songList = playlist.songs;
        }

        private void tboxSearchedFile_TextChanged(object sender, EventArgs e)
        {
            BindingList<string> results = new BindingList<string>();
            Dictionary<int, int> resultsToSongs = new Dictionary<int,int>();
            int resultIndex = 0;

            for(int i = 0; i < songList.Count; i++)
            {
                Song song = songList[i];
                string filename = song.GetFilename().ToLower();
                string stringToFind = tboxSearchedFile.Text.ToLower();

                if (filename.Contains(stringToFind))
                {
                    results.Add(filename);
                    resultsToSongs[resultIndex] = i;
                    resultIndex++;
                }                
            }

            listResults.DataSource = results;
            indexDict = resultsToSongs;
            resultCount = resultIndex;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listResults_DoubleClick(object sender, EventArgs e)
        {
            PlaySelectedFile();
            this.Close();
        }

        private void PlaySelectedFile()
        {
            int index = listResults.SelectedIndex;
            playlist.index = indexDict[index];
            playlist.PlaySelectedFile();
        }

        private void tboxSearchedFile_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == (char)Keys.Return)
            {
                PlaySelectedFile();
                this.Close();
            }            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Down)
            {
                if (listResults.SelectedIndex < resultCount - 1)
                    listResults.SelectedIndex++;
                return true;
            }

            if (keyData == Keys.Up)
            {
                if (listResults.SelectedIndex > 0)
                    listResults.SelectedIndex--;
                return true;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }        
    }
}
