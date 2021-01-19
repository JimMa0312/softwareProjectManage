using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 软件项目管理系统
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 选择项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openProjectFileDialog = new OpenFileDialog();

            openProjectFileDialog.Filter = "(*.pjt)|";


            if(openProjectFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"文件名称:{openProjectFileDialog.FileName}");
            }
        }
    }
}
