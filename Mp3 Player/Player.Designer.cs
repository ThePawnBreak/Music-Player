namespace Mp3_Player
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.btnPause = new System.Windows.Forms.Button();
            this.tbarVolume = new System.Windows.Forms.TrackBar();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPlayPreviousFile = new System.Windows.Forms.Button();
            this.btnPlayNextFile = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.tbarProgress = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPause
            // 
            this.btnPause.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPause.Location = new System.Drawing.Point(43, 112);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(27, 26);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "S";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // tbarVolume
            // 
            this.tbarVolume.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbarVolume.AutoSize = false;
            this.tbarVolume.Location = new System.Drawing.Point(212, 112);
            this.tbarVolume.Maximum = 100;
            this.tbarVolume.Name = "tbarVolume";
            this.tbarVolume.Size = new System.Drawing.Size(153, 26);
            this.tbarVolume.TabIndex = 2;
            this.tbarVolume.TickFrequency = 10;
            this.tbarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbarVolume.Scroll += new System.EventHandler(this.tbarVolume_Scroll);
            this.tbarVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbarVolume_MouseDown);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AllowDrop = true;
            this.lblFilePath.BackColor = System.Drawing.Color.Silver;
            this.lblFilePath.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(12, 9);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(353, 25);
            this.lblFilePath.TabIndex = 3;
            this.lblFilePath.Text = "Song Name";
            // 
            // btnPlay
            // 
            this.btnPlay.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPlay.Location = new System.Drawing.Point(15, 112);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(23, 26);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPlayPreviousFile
            // 
            this.btnPlayPreviousFile.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPlayPreviousFile.Location = new System.Drawing.Point(76, 112);
            this.btnPlayPreviousFile.Name = "btnPlayPreviousFile";
            this.btnPlayPreviousFile.Size = new System.Drawing.Size(28, 26);
            this.btnPlayPreviousFile.TabIndex = 5;
            this.btnPlayPreviousFile.Text = "<";
            this.btnPlayPreviousFile.UseVisualStyleBackColor = true;
            this.btnPlayPreviousFile.Click += new System.EventHandler(this.btnPlayPreviousFile_Click);
            // 
            // btnPlayNextFile
            // 
            this.btnPlayNextFile.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPlayNextFile.Location = new System.Drawing.Point(110, 112);
            this.btnPlayNextFile.Name = "btnPlayNextFile";
            this.btnPlayNextFile.Size = new System.Drawing.Size(28, 26);
            this.btnPlayNextFile.TabIndex = 6;
            this.btnPlayNextFile.Text = ">";
            this.btnPlayNextFile.UseVisualStyleBackColor = true;
            this.btnPlayNextFile.Click += new System.EventHandler(this.btnPlayNextFile_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAddFolder.Location = new System.Drawing.Point(144, 112);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(28, 26);
            this.btnAddFolder.TabIndex = 7;
            this.btnAddFolder.Text = "+";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // tbarProgress
            // 
            this.tbarProgress.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbarProgress.AutoSize = false;
            this.tbarProgress.Location = new System.Drawing.Point(12, 154);
            this.tbarProgress.Maximum = 1000;
            this.tbarProgress.Name = "tbarProgress";
            this.tbarProgress.Size = new System.Drawing.Size(353, 26);
            this.tbarProgress.TabIndex = 8;
            this.tbarProgress.TickFrequency = 10;
            this.tbarProgress.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbarProgress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbarProgress_MouseUp);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(377, 192);
            this.Controls.Add(this.tbarProgress);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.btnPlayNextFile);
            this.Controls.Add(this.btnPlayPreviousFile);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.tbarVolume);
            this.Controls.Add(this.btnPause);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Player";
            this.Text = "Orange";
            this.LocationChanged += new System.EventHandler(this.Player_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TrackBar tbarVolume;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPlayPreviousFile;
        private System.Windows.Forms.Button btnPlayNextFile;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.TrackBar tbarProgress;
    }
}

