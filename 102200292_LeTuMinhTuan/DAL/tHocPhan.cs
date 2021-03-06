using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200292_LeTuMinhTuan.DAL
{
    [Table("HocPhan")]
    public class tHocPhan
    {
        [Key]
        public string MaHocPhan { get; set; }
        public string TenHocPhan { get; set; }

        public tHocPhan()
        {
            this.SV_HPs = new HashSet<tSV_HP>();
        }

        public virtual ICollection<tSV_HP> SV_HPs { get; set; }
    }
}
