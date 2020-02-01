using System;

namespace BilliardsManager
{
    [Serializable]
    public class Producto
    {
        private int id;
        private String name;
        private int precio;
        private String type;

        public Producto(int id,String name,int precio,String type)
        {
            this.id = id;
            this.name = name;
            this.precio = precio;
            this.type = type;
        }

        public String getName()
        {
            return name;
        }

        public int getID()
        {
            return id;
        }

        public int getPrecio()
        {
            return precio;
        }

        public String getType()
        {
            return type;
        }

        public void setName(String name)
        {
            this.name = name;
        }
        
        public void setPrecio(int precio)
        {
            this.precio = precio;
        }public void setID(int id)
        {
            this.id = id;
        }
        
        public void setType(String type)
        {
            this.type = type;
        }
    }
}
