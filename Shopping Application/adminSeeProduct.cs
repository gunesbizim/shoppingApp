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

namespace Shopping_Application
{
    public partial class adminSeeProduct : UserControl
    {
        public string imageLocation;
        byte[] rawData;
        FileStream fs;
        UInt32 FileSize;
        Product p;
        DbConnection conn = new DbConnection();
        adminProduct ap;
        
        public adminSeeProduct(Product p,adminProduct ap)
        {
            InitializeComponent();
            this.p = p;
            nameTB.Text = p.getName();
            priceTB.Text = p.getPrice().ToString();
            richTextBox1.Text = p.getDetails();
            pictureBox1.Image = p.getImage();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ap = ap;
            
        }

        private void deleteBT_Click(object sender, EventArgs e)
        {
            if (conn.sendCommand(conn.deleteFromProducts(p.getPid())))
            {
                MessageBox.Show("Product deleted from category !");
                conn = new DbConnection();
                List<Product> plist = conn.getAllProducts();
                ap.panel1.Controls.Clear();
                ap.setYToZero();
                ap.viewProducts(ap.listToOrdered(plist));
            }else
            {
                MessageBox.Show("Unsuccessful connection !");
            }
            
        }

        private void editBT_Click(object sender, EventArgs e)
        {
            editProduct ep = new editProduct(p,ap);
            ep.StartPosition = FormStartPosition.CenterParent;
            ep.Show();
        }
    }
}

