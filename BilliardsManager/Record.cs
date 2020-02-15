using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardsManager
{
    [Serializable]
    public class Record
    {
        public int id { get; set; }
        public String date { get; set; }
        public String type { get; set; }
        public int entry { get; set; }
        public int expense { get; set; }

        public Record(int id,String date,String type,int entry, int expense)
        {
            this.id = id;
            this.date = date;
            this.type = type;
            this.entry = entry;
            this.expense = expense;
        }
    }
}
