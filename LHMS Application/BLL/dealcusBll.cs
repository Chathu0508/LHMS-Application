using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMS_Application.BLL
{
    internal class DealCusBll
    {
        public int id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public DateTime add_date { get; set; }
        public int added_by { get; set; }
    }
}
