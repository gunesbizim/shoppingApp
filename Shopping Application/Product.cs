using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Application
{
    public class Product
    {
        string pid;
        string name;
        string details;
        Image image;
        int price;
        string category;
        string hp;
        UInt32 imagesize;
        
        //Details will come as an dictionary from db you ll deserialize it bySetDetailsOneByOne
        //When you are comparing them to send db, add one by one by using textboxes ;)
        public List<string> a;
        public Product()
        {

        }
        public Product(string pid,string Name, string Details,Bitmap image,int price,string category,string hp,UInt32 imagesize)
        {
            this.pid = pid;
            this.name = Name;
            this.details = Details;
            this.image = image;
            this.price = price;
            this.category = category;
            this.hp = hp;
            this.imagesize = imagesize;
        }
        public string getName()
        {
            return name;
        }
        public string getDetails()
        {
            return details;
        }
        public string getPid()
        {
            return pid;
        }
        public Image getImage()
        {
            return image;
        }
        public int getPrice()
        {
            return price;
        }
        public string getCategory()
        {
            return category;
        }
        public string getHP()
        {
            return hp;
        }
        public UInt32 getImageSize()
        {
            return imagesize;
        }
        public void setName(string Name)
        {
            this.name = Name;
        }
        public void setDetails(string Details)
        {
            this.details = Details;
        }
        public void setDetailsOneByOne()
        {
            //Dictionary test code
            var dictionary = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> pair in dictionary)
            {
               // Console.WriteLine("FOREACH KEYVALUEPAIR: {0}, {1}", pair.Key, pair.Value);
            }
        }
        public void setpid(string pid)
        {
            this.pid = pid;
        }
        public void setImage(Image image)
        {
            this.image = image;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
        public void setCategory(string category)
        {
            this.category = category;
        }
        public void setHP(string hp)
        {
            this.hp = hp;
        }
        public void setImageSize(UInt32 imagesize)
        {
            this.imagesize = imagesize;
        }
        public Image ByteArrayToImage(byte[] imageByte)
        {
            MemoryStream ms = new MemoryStream(imageByte);
            Image image = Image.FromStream(ms);
            return image;
        }

    }
}
