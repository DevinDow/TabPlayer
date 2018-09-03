namespace TabPlayer
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
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnWishYouWereHere = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(12, 12);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.Location = new System.Drawing.Point(13, 42);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(75, 23);
			this.btnPlay.TabIndex = 1;
			this.btnPlay.Text = "Play";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnWishYouWereHere
			// 
			this.btnWishYouWereHere.Location = new System.Drawing.Point(130, 12);
			this.btnWishYouWereHere.Name = "btnWishYouWereHere";
			this.btnWishYouWereHere.Size = new System.Drawing.Size(150, 23);
			this.btnWishYouWereHere.TabIndex = 2;
			this.btnWishYouWereHere.Text = "Wish You Were Here";
			this.btnWishYouWereHere.UseVisualStyleBackColor = true;
			this.btnWishYouWereHere.Click += new System.EventHandler(this.btnWishYouWereHere_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.btnWishYouWereHere);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.btnOpen);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnWishYouWereHere;
	}
}

