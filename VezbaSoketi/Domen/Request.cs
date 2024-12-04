using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Request
    {
        public RequestType Type { get; set; }
        public object Data { get; set; }

        public override string ToString()
        {
            return Type.ToString() + " " + Data?.ToString();
        }
    }
}
