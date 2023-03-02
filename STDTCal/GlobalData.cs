using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace STDTCal
{
    /// <summary>
    /// 存储一些公共的数据
    /// </summary>
    internal class GlobalData
    {
        /// <summary>
        /// 线路名称
        /// </summary>
        private string _LineName;

        /// <summary>
        /// 总工时
        /// </summary>
        private string _ToltalTime;

        /// <summary>
        /// 线路名称操作
        /// </summary>
        public string LineName 
        {
            get { return _LineName; }
            set { _LineName = value; }
        }

        /// <summary>
        /// 线路总工时操作
        /// </summary>
        public string ToltalTime
        {
            get { return _ToltalTime; }
            set { _ToltalTime = value; }
        }
    }
}
