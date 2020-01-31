using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardsManager
{
    public class Producto
    {
        private String name;
        private int precio;
        private String type;

        public Producto(String name,int precio,String type)
        {
            this.name = name;
            this.precio = precio;
            this.type = type;
        }

        public String getName()
        {
            return name;
        }

        public int getPrecio()
        {
            return precio;
        }

        public String getType()
        {
            return type;
        }
    }
}
