using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;

namespace G4MotnTestApi
{
    public class ExcelHelper
    {
        //导出
        public static void ExportExcel<T>(List<T> list)
        {
            string filePath = $@"D:\ExcelHelperExport{DateTime.Now.ToString("yyyyMMddHHmmss")}.xls";
            // 获取数据类型
            Type type = typeof(T);
            //获取所有的属性
            var pList = type.GetProperties();
            //创建book
            HSSFWorkbook book = new HSSFWorkbook();
            //创建sheet
            ISheet sheet = book.CreateSheet("sheet1");
            //添加表头
            IRow row = sheet.CreateRow(0);
            for(int i=0;i<pList.Length;i++)
            {
                row.CreateCell(i).SetCellValue(pList[i].Name);
            }
            //添加内容
            for(int i=0;i<list.Count;i++)
            {
                row = sheet.CreateRow(i + 1);
                for(int j=0;j<pList.Length;j++)
                {
                    row.CreateCell(j).SetCellValue(pList[j].GetValue(list[i])!=null? pList[j].GetValue(list[i]).ToString():"");
                }
            }
            //写文件
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                book.Write(fs);
            }
        }

        public static List<T> ImportExcel<T>(string filePath)
        {
            Type type = typeof(T);
            var pList = type.GetProperties();
            List<T> list = new List<T>();
            //打开文件
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                //根据文件流创建工作本
                HSSFWorkbook book = new HSSFWorkbook(fs);
                //获取工作本里的sheet
                ISheet sheet = book.GetSheetAt(0);
                //获取内容
                IRow row = null;
                for(int i=0;i<sheet.LastRowNum;i++)
                {
                    row = sheet.GetRow(i + 1);
                    //赋值
                    T t = (T)Activator.CreateInstance(type);
                    for(int j=0;j<pList.Length;j++)
                    {
                        var value = row.GetCell(j).StringCellValue;
                        if (pList[j].PropertyType.FullName == "System.Int32")
                        {
                            pList[j].SetValue(t, !string.IsNullOrEmpty(value) ? Convert.ToInt32(value) : 0);
                        }
                        else if(pList[j].PropertyType.FullName == "System.DateTime")
                        {
                            pList[j].SetValue(t, !string.IsNullOrEmpty(value) ? Convert.ToDateTime(value) : DateTime.Now);
                        }
                        else
                        {
                            pList[j].SetValue(t, value);
                        }
                    }
                    list.Add(t);
                }
            }
            return list;
        }
    }
}