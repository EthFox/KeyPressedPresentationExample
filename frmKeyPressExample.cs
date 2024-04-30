using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPressedPresentationExample
{
	public partial class frmKeyPressExample : Form
	{
		public frmKeyPressExample()
		{
			InitializeComponent();
		}

		private void frmKeyPressExample_KeyPress(object sender, KeyPressEventArgs e)
		{                  // e represents the KeyPressEventArgs ^
			char KeyPressed = e.KeyChar; // get the key pressed as a character
			Point squareLoc = movableSquare.Location; // get the location of the player's square
			// !!! Have to use a seperate point as the offset method does NOT reference the object, rather it just creates a copy of the location point !!! \\
			switch (KeyPressed) // switch case is an easy way to test for different key presses
			{
				case 'w':
					squareLoc.Offset(0, -50); // move the point the desired amount in the desired direction
					break;
				case 'a':
					squareLoc.Offset(-50, 0);
					break;
				case 's':
					squareLoc.Offset(0, 50);
					break;
				case 'd':
					squareLoc.Offset(50, 0);
					break;
				case '\u001b': // keys that do not have an equivalent char are stored in unicode, this is the 'escape' key
					this.Close(); // close the form
					break;
			}
			movableSquare.Location = squareLoc; // move the player's square to the offset point
		}
	}
}
