using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.BLL
{
    internal class inventorybll
    {
        public int inventoryid { get; set; }
        public int category_id { get; set; }
        public int product_id { get; set; }
        public int total_qty { get; set; }
        public int assign_qty { get; set; }
        public int leftover_qty { get; set; }
        public DateTime Added_date { get; set; }
        public int added_by { get; set; }
    }
}
