namespace Mp3_Player
{
    partial class Playlist
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
            this.listPlaylist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listPlaylist
            // 
            this.listPlaylist.AllowDrop = true;
            this.listPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPlaylist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listPlaylist.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPlaylist.ForeColor = System.Drawing.Color.OldLace;
            this.listPlaylist.FormattingEnabled = true;
            this.listPlaylist.IntegralHeight = false;
            this.listPlaylist.ItemHeight = 18;
            this.listPlaylist.Location = new System.Drawing.Point(0, 0);
            this.listPlaylist.Name = "listPlaylist";
            this.listPlaylist.Size = new System.Drawing.Size(546, 714);
            this.listPlaylist.TabIndex = 1;
            this.listPlaylist.Click += new System.EventHandler(this.listPlaylist_Click);
            this.listPlaylist.DragDrop += new System.Windows.Forms.DragEventHandler(this.listPlaylist_DragDrop);
            this.listPlaylist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listPlaylist_KeyPress);
            this.listPlaylist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPlaylist_MouseDoubleClick);
            // 
            // Playlist
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(546, 714);
            this.ControlBox = false;
            this.Controls.Add(this.listPlaylist);
            this.Name = "Playlist";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Playlist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listPlaylist;

    }
}