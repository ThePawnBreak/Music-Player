namespace Mp3_Player
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxSearchedFile = new System.Windows.Forms.TextBox();
            this.listResults = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for text";
            // 
            // tboxSearchedFile
            // 
            this.tboxSearchedFile.Location = new System.Drawing.Point(15, 25);
            this.tboxSearchedFile.Name = "tboxSearchedFile";
            this.tboxSearchedFile.Size = new System.Drawing.Size(339, 20);
            this.tboxSearchedFile.TabIndex = 1;
            this.tboxSearchedFile.TextChanged += new System.EventHandler(this.tboxSearchedFile_TextChanged);
            this.tboxSearchedFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxSearchedFile_KeyPress);
            // 
            // listResults
            // 
            this.listResults.FormattingEnabled = true;
            this.listResults.Location = new System.Drawing.Point(15, 64);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(339, 238);
            this.listResults.TabIndex = 2;
            this.listResults.DoubleClick += new System.EventHandler(this.listResults_DoubleClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(342, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 341);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.tboxSearchedFile);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "Jump to file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxSearchedFile;
        private System.Windows.Forms.ListBox listResults;
        private System.Windows.Forms.Button btnCancel;
    }
}