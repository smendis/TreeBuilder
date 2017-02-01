using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'treeDataSet._Relations' table. You can move, or remove it, as needed.
            this.relationsTableAdapter.Fill(this.treeDataSet._Relations);
            // TODO: This line of code loads data into the 'treeDataSet.Part' table. You can move, or remove it, as needed.
            this.partTableAdapter.Fill(this.treeDataSet.Part);

        }

        private TreeEntities db;
        private Dictionary<int, string> parts;

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();

            db = new TreeEntities();
            parts = new Dictionary<int, string>();

            var list = db.Part.ToList();
            foreach (var item in list)
            {
                parts.Add(item.Id, item.Name.Trim());
            }

            var temp = db.Relations.Select(i => i.Id).Distinct().ToList();
            List<int> roots = new List<int>();
            foreach (var i in list)
            {
                if (!temp.Contains(i.Id))
                {
                    roots.Add(i.Id);
                }
            }

            foreach (var root in roots)
            {
                TreeNode node = this.treeView1.Nodes.Add(parts[root]);
                AddNode(root, node);
            }
        }

        private void AddNode(int parentId, TreeNode parent)
        {
            var children = db.Relations.Where(i => i.ParentId == parentId).Select(i => i.Id).ToList();
            foreach (var child in children)
            {
                TreeNode node = parent.Nodes.Add(parts[child]);
                AddNode(child, node);
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            if(btnExpand.Text == "Expand")
            {
                treeView1.ExpandAll();
                btnExpand.Text = "Collapse";
            }
            else
            {
                treeView1.CollapseAll();
                btnExpand.Text = "Expand";
            }
        }
    }
}
