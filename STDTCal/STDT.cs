using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace STDTCal
{
    internal class STDT
    {
        public int index = 0;//序号
        public string Subsystem;//子系统
        public string WorkProject;//工作项，子系统中的子项目名称，如ATS的试车线调试
        public string WorkContent;//工作内容
        public List<(string, double)> WorkUnit;//工作单元
        public string Remark;//备注

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_subsystem">子系统</param>
        /// <param name="_workproject">工作项</param>
        /// <param name="_workcontent">工作内容</param>
        /// <param name="_workunit">工作单元</param>
        private STDT(string _subsystem, string _workproject, string _workcontent, List<(string, double)> _workunit)
        {
            this.index++;
            this.Subsystem = _subsystem;
            this.WorkProject = _workproject;
            this.WorkContent = _workcontent;
            this.WorkUnit = _workunit;
        }

    }
}
