using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1.BLL
{
    public class LoadFile
    {
        public List<string> Load(string path)
        {
            //StreamReader sr = new StreamReader(path, Encoding.Default);
            //string line;
            //List<string> list = new List<string>();

            //while ((line = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(line.ToString());
            //    list.Add(line.ToString());
            //}
            //if (list == null)
            //{
            //    return null;
            //}
            //else
            //{
            //    Console.WriteLine(list);
            //    return list;
            //}

            // 测试EF与数据库连接
            new DAL.GetData();
            return new List<string>();
        }
    }
}
