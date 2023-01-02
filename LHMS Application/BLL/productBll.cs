using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.BLL
{
    internal class ProductBll
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ProductCode { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public decimal rate { get; set; }
        public decimal qty { get; set; }
        public string Type { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
