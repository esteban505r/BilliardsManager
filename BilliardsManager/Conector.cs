using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardsManager
{
    class Conector
    {
        SQLiteConnection sqlite_conn;

        SQLiteCommand sqlite_cmd;

        SQLiteDataReader sqlite_datareader;


        public Conector()
        {
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS productos (id integer primary key autoincrement, name varchar(20),precio integer, type varchar(20));";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS admins (id integer primary key autoincrement, user varchar(20), password varchar(20));";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS confs (id integer primary key autoincrement, name varchar(20), value varchar(20),requireAdmin boolean);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public void insertProducto(Producto producto)
        {
            sqlite_conn.Open();
            sqlite_cmd.CommandText = "INSERT INTO productos (name,precio,type) VALUES("+producto.getName()+","+producto.getPrecio()+","+producto.getType()+");";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public List<Producto> getProductos() 
        {
            sqlite_conn.Open();
            List<Producto> productos = new List<Producto>();
            sqlite_cmd.CommandText = "SELECT * FROM productos";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read()) 
            {
                int id = sqlite_datareader.GetInt32(0);
                string nombre = sqlite_datareader.GetString(1);
                int precio = sqlite_datareader.GetInt32(2);
                string tipo = sqlite_datareader.GetString(3);

                Producto p = new Producto(id,nombre, precio, tipo);
                productos.Add(p);
            }
            sqlite_conn.Close();
            return productos;
        }

        public List<Admin> getAdmins()
        {
            sqlite_conn.Open();
            List<Admin> admins = new List<Admin>();
            sqlite_cmd.CommandText = "SELECT * FROM admins";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string user = sqlite_datareader.GetString(1);
                string password = sqlite_datareader.GetString(2);

                Admin a = new Admin(id, user, password);
                admins.Add(a);
            }
            sqlite_conn.Close();
            return admins;
        } 
        
        public List<Conf> getConfs()
        {
            sqlite_conn.Open();
            List<Conf> confs = new List<Conf>();
            sqlite_cmd.CommandText = "SELECT * FROM confs";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                int id = sqlite_datareader.GetInt32(0);
                string name = sqlite_datareader.GetString(1);
                string value = sqlite_datareader.GetString(2);
                Boolean requireAdmin = sqlite_datareader.GetBoolean(3);

                Conf a = new Conf(id, name, value,requireAdmin);
                confs.Add(a);
            }
            sqlite_conn.Close();
            return confs;
        }


    }
}
