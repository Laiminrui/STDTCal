using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STDTCal
{
    /// <summary>
    /// 工时编辑窗口
    /// </summary>
    public partial class TimeListEditForm : Form
    {
        public TimeListEditForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 导入按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportButton_Click(object sender, EventArgs e)
        {
            string FilePath = "";
            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.Multiselect = false;//不允许选择多个文件
            dialog.Title = "请选择导入的文件";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FilePath = dialog.FileName;
                DataTable dt = new DataTable();
                if (!FileManager.ImportExcel(FilePath, FileManager.ImportATSInfomationExcel, out dt))
                {
                    //System.Windows.MessageBox.Show("导入失败，请检查数据源", "操作提示", MessageBoxButton.OK, MessageBoxImage.Error);
                    MessageBox.Show("导入失败");
                }
                else
                {
                    ATSDataTableToList(dt);
                }
            }
        }

        private bool ATSDataTableToList(DataTable dt)
        {
            ObservableCollection<StandardTimeData> templist = new ObservableCollection<StandardTimeData>();
            foreach (DataRow dr in dt.Rows)
            {
                StandardTimeData temp = new StandardTimeData();
                temp.WorkProject = dr["工作项"].ToString();
                temp.WorkContent = dr["工作内容"].ToString();
                temp.WorkTime = dr["工作量"].ToString();
                temp.Remark = dr["备注"].ToString();
                templist.Add(temp);
            }
            DataManager.TimeList = templist;
            dataGridView1.DataSource = templist;
            //StandardTimeData
            //DataManager.signalData.LoadData_Signal();//加载新的数据
            //signal_show = DeepClone.Copy<ObservableCollection<SignalData_SignalDataClass>>(DataManager.signalData.Signal_List);
            //signal_show_temp = DeepClone.Copy<ObservableCollection<SignalData_SignalDataClass>>(signal_show);
            //SignalUpdatedIndexList.Clear();
            //dataGridView1.DataSource = DataManager.TimeList;
            return true;
        }
        /// <summary>
        /// 这里进行数据的初始化操作，例如datagridview的数据绑定，绑定的datatable的初始化操作。
        /// </summary>
        private void DataInit()
        {
            //先处理datatable
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataSource = DataManager.TimeList;
        }

        private void TimeListEditForm_Load(object sender, EventArgs e)
        {
            DataInit();
        }
    }
}
