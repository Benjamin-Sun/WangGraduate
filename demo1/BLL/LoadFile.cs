using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo1.DAL;

namespace demo1.BLL
{
    public class LoadFile
    {
        public List<nacarsdata01> Load()
        {
            return new DAL.GetData().selectAll();
        }
    }
}
