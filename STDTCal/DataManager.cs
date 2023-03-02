using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STDTCal
{
    internal class DataManager
    {
        /// <summary>
        /// 这里存储工时数据
        /// </summary>
        public static ObservableCollection<StandardTimeData> TimeList = new ObservableCollection<StandardTimeData>();
    }
}
