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
    public partial class productView : UserControl
    {
        Form1 f1;
        Product p;
        public productView(Product p,Form1 f1)
        {
            InitializeComponent();
            pNameTB.Text = p.getName();
            pictureBox1.Image = p.getImage();
            this.f1 = f1;
            this.p = p;
            
        }

        private void addCart_Click(object sender, EventArgs e)
        {
            f1.cartList.Add(p);
            f1.updateCartPreview(p);
            MessageBox.Show("Product added to cart !");            
        }

       
    }
}
