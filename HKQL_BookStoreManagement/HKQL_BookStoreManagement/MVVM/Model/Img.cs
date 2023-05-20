using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKQL_BookStoreManagement.MVVM.ViewModel
{
    public class Img
    {
        public Data data { get; set; }
        public string _id { get; set; }
    }

    public class Data
    {
        public string type { get; set; }
        public Byte[] data { get; set; }
    }
}