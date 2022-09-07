using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parent_Child
{
    public partial class Child : Form
    {
        public Child(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        Form parent;

        private void Child_Load(object sender, EventArgs e)
        {
            var textBox = this.parent.Controls[0] as TextBox;

            textBox.TextChanged += (s, e) =>
            {
                this.textBox1.Text = textBox.Text;
            };

        }
    }
}
