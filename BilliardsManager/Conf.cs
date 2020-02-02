using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardsManager
{
    [Serializable]
    public class Conf
    {
        public int id { get; set; }
        public String name { get; set; }
        public String value { get; set; }
        public Boolean requireAdmin { get; set; }

        public Conf(int id,String name, String value, Boolean requireAdmin)
        {
            this.id = id;
            this.name = name;
            this.value = value;
            this.requireAdmin = requireAdmin;
        }
    }
}
