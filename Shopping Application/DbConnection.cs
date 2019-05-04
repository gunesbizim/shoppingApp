using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Shopping_Application
{
    class DbConnection
    {
        public MySqlConnection connection;
        public string server;
        public string port;
        public string database;
        public string uid;
        public string password;


        public DbConnection()
        {
            Initialize();
        }


        public void Initialize()
        {
            server = "remotemysql.com";
            port = "3306";
            database = "BLT7l3jWWZ";
            uid = "BLT7l3jWWZ";
            password = "ZsxK3GuZ7Q";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        public bool OpenConnection()
        {

            try
            {
                connection.Open();
                Console.WriteLine("Connection success");
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:

                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }


        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Connection successfuly closed ! ");
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool sendCommand(String query)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    Console.WriteLine("Query proccessed.");
                    return true;

                }
                else
                {
                    Console.WriteLine("Query couldn't proccessed.");
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                return false;
            }
        }
        public string insertUserCmd(string uid, string email, string pass, bool isAdmin)
        {
            string userDet = "INSERT INTO `users` (`uid`,`email`,`password`,`admin`) VALUES (" + "'" + uid + "'" + "," + "'" + email + "'" + "," + "'" + pass + "'" + "," + "'" + isAdmin + "'" + ");";

            return userDet;
        }
        public string[] getUserCmd(string email)
        {
            string query = @"SELECT uid,email,password,admin FROM users WHERE email=" + "'" + email + "'";
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                string[] test = new string[5];
                //Read the data and store them in the array

                while (dataReader.Read())
                {

                    test[0] = (dataReader["uid"].ToString());
                    test[1] = (dataReader["email"].ToString());
                    test[2] = (dataReader["password"].ToString());
                    test[3] = (dataReader["admin"].ToString());
                }


                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();
                //return list to be displayed

                return test;
            }
            else
            {
                return null;
            }
        }

        public bool checkEmailIsRegistered(string email)
        {
            string query = @"SELECT email FROM users WHERE email=" + "'" + email + "'";
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                string emailReturn = "";
                while (dataReader.Read())
                {
                    emailReturn = (dataReader["email"].ToString());
                }
                dataReader.Close();
                this.CloseConnection();
                if (emailReturn == email)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }
        }
        public bool insertProduct(string pid, string name, string description, byte[] img, string price, string category, string hp, UInt32 imageSize)
        {

            string SQL = "INSERT INTO `products` VALUES(@pid, @name, @description, @image, @price, @category, @hp, @imagesize)";
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand("", connection);
                    Console.WriteLine(cmd.CommandText);
                    cmd.CommandText = SQL;
                    Console.WriteLine(cmd.CommandText);
                    cmd.Parameters.AddWithValue("@pid", pid);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@image", img);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@hp", hp);
                    cmd.Parameters.AddWithValue("@imagesize", imageSize);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Query processed !");
                    return true;
                }
                else
                {
                    Console.WriteLine("Query couldn't proccessed.");
                    return false;

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
                return false;
            }

        }
        public string insertCategory(string category)
        {
            string categoryDet = "INSERT INTO `categories` (`categoryName`) VALUES (" + "'" + category + "'" + ");";

            return categoryDet;
        }
        public List<string> getCategories()
        {
            List<string> categories = new List<string>();
            string query = @"SELECT categoryName FROM categories;";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    categories.Add(dataReader["categoryName"].ToString());
                }
                dataReader.Close();
                this.CloseConnection();
                return categories;
            }
            else
            {
                return null;

            }
        }
        public string updateCategory(string categoryNameOld, string categoryNameNew)
        {
            string query = @"UPDATE categories SET categoryName='" + categoryNameNew + "' WHERE categoryName='" + categoryNameOld + "';";

            return query;
        }
        public List<Product> getHotProducts()
        {
            List<Product> hotProducts = new List<Product>();
            string query = @"SELECT pid,name,description,image,price,category,hp,imagesize FROM products WHERE hp='True';";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Product hp = new Product();
                    hp.setpid(dataReader["pid"].ToString());
                    hp.setName(dataReader["name"].ToString());
                    hp.setDetails(dataReader["description"].ToString());
                    string price = dataReader["price"].ToString();
                    price.Trim();
                    hp.setPrice(Int32.Parse(price));
                    byte[] a = (byte[])dataReader["image"];
                    hp.setImage(hp.ByteArrayToImage(a));
                    hp.setCategory(dataReader["category"].ToString());
                    hp.setHP(dataReader["hp"].ToString());
                    hotProducts.Add(hp);
                }
                this.CloseConnection();
            }
            return hotProducts;
        }

        public List<Product> getProductsFromCat(string catName, int start, int count)
        {
            List<Product> products = new List<Product>();
            string query = @"SELECT pid,name,description,image,price,category,hp,imagesize FROM products WHERE category='" + catName + "' " + "LIMIT " + start + "," + count + ";";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Product p = new Product();
                    p.setpid(dataReader["pid"].ToString());
                    p.setName(dataReader["name"].ToString());
                    p.setDetails(dataReader["description"].ToString());
                    p.setPrice(Int32.Parse(dataReader["price"].ToString()));
                    byte[] a = (byte[])dataReader["image"];
                    p.setImage(p.ByteArrayToImage(a));
                    p.setCategory(dataReader["category"].ToString());
                    p.setHP(dataReader["hp"].ToString());
                    products.Add(p);
                    Console.WriteLine("Product added to list !");
                }
                this.CloseConnection();
            }
            return products;
        }
        public List<Product> getAllProducts()
        {
            List<Product> products = new List<Product>();
            string query = @"SELECT pid,name,description,image,price,category,hp,imagesize FROM products;";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Product p = new Product();
                    p.setpid(dataReader["pid"].ToString());
                    p.setName(dataReader["name"].ToString());
                    p.setDetails(dataReader["description"].ToString());
                    string price = dataReader["price"].ToString();
                    price.Trim();
                    p.setPrice(Int32.Parse(price));
                    byte[] a = (byte[])dataReader["image"];
                    p.setImage(p.ByteArrayToImage(a));
                    p.setCategory(dataReader["category"].ToString());
                    p.setHP(dataReader["hp"].ToString());
                    products.Add(p);
                }
                this.CloseConnection();
            }
            return products;

        }
        public string deleteFromProducts(string pid)
        {
            string query = "DELETE FROM products WHERE pid='" + pid + "'";

            return query;
        }
        public List<Product> searchProduct(string like)
        {
            List<Product> products = new List<Product>();
            string query = "SELECT * FROM products WHERE name LIKE '%' '" + like + "' '%' ";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Product p = new Product();
                    p.setpid(dataReader["pid"].ToString());
                    p.setName(dataReader["name"].ToString());
                    p.setDetails(dataReader["description"].ToString());
                    string price = dataReader["price"].ToString();
                    price.Trim();
                    p.setPrice(Int32.Parse(price));
                    byte[] a = (byte[])dataReader["image"];
                    p.setImage(p.ByteArrayToImage(a));
                    p.setCategory(dataReader["category"].ToString());
                    p.setHP(dataReader["hp"].ToString());
                    products.Add(p);
                }
                this.CloseConnection();
            }
            return products;
        }
        public bool updateProduct(string pid, string name, string description, byte[] img, string price, string category, string hp, UInt32 imageSize)
        {
            string SQL = "UPDATE products SET pid=@pid, name=@name, description=@description, image=@image, price=@price, category=@category, hp=@hp, imagesize=@imagesize WHERE pid='" + pid + "';";
            try
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand("", connection);
                    Console.WriteLine(cmd.CommandText);
                    cmd.CommandText = SQL;
                    Console.WriteLine(cmd.CommandText);
                    cmd.Parameters.AddWithValue("@pid", pid);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@image", img);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@hp", hp);
                    cmd.Parameters.AddWithValue("@imagesize", imageSize);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Query processed !");
                    return true;
                }
                else
                {
                    Console.WriteLine("Query couldn't proccessed.");
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
                return false;
            }

        }
    }
}
