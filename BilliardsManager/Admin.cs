using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardsManager
{
    [Serializable]
    public class Admin
    {
        public int id { get; set; }
        public String user { get; set; }
        public String password { get; set; }
        public Admin(int id,String user,String password)
        {
            this.id = id;
            this.user = user;
            this.password = password;
        }
    }
}
