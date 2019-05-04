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
    public partial class CatView : UserControl
    {
        Form1 f1;
        List<Product> plist;
        int lastViewedItem;
        int lastSelectedIndex;
        DbConnection conn;
        int x = 10;
        int y = 10;
        public CatView(Form1 f1, string catName)
        {
            
            InitializeComponent();
            this.f1 = f1;
            string [] a ={ "10","20","30", "40", "50" };
            comboBox1.Items.AddRange(a);
            label1.Text = catName;
            conn = new DbConnection();
            lastViewedItem = 0;
            lastSelectedIndex = 10;
            comboBox1.SelectedIndex = 0;
          


        }

        public OrderedDoublyLinkedList listToOrdered(List<Product> list)
        {
            OrderedDoublyLinkedList odl2 = new OrderedDoublyLinkedList();
            int i;

            for (i = 0; i < list.Count; i++)
            {
                Product p = list[i];
                odl2.insert(p);   
            }
            return odl2;
        }
        public void viewProducts(OrderedDoublyLinkedList odl)
        {
            
            Node current = odl.getFirst();
            int xCount = 0;
            int totalCount = 0;
            while (current != null)
            {
                productView pv = new productView(current.getItem(),f1);
                if (xCount < 6)
                {
                    pv.Location = new Point(x, y);
                    panel1.Controls.Add(pv);
                    x += 205;
                    current = current.getNext();
                    xCount++;
                    totalCount++;
                }
                else
                {
                    if (totalCount % 6 == 0)
                    {
                        y += 210;
                        x = 10;
                        pv.Location = new Point(10, y);
                        panel1.Controls.Add(pv);
                        current = current.getNext();
                        xCount = 0;
                    }
                }
            }            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedIndex == 0)
            {
                x = 10; y = 10;
                panel1.Controls.Clear();
                plist = conn.getProductsFromCat(label1.Text, 0, 10);
                viewProducts(listToOrdered(plist));
                
            }else if (comboBox1.SelectedIndex == 1)
            {
                x = 10; y = 10;
                panel1.Controls.Clear();
                plist = conn.getProductsFromCat(label1.Text, 0, 20);
                viewProducts(listToOrdered(plist));
                
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                x = 10; y = 10;
                panel1.Controls.Clear();
                plist = conn.getProductsFromCat(label1.Text, 0, 30);
                viewProducts(listToOrdered(plist));
                
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                x = 10; y = 10;
                panel1.Controls.Clear();
                plist = conn.getProductsFromCat(label1.Text, 0, 40);
                viewProducts(listToOrdered(plist));
                
            }
            else
            {
                x = 10; y = 10;
                panel1.Controls.Clear();
                plist = conn.getProductsFromCat(label1.Text, 0, 50);
                viewProducts(listToOrdered(plist));
                
            }


        }

        private void nextBt_Click(object sender, EventArgs e)
        {
            x = 10; y = 10;
            panel1.Controls.Clear();
            plist = conn.getProductsFromCat(label1.Text, lastViewedItem, lastSelectedIndex);
            lastViewedItem += lastSelectedIndex;
            viewProducts(listToOrdered(plist));
        }

        private void prevBt_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            plist = conn.getProductsFromCat(label1.Text, lastViewedItem, lastSelectedIndex);
            lastViewedItem -= (lastSelectedIndex*2);
            viewProducts(listToOrdered(plist));

        }
    }
}
