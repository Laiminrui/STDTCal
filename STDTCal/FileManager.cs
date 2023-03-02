using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;

namespace STDTCal
{
    //写个委托，分页导入专业标准工时
    public delegate DataTable ImportExcelFile(ISheet sheet);

    /// <summary>
    /// 此处进行本地文件的保存和excel表格的导入
    /// </summary>
    internal class FileManager
    {
        /// <summary>
        /// 这里是文件路径
        /// </summary>
        public static string Path;
        /// <summary>
        /// 序列化存储
        /// </summary>
        /// <param name="name">文件名</param>
        /// <param name="obj">被存储的对象</param>
        public static void SaveFile(string name, object obj)
        {
            try
            {
                IFormatter serializer = new BinaryFormatter();
                FileStream savefile = new FileStream(Path + name, FileMode.Create, FileAccess.Write);
                serializer.Serialize(savefile, obj);
                savefile.Close();
                savefile.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 反序列化读取文件
        /// </summary>
        /// <param name="name">文件名</param>
        /// <returns></returns>
        public static object ReadFile(string name)
        {
            try
            {
                IFormatter serializer = new BinaryFormatter();
                FileStream loadfile = new FileStream(Path + name, FileMode.Open, FileAccess.Read);
                var obj = serializer.Deserialize(loadfile);
                loadfile.Close();
                loadfile.Dispose();
                return obj;
            }
            catch (Exception e)
            {
                //AssistanceFunctions.log.LogWrite(e);//记录异常
                MessageBox.Show("本地缓存文件" + name + "出错or不存在，请删除后重新计算");
                //throw new Exception("本地缓存文件" + name + "出错or不存在，请删除后重新计算");
                throw e;
            }
        }

        /// <summary>
        /// 导入excel文件
        /// </summary>
        /// <param name="filepath">文件路径</param>
        /// <param name="ief">传进来的导入方法</param>
        /// <returns></returns>
        public static bool ImportExcel(string filepath, ImportExcelFile ief, out DataTable dt)
        {
            try
            {
                IWorkbook workbook;
                string extension = System.IO.Path.GetExtension(filepath);//获取excel文件的扩展名
                FileStream fs = File.OpenRead(filepath);
                if (extension.Equals(".xls"))
                {
                    workbook = new HSSFWorkbook(fs);//把xls文件中的数据写入workbook中
                }
                else
                {
                    workbook = new XSSFWorkbook(fs);//把xlsx文件中的数据写入workbook中
                }
                fs.Close();
                ISheet sheet = workbook.GetSheetAt(0);
                dt = ief(sheet);//根据按钮传进来的导入函数的不同，读取方式也不同
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                dt = null;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 导入ATS表格的信息/似乎所有子系统的都可以？
        /// </summary>
        /// <param name="sheet"></param>
        /// <returns></returns>
        public static DataTable ImportATSInfomationExcel(ISheet sheet)
        {
            DataTable dt = new DataTable();
            int NotEmptyCellCount = 0;
            dt.TableName = "ATS工时标准";//这里定义表头
            dt.Columns.Add("工作项", typeof(string));
            dt.Columns.Add("工作内容", typeof(string));
            dt.Columns.Add("工作量", typeof(string));
            dt.Columns.Add("备注", typeof(string));
            for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)//将每一行数据导入到DataTable中
            {
                DataRow dr = dt.NewRow();
                var item = sheet.GetRow(i);
                //NotEmptyCellCount = item.FirstCellNum;
                if (item.GetCell(NotEmptyCellCount) == null)
                    break;
                dr["工作项"] = item.GetCell(NotEmptyCellCount);
                dr["工作内容"] = item.GetCell(NotEmptyCellCount + 1);
                dr["工作量"] = item.GetCell(NotEmptyCellCount + 2);
                dr["备注"] = item.GetCell(NotEmptyCellCount + 3);
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
