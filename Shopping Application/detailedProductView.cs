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
    public partial class detailedProductView : UserControl
    {
        Product p;
        Form1 f1;
        public detailedProductView(Product p,Form1 f1)
        {
            InitializeComponent();
            this.p = p;
            this.f1 = f1;
            product_name.Text = p.getName();
            priceLabel.Text = p.getPrice().ToString();
            productDetails.Text = p.getDetails();
            pictureBox1.Image = p.getImage();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void add_cart_Click(object sender, EventArgs e)
        {
            f1.cartList.Add(p);
            f1.updateCartPreview(p);
            MessageBox.Show("Product added to cart !");
        }

        private void product_counter_ValueChanged(object sender, EventArgs e)
        {
            p.setProductCount((int)product_counter.Value);
        }
    }
}
