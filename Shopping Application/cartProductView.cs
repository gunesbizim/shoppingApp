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
        int firstValue;
        Form1 f1;
        public cartProductView(Product p,Form1 f1)
        {
            InitializeComponent();
            productNameTB.Text = p.getName();
            priceTB.Text = p.getPrice().ToString();
            pictureBox1.Image = p.getImage();
            this.f1 = f1;
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cartProductView_MouseEnter(object sender, EventArgs e)
        {
            firstValue = (int)numericUpDown1.Value;
            
        }
    }
}
