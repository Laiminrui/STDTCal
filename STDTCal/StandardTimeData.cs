using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace STDTCal
{
    [Serializable]
    public class StandardTimeData
    {
        /// <summary>
        /// 子系统名称
        /// </summary>
        private string _subsystem;
        /// <summary>
        /// 工作项
        /// </summary>
        private string _workproject;
        /// <summary>
        /// 工作内容
        /// </summary>
        private string _workcontent;
        /// <summary>
        /// 工作量
        /// </summary>
        private List<(string, double)> _worktime;
        /// <summary>
        /// 界面显示的工时数据
        /// </summary>
        private string _worktime_show;
        /// <summary>
        /// 备注
        /// </summary>
        private string _remark;
        /// <summary>
        /// 子系统操作
        /// </summary>
        public string Subsystem
        {
            get { return _subsystem; } 
            set { _subsystem = value; }
        }
        /// <summary>
        /// 工作项操作
        /// </summary>
        public string WorkProject
        {
            get { return _workproject; }
            set { _workproject = value; }
        }
        /// <summary>
        /// 工作内容操作
        /// </summary>
        public string WorkContent
        {
            get { return _workcontent; }
            set { _workcontent = value; }
        }
        /// <summary>
        /// 工作量操作
        /// </summary>
        public string WorkTime
        {
            get { return _worktime_show.ToString(); }
            set
            {
                if (_worktime == null)
                {
                    _worktime = new List<(string, double)> ();//第一次打开则初始化
                }
                string[] StrArray = value.Split('/', '*');
                for (int i = 0; i < StrArray.Count(); i++)
                {
                    double Num = 0;
                    //string NumStr = Regex.Replace(StrArray[i], @"[^0-9]+", "");//匹配数字
                    string NumStr = Regex.Match(StrArray[i], @"^\d*").ToString();
                    if (NumStr == "")
                        Num = 1;//如果没写数字
                    else
                        Num=double.Parse(NumStr);
                    string UnitName = Regex.Match(StrArray[i],@"[^0-9]+").ToString();//匹配所有非数字
                    (string, double) temp = (UnitName, Num);
                    _worktime.Add(temp);//添加一个数值
                    _worktime_show = _worktime_show + Num + UnitName;//这里赋值界面的显示
                    if (i != StrArray.Count() - 1)
                        _worktime_show += '/';
                    //千万要遵守命名规范啊，数字+名称，或者不写数字直接名称
                }
            }
        }
        /// <summary>
        /// 备注操作
        /// </summary>
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
    }
}
