using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace Shopping_Application
{
    public partial class adminAddProduct : UserControl
    {
        public Panel panel1;
        public int y = 0;
        public int x = 0;
        public Dictionary<string, string> item;
        Bitmap image;
        public string imageLocation;
        byte[] rawData;
        FileStream fs;
        UInt32 FileSize;
        public adminAddProduct()
        {
            InitializeComponent();
            updateCatCB();
            save.Enabled = false;
            createPanel();
        }
        public void createPanel()
        {
            panel1 = new Panel();
            panel1.AutoSize = true;
            item = new Dictionary<string, string>();
            ProductDetail pd = new ProductDetail(panel1, y, item, this);
            panel1.Location = new Point(15, 190);
            panel1.Visible = true;
            panel1.Controls.Add(pd);
            this.Controls.Add(panel1);
        }

        private void save_Click(object sender, EventArgs e)
        {
            string details = "";
            Regex r = new Regex(@"^[0-9]*$");
            string price = priceTB.Text;
            if (!(descriptionRTB.Text.Length == 0) && (r.IsMatch(price)))
            {
                item.Add("Description", descriptionRTB.Text);
                details = generateDictionaryString(item);
                Product p = new Product(uidGenerator(), productNameTb.Text, details, image, Int32.Parse(priceTB.Text),
                                        categoriesCB.Items[categoriesCB.SelectedIndex].ToString(), isHP(hp_checkB.Checked), FileSize);
                DbConnection conn = new DbConnection();
                conn.insertProduct(p.getPid(), p.getName(), p.getDetails(), rawData, p.getPrice().ToString(), p.getCategory(), p.getHP(), FileSize);
                MessageBox.Show("Product saved !");
                priceTB.Clear();
                productNameTb.Clear();
                descriptionRTB.Clear();
                hp_checkB.Checked = false;
                categoriesCB.SelectedIndex = -1;
                this.Controls.Remove(panel1);
                createPanel();
            }
            else
            {
                MessageBox.Show("Please fill required blanks !");
            }
        }
        // https://www.dotnetperls.com/convert-dictionary-string
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
        // https://www.dotnetperls.com/convert-dictionary-string
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
                    item[name] += freq;
                else
                    item.Add(name, freq);
            }
            return item;
        }
        public String uidGenerator()
        {
            StringBuilder builder = new StringBuilder();
            Enumerable
               .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(12)
                .ToList().ForEach(e => builder.Append(e));
            string id = builder.ToString();
            return id;
        }

        private void browseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Select Image";
            opd.Filter = "jpg files (*.jpg)|*.jpg";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                save.Enabled = true;
                // Create a new Bitmap object from the picture file on disk,
                // and assign that to the PictureBox.Image property
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap(opd.FileName);
                imageLocation = opd.FileName;
                Console.WriteLine(imageLocation);
                fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                FileSize = (UInt32)fs.Length;
                rawData = new byte[FileSize];
                fs.Read(rawData, 0, (int)FileSize);
                fs.Close();
                Product hp = new Product();
                hp.setImage(hp.ByteArrayToImage(rawData));
                pictureBox1.Image = hp.ByteArrayToImage(rawData);
                Console.WriteLine(rawData.Length);
            }
        }
        public void updateCatCB()
        {
            DbConnection conn = new DbConnection();
            string[] cat = conn.getCategories().ToArray();
            int i;
            for (i = 0; i < cat.Count(); i++)
            {
                categoriesCB.Items.Add(cat[i]);
            }
        }
        public string isHP(bool Checked)
        {
            if (Checked)
                return "True";
            else
                return "False";

        }
        public static Image ByteArrayToImagebyMemoryStream(byte[] imageByte)
        {
            MemoryStream ms = new MemoryStream(imageByte);
            Image image = Image.FromStream(ms);
            return image;
        }
    }
}
