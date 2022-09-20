using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TreeExample
{
    public partial class Form1 : Form
    {
        string initialDir = @"C:\1";

        public Form1()
        {
            InitializeComponent();
            TreeNode nodeDir = new TreeNode(initialDir);
            AddNodes(nodeDir, initialDir);

            treeView1.Nodes.Add(nodeDir);
        }

        private void AddNodes(TreeNode node, string directory)
        {
            foreach (var dir in Directory.GetDirectories(node.Text))
            {
                TreeNode nodeDir = new TreeNode(dir);
                AddNodes(nodeDir, dir);
                foreach (var file in Directory.GetFiles(node.Text))
                {

                    nodeDir.Nodes.Add(new TreeNode(file));

                }

                treeView1.Nodes.Add(nodeDir);

            }

        }
    }
}
