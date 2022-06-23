using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200292_LeTuMinhTuan.DTO
{
    public class CBBItem
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public override string ToString()
        {
            return Value;
        }
    }
}
