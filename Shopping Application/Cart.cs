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
    public partial class Cart : UserControl
    {
        List<Product> cartList;
        int y = 0;
        Form1 f1;
        public Cart(List<Product> cartList,Form1 f1)
        {
            InitializeComponent();
            this.cartList = cartList;
            createCartProducts();
            this.f1 = f1;
        }
  
        public void createCartProducts()
        {
            foreach(var p in cartList)
            {
                cartProductView cpv = new cartProductView(p,f1);
                cpv.Location = new Point(0,y);
                panel1.Controls.Add(cpv);
                y += 155;
            }
        }

        private void clear_cart_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            f1.clearCart();
        }
    }
}
