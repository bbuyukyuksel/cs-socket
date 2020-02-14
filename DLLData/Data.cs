using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLData
{
    
    public class Data
    {
        public enum DataType
        {
            Text,
            Image,
        }
        public DataType type { get; set; }
        public string content;
    }

    public class ProcessData
    {

    }
}
