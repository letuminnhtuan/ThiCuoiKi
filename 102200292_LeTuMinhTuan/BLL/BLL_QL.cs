using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200292_LeTuMinhTuan.BLL
{
    public class BLL_QL
    {
        private static BLL_QL _Instance;
        public static BLL_QL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_QL();
                return _Instance;
            }
            private set { }
        }
        private BLL_QL()
        {

        }
    }
}
