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
    public partial class Form1 : Form
    {
        int stripCounter = 3;

        public Form1()
        {
            InitializeComponent();
            child = new Child(this);
            child.Show();

            ColorDialog colorDialog = new();
            colorDialog.ShowDialog();

            BackColor = colorDialog.Color;

            var newItem = new ToolStripMenuItem();
            newItem.Name = stripCounter.ToString();
            newItem.Text = stripCounter.ToString();
            newItem.MouseHover += MHoover;
            toolStripMenuItem4.DropDownItems.Add(newItem);
        }

        void MHoover(object s,EventArgs e)
        {
            var newSubItem = new ToolStripMenuItem();
            newSubItem.Name = stripCounter.ToString();
            newSubItem.Text = stripCounter.ToString();
            newSubItem.Width = 10;
            var sender = s as ToolStripMenuItem;
            stripCounter++;
            newSubItem.MouseHover += MHoover;
            sender.DropDownItems.Add(newSubItem);
        }

        Child child;

        private void Form1_Load(object sender, EventArgs e)
        {
            child.Controls[0].TextChanged += (s, e) =>
            {
                this.textBox1.Text = child.Controls[0].Text;
            };
        }
    }
}
