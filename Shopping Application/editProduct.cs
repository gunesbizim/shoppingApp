using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Application
{
    public partial class editProduct : Form
    {
        Product p;
        DbConnection conn;
        Dictionary<string, string> newDetails;
        public string imageLocation;
        byte[] rawData;
        FileStream fs;
        UInt32 FileSize;
        adminProduct ap;
        public editProduct(Product p,adminProduct ap)
        {
            InitializeComponent();
            this.p = p;
            this.ap = ap;
            conn = new DbConnection();
            setCategories(conn.getCategories());
            pictureBox1.Image = p.getImage();
            nameTB.Text = p.getName();
            priceTB.Text = p.getPrice().ToString();
            findCat(p.getCategory());
            newDetails = new Dictionary<string, string>();
            setProperties();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            isHP(p.getHP());
            
            
            
            
        }

        public Dictionary<string, string> deserializeString(string s)
        {
            Dictionary<string, string> item = new Dictionary<string, string>();
            string[] tokens = s.Split(new char[] { ':', ',' },
           StringSplitOptions.RemoveEmptyEntries);
            // Walk through each item
            for (int i = 0; i < tokens.Length; i += 2)
            {
                string name = tokens[i];
                string freq = tokens[i + 1];
                // Fill the value in the sorted dictionary
                if (item.ContainsKey(name))
                {
                    item[name] += freq;
                }
                else
                {
                    item.Add(name, freq);
                }
            }
            return item;
        }
        public void setCategories(List<string> categories)
        {
            int i;
            int size = categories.Count;
            for(i = 0; i<size; i++)
            {
                comboBox1.Items.Add(categories[i]);
            }   
        }
        public void findCat(string cat)
        {
            int i = 0;
            int size = comboBox1.Items.Count;
            for(i=0; i < size; i++)
            {
                if(cat == comboBox1.GetItemText(comboBox1.Items[i]))
                {
                    comboBox1.SelectedIndex = i;
                }   
            }
        }
        public void setProperties()
        {
           Dictionary<string,string> prop =  deserializeString(p.getDetails());
            int y = 0;
            foreach (KeyValuePair<string, string> pair in prop)
            {
                editProductDetail epd = new editProductDetail(pair.Key,pair.Value,this);
                epd.Location = new Point(0,y);
                panel1.Controls.Add(epd);
                y += 31;
            }
        }
        public void addToNewDictionary(string key,string value)
        {
            newDetails.Add(key,value);
        }

        private void applyBT_Click(object sender, EventArgs e)
        {
            conn.updateProduct(p.getPid(),nameTB.Text,generateDictionaryString(newDetails),rawData,priceTB.Text,comboBox1.GetItemText(comboBox1.SelectedIndex),p.getHP(),FileSize);
            ap.refresh();
            this.Dispose();
        }

        private void browseImgBT_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Select Image";
            opd.Filter = "jpg files (*.jpg)|*.jpg";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                // Create a new Bitmap object from the picture file on disk,
                // and assign that to the PictureBox.Image property
                pictureBox1.Image = new Bitmap(opd.FileName);
                imageLocation = opd.FileName;
                fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                FileSize = (UInt32)fs.Length;
                rawData = new byte[FileSize];
                fs.Read(rawData, 0, (int)FileSize);
                fs.Close();
                p.setImage(p.ByteArrayToImage(rawData));
            }
        }
        public void isHP(string hp)
        {
            if(hp == "True")
            {
                hpCB.Checked = true;
            }
        }
        public string generateDictionaryString(Dictionary<string, string> item)
        {
            StringBuilder builder = new StringBuilder();
            foreach (KeyValuePair<string, string> pair in item)
            {
                builder.Append(pair.Key).Append(":").Append(pair.Value).Append(',');
            }
            string result = builder.ToString();
            // Remove the final comma
            result = result.TrimEnd(',');
            return result;
        }
        public void isHpChecked()
        {
            if (hpCB.Checked == true)
            {
                p.setHP("True");
            }else
            {
                p.setHP("False");
            }
        }
    }
}
