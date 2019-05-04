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
    public partial class adminProduct : UserControl
    {
        DbConnection conn;
        List<Product> plist;
        int y= 0;
       
        public adminProduct()
        {
            InitializeComponent();
            conn = new DbConnection();
            plist = conn.getAllProducts();
            viewProducts(listToOrdered(plist));
            

        }
        public OrderedDoublyLinkedList listToOrdered(List<Product> list)
        {
            OrderedDoublyLinkedList odl = new OrderedDoublyLinkedList();
            int i;

            for (i = 0; i < list.Count; i++)
            {
                Product p = list[i];
                odl.insert(p);
            }
            return odl;
        }
        public void viewProducts(OrderedDoublyLinkedList odl)
        {
            Node current = odl.getFirst();
            adminSeeProduct asp;
            while (current != null)
            {
                asp = new adminSeeProduct(current.getItem(),this);
                panel1.Controls.Add(asp);
                asp.Location = new Point(0, y);
                y += 151;
                current = current.getNext();
            }
        }
        public void setYToZero() { y = 0; }

        private void searchBT_Click(object sender, EventArgs e)
        {
            DbConnection conn = new DbConnection();
            conn.searchProduct("test");
            panel1.Controls.Clear();
            setYToZero();
            viewProducts(listToOrdered(conn.searchProduct(searchBox.Text)));

        }
        public void refresh()
        {
            panel1.Controls.Clear();
            setYToZero();
            plist = conn.getAllProducts();
            viewProducts(listToOrdered(plist));
        }
    }
}
