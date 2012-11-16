using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace VistaButtonTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private VistaButton vistaButton1;
		private VistaButton vistaButton2;
		private VistaButtonTest.VistaButton vistaButton3;
		private VistaButtonTest.VistaButton vistaButton4;
		private VistaButtonTest.VistaButton vistaButton5;
		private VistaButtonTest.VistaButton vistaButton6;
		private VistaButtonTest.VistaButton vistaButton7;
		private VistaButtonTest.VistaButton vistaButton8;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.vistaButton1 = new VistaButtonTest.VistaButton();
			this.vistaButton2 = new VistaButtonTest.VistaButton();
			this.vistaButton3 = new VistaButtonTest.VistaButton();
			this.vistaButton4 = new VistaButtonTest.VistaButton();
			this.vistaButton5 = new VistaButtonTest.VistaButton();
			this.vistaButton6 = new VistaButtonTest.VistaButton();
			this.vistaButton7 = new VistaButtonTest.VistaButton();
			this.vistaButton8 = new VistaButtonTest.VistaButton();
			this.SuspendLayout();
			// 
			// vistaButton1
			// 
			this.vistaButton1.BackColor = System.Drawing.Color.Transparent;
			this.vistaButton1.ButtonText = "Default";
			this.vistaButton1.Location = new System.Drawing.Point(40, 8);
			this.vistaButton1.Name = "vistaButton1";
			this.vistaButton1.Size = new System.Drawing.Size(136, 40);
			this.vistaButton1.TabIndex = 0;
			// 
			// vistaButton2
			// 
			this.vistaButton2.BackColor = System.Drawing.Color.Transparent;
			this.vistaButton2.BackImage = ((System.Drawing.Image)(resources.GetObject("vistaButton2.BackImage")));
			this.vistaButton2.BaseColor = System.Drawing.Color.Transparent;
			this.vistaButton2.ButtonText = "Image";
			this.vistaButton2.Location = new System.Drawing.Point(208, 8);
			this.vistaButton2.Name = "vistaButton2";
			this.vistaButton2.Size = new System.Drawing.Size(128, 40);
			this.vistaButton2.TabIndex = 0;
			// 
			// vistaButton3
			// 
			this.vistaButton3.BackColor = System.Drawing.Color.Transparent;
			this.vistaButton3.BaseColor = System.Drawing.Color.Transparent;
			this.vistaButton3.ButtonColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(211)), ((System.Byte)(40)));
			this.vistaButton3.ButtonStyle = VistaButtonTest.VistaButton.Style.Flat;
			this.vistaButton3.ButtonText = "Yes (hover)";
			this.vistaButton3.Image = ((System.Drawing.Image)(resources.GetObject("vistaButton3.Image")));
			this.vistaButton3.Location = new System.Drawing.Point(40, 96);
			this.vistaButton3.Name = "vistaButton3";
			this.vistaButton3.Size = new System.Drawing.Size(136, 40);
			this.vistaButton3.TabIndex = 0;
			// 
			// vistaButton4
			// 
			this.vistaButton4.BackColor = System.Drawing.Color.Transparent;
			this.vistaButton4.BaseColor = System.Drawing.Color.Transparent;
			this.vistaButton4.ButtonColor = System.Drawing.Color.FromArgb(((System.Byte)(210)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.vistaButton4.ButtonStyle = VistaButtonTest.VistaButton.Style.Flat;
			this.vistaButton4.ButtonText = "No (hover)";
			this.vistaButton4.Image = ((System.Drawing.Image)(resources.GetObject("vistaButton4.Image")));
			this.vistaButton4.Location = new System.Drawing.Point(208, 96);
			this.vistaButton4.Name = "vistaButton4";
			this.vistaButton4.Size = new System.Drawing.Size(136, 40);
			this.vistaButton4.TabIndex = 0;
			// 
			// vistaButton5
			// 
			this.vistaButton5.BackColor = System.Drawing.Color.Transparent;
			this.vistaButton5.BaseColor = System.Drawing.Color.Transparent;
			this.vistaButton5.ButtonColor = System.Drawing.Color.FromArgb(((System.Byte)(210)), ((System.Byte)(202)), ((System.Byte)(0)));
			this.vistaButton5.ButtonText = "Transparent";
			this.vistaButton5.GlowColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(189)), ((System.Byte)(141)));
			this.vistaButton5.Location = new System.Drawing.Point(208, 184);
			this.vistaButton5.Name = "vistaButton5";
			this.vistaButton5.Size = new System.Drawing.Size(136, 40);
			this.vistaButton5.TabIndex = 0;
			// 
			// vistaButton6
			// 
			this.vistaButton6.BackColor = System.Drawing.Color.Transparent;
			this.vistaButton6.BaseColor = System.Drawing.Color.Transparent;
			this.vistaButton6.ButtonColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(163)), ((System.Byte)(211)));
			this.vistaButton6.ButtonText = "Transparent";
			this.vistaButton6.Location = new System.Drawing.Point(40, 184);
			this.vistaButton6.Name = "vistaButton6";
			this.vistaButton6.Size = new System.Drawing.Size(136, 40);
			this.vistaButton6.TabIndex = 0;
			// 
			// vistaButton7
			// 
			this.vistaButton7.BackColor = System.Drawing.Color.Transparent;
			this.vistaButton7.BaseColor = System.Drawing.Color.Transparent;
			this.vistaButton7.ButtonColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(211)), ((System.Byte)(40)));
			this.vistaButton7.ButtonText = "Rounded Corners";
			this.vistaButton7.CornerRadius = 20;
			this.vistaButton7.GlowColor = System.Drawing.Color.FromArgb(((System.Byte)(141)), ((System.Byte)(255)), ((System.Byte)(189)));
			this.vistaButton7.Location = new System.Drawing.Point(40, 288);
			this.vistaButton7.Name = "vistaButton7";
			this.vistaButton7.Size = new System.Drawing.Size(136, 40);
			this.vistaButton7.TabIndex = 0;
			// 
			// vistaButton8
			// 
			this.vistaButton8.BackColor = System.Drawing.Color.Transparent;
			this.vistaButton8.BaseColor = System.Drawing.Color.Transparent;
			this.vistaButton8.ButtonColor = System.Drawing.Color.FromArgb(((System.Byte)(210)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.vistaButton8.ButtonText = "Sharp Corners";
			this.vistaButton8.CornerRadius = 0;
			this.vistaButton8.GlowColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(141)), ((System.Byte)(189)));
			this.vistaButton8.Location = new System.Drawing.Point(208, 288);
			this.vistaButton8.Name = "vistaButton8";
			this.vistaButton8.Size = new System.Drawing.Size(136, 40);
			this.vistaButton8.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(384, 364);
			this.Controls.Add(this.vistaButton1);
			this.Controls.Add(this.vistaButton2);
			this.Controls.Add(this.vistaButton3);
			this.Controls.Add(this.vistaButton4);
			this.Controls.Add(this.vistaButton5);
			this.Controls.Add(this.vistaButton6);
			this.Controls.Add(this.vistaButton7);
			this.Controls.Add(this.vistaButton8);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Vista Button Test";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
