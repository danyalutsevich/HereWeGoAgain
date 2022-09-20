using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewExample
{
    public partial class Form1 : Form
    {

        ListView listView;
        
        public Form1()
        {
            InitializeComponent();

            listView = new ListView();
            listView.Parent = this;
            listView.Dock = DockStyle.Top;
            listView.Location = new System.Drawing.Point(0, 0);
            listView.Size = new System.Drawing.Size(292, 130);
            listView.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.CheckBoxes = true;

            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Name";
            columnHeader1.TextAlign = HorizontalAlignment.Left;
            columnHeader1.Width = 246;

            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Cost";
            columnHeader2.TextAlign = HorizontalAlignment.Left;
            columnHeader2.Width = 246;

            listView.Columns.Add(columnHeader1);
            listView.Columns.Add(columnHeader2);

            ListViewItem listItem = new ListViewItem("WATER",0);
            listItem.Checked = true;
            listItem.SubItems.Add("0.50");
            listView.Items.Add(listItem);

            ListViewItem listItem1 = new ListViewItem("Attack Helicopter",1);
            listItem1.Checked = true;
            listItem1.SubItems.Add("150000");
            listView.Items.Add(listItem1);

            ListViewItem listItem2 = new ListViewItem("Dog",2);
            listItem2.Checked = true;
            listItem2.SubItems.Add("50");
            listView.Items.Add(listItem2);


            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            imageListSmall.Images.Add(Bitmap.FromFile("water.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile("water.bmp"));
            imageListSmall.Images.Add(Bitmap.FromFile("helicopter.jpg"));
            imageListLarge.Images.Add(Bitmap.FromFile("helicopter.jpg"));
            imageListSmall.Images.Add(Bitmap.FromFile("dog.jpg"));
            imageListLarge.Images.Add(Bitmap.FromFile("dog.jpg"));

            listView.LargeImageList = imageListLarge;
            listView.SmallImageList = imageListSmall;



        }
    }
}
