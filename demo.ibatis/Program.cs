using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace demo.ibatis
{
    class Program
    {
        static void Main(string[] args)
        {

           var products = BaseDA.QueryForList<TeldOrder>("GetOrderalls");
           //关联查询
            var ss = BaseDA.QueryForList<tempref>("gettempall");
            Console.WriteLine(ss.Count);
            var order = new TeldOrder()
            {
                ID = "55",
                Code = "TeldSD001",
                Price = new decimal(119.76),
                Quantity = 100,
                Creator = "zhougq",
                LastModifier = ""
              
            };
            // BaseDA.Insert<TeldOrder>("SaveOrder", order);
            //BaseDA.Delete("DeleteOrder", "66");

        }
    }
}
