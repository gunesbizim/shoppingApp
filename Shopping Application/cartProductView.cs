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
    public partial class cartProductView : UserControl
    {
        Form1 f1;
        Product p;
        public cartProductView(Product p, Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            productNameTB.Text = p.getName();
            priceTB.Text = p.getPrice().ToString();
            pictureBox1.Image = p.getImage();
            this.p = p;
            numericUpDown1.Value = p.getProductCount();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            p.setProductCount((int)numericUpDown1.Value);
            Console.WriteLine(p.getProductCount());
            if (f1 != null)
                f1.updateCartPreview(p);
            else
                Console.WriteLine("f1 is null ???");
        }

    }
}
