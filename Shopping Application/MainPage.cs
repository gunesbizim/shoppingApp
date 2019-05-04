using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Application
{
    public partial class MainPage : UserControl
    {
        List<Product> choosenHp;
        Form1 f1;
        public MainPage(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            DbConnection conn = new DbConnection();
            List<Product> hpAll = conn.getHotProducts();
            choosenHp = new List<Product>();
            int size = hpAll.Count;
            Random r = new Random();
            setCategories();
            int i;
            for (i = 0; i < 3; i++)
            {
                choosenHp.Add(hpAll[r.Next(0, size)]);
            }
            setHotProducts(hp1_pb,hp1_name,hp1_details,choosenHp,0);
            setHotProducts(hp2_pb, hp2_name, hp2_details, choosenHp, 1);
            setHotProducts(hp3_pb, hp3_name, hp3_details, choosenHp, 2);
            


        }

        private void setHotProducts(PictureBox pb, LinkLabel name, Label details,List<Product> lp, int i)
        {
            pb.Image = lp[i].getImage();
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            name.Text = lp[i].getName();
            adminAddProduct aap = new adminAddProduct();
            Dictionary<string, string> dictionary1 = aap.deserializeString(choosenHp[0].getDetails());
            aap.Dispose();
            details.Text = generateDictionaryString(dictionary1);
            

        }
        public void setCategories()
        {
            DbConnection conn = new DbConnection();
            List<string>categories = conn.getCategories();
            int y = 0;
            int i;
            for (i = 0; i < categories.Count; i++)
            {
                categoryGP cat = new categoryGP(categories[i],f1);
                cat.Location = new Point(0,y);
                categoriesGP.Controls.Add(cat);
                y += 20;
            }

        }

        public string generateDictionaryString(Dictionary<string, string> item)
        {
            StringBuilder builder = new StringBuilder();
            foreach (KeyValuePair<string, string> pair in item)
            {
                builder.Append(pair.Key).Append(": ").Append(pair.Value).Append("\n");
            }
            string result = builder.ToString();
            // Remove the final comma
            result = result.TrimEnd(',');
            return result;
        }


    }
}
