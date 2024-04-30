namespace KeyPressedPresentationExample
{
	partial class frmKeyPressExample
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
			this.movableSquare = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.movableSquare)).BeginInit();
			this.SuspendLayout();
			// 
			// movableSquare
			// 
			this.movableSquare.BackColor = System.Drawing.Color.DodgerBlue;
			this.movableSquare.Location = new System.Drawing.Point(352, 190);
			this.movableSquare.Name = "movableSquare";
			this.movableSquare.Size = new System.Drawing.Size(50, 50);
			this.movableSquare.TabIndex = 0;
			this.movableSquare.TabStop = false;
			// 
			// frmKeyPressExample
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.movableSquare);
			this.KeyPreview = true;
			this.Name = "frmKeyPressExample";
			this.Text = "KeyPress Example";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmKeyPressExample_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.movableSquare)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox movableSquare;
	}
}

