using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STDTCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 新建工程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectNew(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 打开工程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectOpen(object sender, EventArgs e) 
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//不允许选择多个文件
            dialog.Title = "请选择导入的文件";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var temp = FileManager.ReadFile(dialog.FileName);
                label1.Text = temp.ToString();//测试成功
            }

        }
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectSave(object sender, EventArgs e)
        {
            //FileManager.Path = "";
            FileManager.SaveFile("123.dat", "12");
            MessageBox.Show("success");
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, EventArgs e)
        {

        }

        private void 工时编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeListEditForm timeListEditForm = new TimeListEditForm();
            timeListEditForm.ShowDialog();
        }
    }
}
