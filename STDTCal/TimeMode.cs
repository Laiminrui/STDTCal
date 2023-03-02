using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STDTCal
{
    internal class TimeMode
    {
        public int index;//模型序号=>对应工作内容序号
        public string Belongs;//归属(于哪个工作项)
        public string Name;//名称
        public List<(int, string)> formula;//公式 <顺序，内容>
    }
}
