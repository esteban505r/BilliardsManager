using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardsManager
{
    public class Conector
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
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS confs (id integer primary key autoincrement, name varchar(20), value varchar(20));";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public Boolean firstConf()
        {
            sqlite_conn.Open();
            sqlite_cmd.CommandText = "SELECT * FROM confs WHERE name='first_open'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            if (!sqlite_datareader.HasRows)
            {
                sqlite_datareader.Close();
                sqlite_cmd.CommandText = "INSERT INTO confs (name,value) VALUES (@name,@value)";
                sqlite_cmd.Parameters.AddWithValue("@name", "first_open");
                sqlite_cmd.Parameters.AddWithValue("@value", "false");
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT INTO admins (user,password) VALUES (@user,@password)";
                sqlite_cmd.Parameters.AddWithValue("@user", "admin");
                sqlite_cmd.Parameters.AddWithValue("@password", "admin");
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();
                return true;
            }
            else
            {
                sqlite_datareader.Close();
                sqlite_conn.Close();
                return false;
            }
            
        }

        public Boolean changeAdminPassword(String user,String password, String newUser, String newPassword)
        {
            sqlite_conn.Open();
            sqlite_cmd.CommandText = "SELECT * FROM admins WHERE user=@user AND password=@password";
            sqlite_cmd.Parameters.AddWithValue("@user", user);
            sqlite_cmd.Parameters.AddWithValue("@password",password);
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            if (sqlite_datareader.HasRows)
            {
                sqlite_datareader.Close();
                sqlite_cmd.CommandText = "UPDATE admins SET user = @newUser , password = @newPassword WHERE user=@user AND password=@password";
                sqlite_cmd.Parameters.AddWithValue("@user", user);
                sqlite_cmd.Parameters.AddWithValue("@newUser", newUser);
                sqlite_cmd.Parameters.AddWithValue("@password", password);
                sqlite_cmd.Parameters.AddWithValue("@newPassword", newPassword);
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();
                return true;
            }
            else
            {
                sqlite_datareader.Close();
                sqlite_conn.Close();
                return false;
            }
         
        }

        public void insertProducto(Producto producto)
        {
            sqlite_conn.Open();
            sqlite_cmd.CommandText = sqlite_cmd.CommandText = "INSERT INTO productos (name,precio,type) VALUES(@name,@precio,@type);";
            sqlite_cmd.Parameters.AddWithValue("@name", producto.getName());
            sqlite_cmd.Parameters.AddWithValue("@precio", producto.getPrecio());
            sqlite_cmd.Parameters.AddWithValue("@type", producto.getType());
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
            sqlite_datareader.Close();
            sqlite_conn.Close();   
            return productos;
        }

        public void saveProductos(List<Producto> productos)
        {
            sqlite_conn.Open();
            for (int i = 0; i < productos.Count; i++)
            {
                sqlite_cmd.CommandText = "INSERT INTO productos (name,precio,type) VALUES(@name,@precio,@type);";
                sqlite_cmd.Parameters.AddWithValue("@name", productos[i].getName());
                sqlite_cmd.Parameters.AddWithValue("@precio", productos[i].getPrecio());
                sqlite_cmd.Parameters.AddWithValue("@type", productos[i].getType());
                sqlite_cmd.ExecuteNonQuery();
            }
            sqlite_conn.Close();
        }


        public void saveProductos(List<Producto> productos,Boolean replace)
        {
            sqlite_conn.Open();
            if (replace == true)
            {
                sqlite_cmd.CommandText = "DELETE FROM productos";
                sqlite_cmd.ExecuteNonQuery();
            }
            for (int i = 0; i < productos.Count; i++)
            {
                sqlite_cmd.CommandText = "INSERT INTO productos (name,precio,type) VALUES(@name,@precio,@type);";
                sqlite_cmd.Parameters.AddWithValue("@name", productos[i].getName());
                sqlite_cmd.Parameters.AddWithValue("@precio", productos[i].getPrecio());
                sqlite_cmd.Parameters.AddWithValue("@type", productos[i].getType());
                sqlite_cmd.ExecuteNonQuery();
            }
            sqlite_conn.Close();
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
            sqlite_datareader.Close();
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
            sqlite_datareader.Close();
            sqlite_conn.Close();
            return confs;
        }


    }
}
