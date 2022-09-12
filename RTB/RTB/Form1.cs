using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Image img =new Bitmap(@"C:\Users\luche\Desktop\The Garden of Earthly Delights.jpg");
            Clipboard.SetImage(img);
            richTextBox1.Paste();
            Clipboard.SetText("This is Text");
            richTextBox1.Paste();

        }

    }
}
