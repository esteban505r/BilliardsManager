using System.Windows.Forms;

namespace BilliardsManager
{
    class ProductoButton : Button
    {
        public Producto producto { get; set; }
        public ProductoButton(Producto producto) : base()
        {
            this.producto = producto;

        }
    }
}
