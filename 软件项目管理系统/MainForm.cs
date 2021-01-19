using System;
using System.Configuration;
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

            string fileSuffix = ConfigurationManager.AppSettings["ProjectFileSuffix"].ToString();

            openProjectFileDialog.Filter = $"(*.{fileSuffix})|";


            if(openProjectFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"文件名称:{openProjectFileDialog.FileName}");
            }
        }
    }
}
