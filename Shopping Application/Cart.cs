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
        DbConnection conn;
        List<AdressObj> aol;
        public Cart(List<Product> cartList,Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            this.cartList = cartList;
            createCartProducts();
            conn = new DbConnection();
            aol = conn.getAdress(f1.u.getUid());
            adressToCB();
            if(f1.logedIn == false)
                place_order.Enabled = false;
           
        }
  
        public void createCartProducts()
        {
            int i;
            for (i=0;i<cartList.Count;i++)
            {
                cartProductView cpv = new cartProductView(cartList[i], f1);
                cpv.Location = new Point(0, y);
                panel1.Controls.Add(cpv);
                y += 155;

            }

        }

        private void clear_cart_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            f1.clearCart();
        }
        public void adressToCB()
        {
            int i;
            for (i = 0; i < aol.Count; i++)
            {
                adressCB.Items.Add(aol[i]);
            }
        }

        private void place_order_Click(object sender, EventArgs e)
        {
            if (cartList.Count <= 0)
            {
                MessageBox.Show("Your cart is empty !");
            }else
            {
                OrderObj o = new OrderObj();
                o.setOid(oidGenerator());
                o.setUid(f1.u.getUid());
                Dictionary<string, string> od = new Dictionary<string, string>();
                int i;
                string pids = "";
                int totalPrice = 0;
                for (i = 0; i < cartList.Count; i++)
                {
                    pids += cartList[i].getPid() + ",";
                    totalPrice += cartList[i].getPrice() * cartList[i].getProductCount();
                }
                od.Add("pids", pids);
                od.Add("totalPrice", totalPrice.ToString());
                AdressObj ao = (AdressObj)adressCB.SelectedItem;
                if (adressCB.SelectedIndex < 0)
                    MessageBox.Show("Please choose an adress");
                else
                {
                    od.Add("adress", ao.getAid());
                    o.setDetails(generateDictionaryString(od));
                    conn.sendCommand(conn.insertOrder(o));
                    MessageBox.Show("Order send ! ");
                    panel1.Controls.Clear();
                    f1.clearCart();
                }
            }
           
        }
        public String oidGenerator()
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
    }
}
