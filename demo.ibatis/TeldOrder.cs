using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.ibatis
{

    /// <summary>
    /// 销售订单
    /// </summary>
    [Serializable]
    public class TeldOrder
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Creator { get; set; }
        public DateTime CreateTime { get; set; }
        public string LastModifier { get; set; }
        public DateTime LastModifyTime { get; set; }
    }
}
